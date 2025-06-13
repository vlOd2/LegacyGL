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
        LGL.Size = new System.Drawing.Size(w, h);
        LGL.Title = "Example Game";
        LGL.Resizable = true;
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

            System.Drawing.Size size = LGL.Size;
            if (size.Width != w || size.Height != h)
            {
                w = size.Width;
                h = size.Height;
                glViewport(0, 0, w, h);
            }

            LGL.Update();
        }
    }
}   