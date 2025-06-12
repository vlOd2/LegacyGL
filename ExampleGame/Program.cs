using LegacyGL;
using static LegacyGL.Bindings.GL10;

namespace ExampleGame;

public static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        int w = 640;
        int h = 480;

        ContextRequest ctxReq = new();
        LGL.Init(ref ctxReq);
        LGL.VWidth = w;
        LGL.VHeight = h;
        LGL.VTitle = "Example Game";
        LGL.VResizable = true;
        LGL.Center();

        glClearColor(1.0F, 0.0F, 0.0F, 1.0F);
        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
        glMatrixMode(GL_MODELVIEW);
        glLoadIdentity();
        glViewport(0, 0, w, h);

        while (!LGL.ShouldClose)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glBegin(GL_TRIANGLES);
            glVertex2f(-0.5F, -0.5F);
            glVertex2f(0.5F, -0.5F);
            glVertex2f(0F, 0.5F);
            glEnd();

            if (LGL.VWidth != w || LGL.VHeight != h)
            {
                w = LGL.VWidth;
                h = LGL.VHeight;
                glViewport(0, 0, w, h);
            }

            LGL.Update();
        }
    }
}   