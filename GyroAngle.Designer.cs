namespace GyroAngle
{
    partial class GyroAngle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl = new SharpGL.OpenGLControl();
            this.label_Pitch = new System.Windows.Forms.Label();
            this.label_Yaw = new System.Windows.Forms.Label();
            this.label_Roll = new System.Windows.Forms.Label();
            this.label_HX = new System.Windows.Forms.Label();
            this.label_HY = new System.Windows.Forms.Label();
            this.label_HZ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.DrawFPS = false;
            this.openGLControl.FrameRate = 60;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(320, 320);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            // 
            // label_Pitch
            // 
            this.label_Pitch.AutoSize = true;
            this.label_Pitch.BackColor = System.Drawing.Color.Transparent;
            this.label_Pitch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pitch.ForeColor = System.Drawing.Color.Snow;
            this.label_Pitch.Location = new System.Drawing.Point(30, 324);
            this.label_Pitch.Name = "label_Pitch";
            this.label_Pitch.Size = new System.Drawing.Size(100, 22);
            this.label_Pitch.TabIndex = 1;
            this.label_Pitch.Text = "Pitch : 0";
            // 
            // label_Yaw
            // 
            this.label_Yaw.AutoSize = true;
            this.label_Yaw.BackColor = System.Drawing.Color.Transparent;
            this.label_Yaw.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yaw.ForeColor = System.Drawing.Color.Snow;
            this.label_Yaw.Location = new System.Drawing.Point(30, 348);
            this.label_Yaw.Name = "label_Yaw";
            this.label_Yaw.Size = new System.Drawing.Size(100, 22);
            this.label_Yaw.TabIndex = 3;
            this.label_Yaw.Text = "Yaw   : 0";
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.BackColor = System.Drawing.Color.Transparent;
            this.label_Roll.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Roll.ForeColor = System.Drawing.Color.Snow;
            this.label_Roll.Location = new System.Drawing.Point(30, 372);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(100, 22);
            this.label_Roll.TabIndex = 2;
            this.label_Roll.Text = "Roll  : 0";
            // 
            // label_HX
            // 
            this.label_HX.AutoSize = true;
            this.label_HX.BackColor = System.Drawing.Color.Transparent;
            this.label_HX.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HX.ForeColor = System.Drawing.Color.Snow;
            this.label_HX.Location = new System.Drawing.Point(192, 324);
            this.label_HX.Name = "label_HX";
            this.label_HX.Size = new System.Drawing.Size(70, 22);
            this.label_HX.TabIndex = 4;
            this.label_HX.Text = "HX : 0";
            // 
            // label_HY
            // 
            this.label_HY.AutoSize = true;
            this.label_HY.BackColor = System.Drawing.Color.Transparent;
            this.label_HY.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HY.ForeColor = System.Drawing.Color.Snow;
            this.label_HY.Location = new System.Drawing.Point(192, 348);
            this.label_HY.Name = "label_HY";
            this.label_HY.Size = new System.Drawing.Size(70, 22);
            this.label_HY.TabIndex = 5;
            this.label_HY.Text = "HY : 0";
            // 
            // label_HZ
            // 
            this.label_HZ.AutoSize = true;
            this.label_HZ.BackColor = System.Drawing.Color.Transparent;
            this.label_HZ.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HZ.ForeColor = System.Drawing.Color.Snow;
            this.label_HZ.Location = new System.Drawing.Point(192, 372);
            this.label_HZ.Name = "label_HZ";
            this.label_HZ.Size = new System.Drawing.Size(70, 22);
            this.label_HZ.TabIndex = 6;
            this.label_HZ.Text = "HZ : 0";
            // 
            // GyroAngle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label_Pitch);
            this.Controls.Add(this.label_Yaw);
            this.Controls.Add(this.label_Roll);
            this.Controls.Add(this.label_HX);
            this.Controls.Add(this.label_HY);
            this.Controls.Add(this.label_HZ);
            this.Controls.Add(this.openGLControl);
            this.Name = "GyroAngle";
            this.Size = new System.Drawing.Size(320, 400);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Pitch;
        private System.Windows.Forms.Label label_Yaw;
        private System.Windows.Forms.Label label_Roll;

        private System.Windows.Forms.Label label_HX;
        private System.Windows.Forms.Label label_HY;
        private System.Windows.Forms.Label label_HZ;

        private SharpGL.OpenGLControl openGLControl;
    }
}
