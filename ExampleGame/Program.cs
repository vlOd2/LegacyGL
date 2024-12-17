using LegacyGL;
using static LegacyGL.OpenGL.GL;

namespace ExampleGame
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            LGL.Init();
            LGL.VWidth = 640;
            LGL.VHeight = 480;
            LGL.VTitle = "Example Game";
            LGL.VResizable = true;
            LGL.Center();

            glClearColor(1.0F, 0.0F, 0.0F, 1.0F);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            
            while (!LGL.ShouldClose)
            {
                glClear(GL_COLOR_BUFFER_BIT);
                glBegin(GL_TRIANGLES);
                glVertex2f(-0.5F, -0.5F);
                glVertex2f(0.5F, -0.5F);
                glVertex2f(0F, 0.5F);
                glEnd();
                
                LGL.Update();
            }            
        }
    }   
}