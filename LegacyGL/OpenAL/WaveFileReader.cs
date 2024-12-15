// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.IO;

namespace LegacyGL.OpenAL
{
    public struct WaveHeader
    {
        public short Channels;
        public int Samples;
        public int SampleRate;
        public short BlockAlign;
        public short BitsPerSample;
    }

    public static class WaveFileReader
    {
        private static void ReadFully(Stream stream, byte[] buffer)
        {
            int remaining = buffer.Length;
            int offset = 0;

            while (remaining > 0)
            {
                int read = stream.Read(buffer, offset, remaining);
                offset += read;
                remaining -= read;
            }
        }

        private static bool ArraysEqual(byte[] x, byte[] y, int offset)
        {
            if (x.Length - offset != y.Length)
                return false;

            for (int i = 0; i < x.Length; i++)
                if (x[i + offset] != y[i])
                    return false;

            return true;
        }

        private static uint CalculateSection(string section)
        {
            if (section.Length > 4)
                throw new ArgumentException("dafuq?");
            uint nr = 0;

            for (int i = 0; i < section.Length; i++)
                nr |= (uint)section[i] << (i << 3);

            return nr;
        }

        private static void ReadToSection(Stream stream, uint section)
        {
            int b;
            int matches = 0;

            while (matches < 4 && (b = stream.ReadByte()) != -1)
            {
                byte expected = (byte)((section >> (matches << 3)) & 0xFF);
                if (b == expected)
                    matches++;
                else
                    matches = 0;
            }
        }

        private static short ReadInt16(Stream stream)
        {
            byte[] buffer = new byte[2];
            ReadFully(stream, buffer);
            return (short)(buffer[0] | buffer[1] << 8);
        }

        private static int ReadInt32(Stream stream)
        {
            byte[] buffer = new byte[4];
            ReadFully(stream, buffer);
            return buffer[0] | buffer[1] << 8 | buffer[2] << 16 | buffer[3] << 24;
        }

        public static void Read(Stream source, out WaveHeader waveHeader, out byte[] pcmData)
        {
            ReadToSection(source, CalculateSection("fmt "));
            ReadInt32(source); // Not needed
            ReadInt16(source); // Not needed
            waveHeader = new WaveHeader();
            waveHeader.Channels = ReadInt16(source);
            waveHeader.Samples = ReadInt32(source);
            waveHeader.SampleRate = ReadInt32(source);
            waveHeader.BlockAlign = ReadInt16(source);
            waveHeader.BitsPerSample = ReadInt16(source);

            ReadToSection(source, CalculateSection("data"));
            int pcmDataSize = ReadInt32(source);
            pcmData = new byte[pcmDataSize];
            ReadFully(source, pcmData);

            source.Close();
            source.Dispose();
        }
    }
}
