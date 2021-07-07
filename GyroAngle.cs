using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Core;
using SharpGL.SceneGraph.Primitives;
using SharpGL.Serialization;
using SharpGL.Enumerations;

namespace GyroAngle
{
    public partial class GyroAngle: UserControl
    {
        private string M_Model = "";

        private float M_Pitch = 0.0f;
        private float M_Yaw   = 0.0f;
        private float M_Roll  = 0.0f;

        private float M_HX = 0.0f;
        private float M_HY = 0.0f;
        private float M_HZ = 0.0f;

        List<Polygon> polygons = new List<Polygon>();

        public GyroAngle()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0, 0.0, -20.0);

            gl.Rotate(M_Pitch, 1.0, 0.0, 0.0);
            gl.Rotate(M_Yaw, 0.0, 1.0, 0.0);
            gl.Rotate(M_Roll, 0.0, 0.0, 1.0);

            foreach (Polygon polygon in polygons)
            {
                polygon.PushObjectSpace(gl);
                polygon.Render(gl, RenderMode.Render);
                polygon.PopObjectSpace(gl);
            }

            this.label_Pitch.Text = "Pitch : " + M_Pitch.ToString();
            this.label_Yaw.Text   = "Yaw   : " + M_Yaw.ToString();
            this.label_Roll.Text  = "Roll  : " + M_Roll.ToString();

            this.label_HX.Text = "HX : " + M_HX.ToString();
            this.label_HY.Text = "HY : " + M_HY.ToString();
            this.label_HZ.Text = "HZ : " + M_HZ.ToString();

            gl.Flush();
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = this.openGLControl.OpenGL;

            gl.PolygonMode(FaceMode.FrontAndBack, PolygonMode.Filled);

            float[] global_ambient = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };

            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, global_ambient);
            gl.Enable(OpenGL.GL_LIGHTING);

            float[] light0pos = new float[] { 1.0f, 1.0f, 0.0f, 0.0f };
            float[] light0ambient = new float[] { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] light0diffuse = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light0specular = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };

            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, light0pos);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, light0ambient);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, light0diffuse);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, light0specular);

            gl.Enable(OpenGL.GL_LIGHT0);

            float[] light1pos = new float[] { 1.0f, 1.0f, 0.0f, 1.0f };
            float[] light1ambient = new float[] { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] light1diffuse = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light1specular = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };

            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_POSITION, light1pos);
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_AMBIENT, light1ambient);
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_DIFFUSE, light1diffuse);
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_SPECULAR, light1specular);

            //gl.Enable(OpenGL.GL_LIGHT0);

            float[] light2pos = new float[] { 1.0f, 1.0f, 0.0f, 1.0f };
            float[] light2ambient = new float[] { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] light2diffuse = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light2specular = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };

            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_POSITION, light2pos);
            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_AMBIENT, light2ambient);
            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_DIFFUSE, light2diffuse);
            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_SPECULAR, light2specular);

            //gl.Enable(OpenGL.GL_LIGHT2);

            gl.ColorMaterial(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_AMBIENT_AND_DIFFUSE);
            gl.Enable(OpenGL.GL_COLOR_MATERIAL);

            float[] mat_specular = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] mat_emission = new float[] { 0.0f, 0.0f, 0.0f, 1.0f };

            gl.Material(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_SPECULAR, mat_specular);
            gl.Material(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_EMISSION, mat_emission);

            gl.ShadeModel(OpenGL.GL_SMOOTH);

            loadModel();
        }

        private void loadModel()
        {
            OpenGL gl = this.openGLControl.OpenGL;

            try {
                polygons.Clear();

                Scene scene = SerializationEngine.Instance.LoadScene(M_Model);
                if (scene != null)
                {
                    foreach (var polygon in scene.SceneContainer.Traverse<Polygon>())
                    {
                        //  Get the bounds of the polygon.
                        BoundingVolume boundingVolume = polygon.BoundingVolume;
                        float[] extent = new float[3];
                        polygon.BoundingVolume.GetBoundDimensions(out extent[0], out extent[1], out extent[2]);

                        //  Get the max extent.
                        float maxExtent = extent.Max();

                        //  Scale so that we are at most 10 units in size.
                        float scaleFactor = maxExtent > 10 ? 10.0f / maxExtent : 1;
                        polygon.Transformation.ScaleX = scaleFactor;
                        polygon.Transformation.ScaleY = scaleFactor;
                        polygon.Transformation.ScaleZ = scaleFactor;
                        polygon.Freeze(gl);
                        polygons.Add(polygon);
                    }
                }
            } catch { }
        }

        [Category("模型文件")]
        [Description("模型文件路径")]
        [DefaultValue("")]
        public string Model
        {
            get { return M_Model; }
            set
            {
                if (M_Model != value)
                {
                    M_Model = value;
                    this.loadModel();
                }
            }
        }

        [Category("姿态数据")]
        [Description("俯仰角数据值，角度值(0-360)")]
        [DefaultValue(0)]
        public float Pitch
        {
            get { return M_Pitch; }
            set
            {
                if (M_Pitch != value)
                {
                    M_Pitch = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }

        [Category("姿态数据")]
        [Description("航向角数据值，角度值(0-360)")]
        [DefaultValue(0)]
        public float Yaw
        {
            get { return M_Yaw; }
            set
            {
                if (M_Yaw != value)
                {
                    M_Yaw = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }

        [Category("姿态数据")]
        [Description("横滚角数据值，角度值(0-360)")]
        [DefaultValue(0)]
        public float Roll
        {
            get { return M_Roll; }
            set
            {
                if (M_Roll != value)
                {
                    M_Roll = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }

        [Category("罗盘数据")]
        [Description("罗盘数据HX")]
        [DefaultValue(0)]
        public float HX
        {
            get { return M_HX; }
            set
            {
                if (M_HX != value)
                {
                    M_HX = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }

        [Category("罗盘数据")]
        [Description("罗盘数据HY")]
        [DefaultValue(0)]
        public float HY
        {
            get { return M_HY; }
            set
            {
                if (M_HY != value)
                {
                    M_HY = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }

        [Category("罗盘数据")]
        [Description("罗盘数据HZ")]
        [DefaultValue(0)]
        public float HZ
        {
            get { return M_HZ; }
            set
            {
                if (M_HZ != value)
                {
                    M_HZ = value;
                    this.Invalidate();
                    this.Update();
                }
            }
        }
    }
}
