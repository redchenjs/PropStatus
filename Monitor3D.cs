using System;
using System.Windows.Forms;
using SharpGL;

namespace Monitor3D
{
    public partial class Monitor3D: UserControl
    {
        public Monitor3D()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.Translate(0.0f, 0.0f, -10.0f);

            // 平滑法线
            IntPtr glNewQuadric = gl.NewQuadric();
            gl.QuadricNormals(glNewQuadric, OpenGL.GLU_SMOOTH);

            // X-axis arrow
            gl.Translate(4.0f, -2.0f, -2.0f);
            gl.Rotate(90, 0.0f, 1.0f, 0.0f);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Cylinder(glNewQuadric, 0.1f, 0.0f, 0.5f, 32, 32);

            gl.Rotate(-90, 0.0f, 1.0f, 0.0f);
            gl.Translate(-4.0f, 2.0f, 2.0f);

            // Y-axis arrow
            gl.Translate(-2.0f, 4.0f, -2.0f);
            gl.Rotate(-90, 1.0f, 0.0f, 0.0f);

            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Cylinder(glNewQuadric, 0.1f, 0.0f, 0.5f, 32, 32);

            gl.Rotate(90, 1.0f, 0.0f, 0.0f);
            gl.Translate(2.0f, -4.0f, 2.0f);

            // Z-axis arrow
            gl.Translate(-2.0f, -2.0f, 4.0f);

            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Cylinder(glNewQuadric, 0.1f, 0.0f, 0.5f, 32, 32);

            gl.Translate(2.0f, 2.0f, -4.0f);

            // 坐标轴线宽
            gl.LineWidth(2.0f);

            // X-axis line
            gl.Color(1.0f, 1.0f, 1.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(-2.0f, -2.0f, -2.0f);
                gl.Vertex(4.0f, -2.0f, -2.0f);
            gl.End();

            // Y-axis line
            gl.Color(1.0f, 1.0f, 1.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(-2.0f, -2.0f, -2.0f);
                gl.Vertex(-2.0f, 4.0f, -2.0f);
            gl.End();

            // Z-axis line
            gl.Color(1.0f, 1.0f, 1.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(-2.0f, -2.0f, -2.0f);
                gl.Vertex(-2.0f, -2.0f, 4.0f);
            gl.End();

            // 坐标旋转
            gl.Rotate(rquad[0], 1.0f, 0.0f, 0.0f);
            gl.Rotate(rquad[1], 0.0f, 1.0f, 0.0f);
            gl.Rotate(rquad[2], 0.0f, 0.0f, 1.0f);

            // Front
            gl.Color(1.0f, 0.0f, 0.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(-1.5f, 0.5f, 1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.5f, 0.5f, 1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.5f, -0.5f, 1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(-1.5f, -0.5f, 1.0f);
            gl.End();

            // Back
            gl.Color(0.0f, 1.0f, 0.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(-1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.5f, -0.5f, -1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(-1.5f, -0.5f, -1.0f);
            gl.End();

            // Left
            gl.Color(0.0f, 0.0f, 1.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(-1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(-1.5f, -0.5f, -1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(-1.5f, -0.5f, 1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(-1.5f, 0.5f, 1.0f);
            gl.End();

            // Right
            gl.Color(1.0f, 0.0f, 1.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.5f, -0.5f, -1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.5f, -0.5f, 1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(1.5f, 0.5f, 1.0f);
            gl.End();

            // Top
            gl.Color(1.0f, 1.0f, 0.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(-1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.5f, 0.5f, -1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.5f, 0.5f, 1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(-1.5f, 0.5f, 1.0f);
            gl.End();

            // Bottom
            gl.Color(0.0f, 1.0f, 1.0f);

            gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(-1.5f, -0.5f, -1.0f);
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.5f, -0.5f, -1.0f);
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.5f, -0.5f, 1.0f);
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(-1.5f, -0.5f, 1.0f);
            gl.End();

            // X-axis
            gl.Color(1.0f, 0.0f, 0.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(2.0f, 0.0f, 0.0f);
                gl.Vertex(-2.0f, 0.0f, 0.0f);
            gl.End();

            // Y-axis
            gl.Color(0.0f, 1.0f, 0.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(0.0f, 2.0f, 0.0f);
                gl.Vertex(0.0f, -2.0f, 0.0f);
            gl.End();

            // Z-axis
            gl.Color(0.0f, 0.0f, 1.0f);

            gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(0.0f, 0.0f, 2.0f);
                gl.Vertex(0.0f, 0.0f, -2.0f);
            gl.End();

            gl.Flush();
        }

        public float[] Rotation
        {
            get
            {
                return rquad;
            }
            set
            {
                rquad = value;
            }
        }

        private float[] rquad = { 0.0f, 0.0f, 0.0f };
    }
}
