﻿namespace _20127149
{
    partial class MyPaint
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rectangular = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btnPickColorBorder = new System.Windows.Forms.Button();
            this.glControl = new SharpGL.OpenGLControl();
            this.borderWidthControl = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.executedTime = new System.Windows.Forms.Label();
            this.componentList = new System.Windows.Forms.CheckedListBox();
            this.componetListLabel = new System.Windows.Forms.Label();
            this.timeExecutedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.colorBorderPicker = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btn_rectangular);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_rectangular
            // 
            this.btn_rectangular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_rectangular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rectangular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rectangular.Location = new System.Drawing.Point(106, 28);
            this.btn_rectangular.Name = "btn_rectangular";
            this.btn_rectangular.Size = new System.Drawing.Size(107, 43);
            this.btn_rectangular.TabIndex = 3;
            this.btn_rectangular.Text = "Rectangular";
            this.btn_rectangular.UseVisualStyleBackColor = false;
            this.btn_rectangular.Click += new System.EventHandler(this.Btn_Rectangular_Cliked);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_circle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_circle.Location = new System.Drawing.Point(219, 29);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(96, 43);
            this.btn_circle.TabIndex = 2;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.Btn_Circle_Clicked);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ellipse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ellipse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.Location = new System.Drawing.Point(321, 29);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(99, 43);
            this.btn_ellipse.TabIndex = 1;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.Btn_Ellipse_Clicked);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_line.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.Location = new System.Drawing.Point(6, 28);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(94, 44);
            this.btn_line.TabIndex = 0;
            this.btn_line.Text = "Line";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.Btn_Line_Cliked);
            // 
            // btnPickColorBorder
            // 
            this.btnPickColorBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPickColorBorder.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickColorBorder.ForeColor = System.Drawing.Color.White;
            this.btnPickColorBorder.Location = new System.Drawing.Point(6, 61);
            this.btnPickColorBorder.Name = "btnPickColorBorder";
            this.btnPickColorBorder.Size = new System.Drawing.Size(139, 42);
            this.btnPickColorBorder.TabIndex = 3;
            this.btnPickColorBorder.Text = "Pick Color Border";
            this.btnPickColorBorder.UseVisualStyleBackColor = false;
            this.btnPickColorBorder.Click += new System.EventHandler(this.BtnColorPickerClick);
            // 
            // glControl
            // 
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.DrawFPS = false;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.glControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.glControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.glControl.Size = new System.Drawing.Size(1290, 760);
            this.glControl.TabIndex = 2;
            this.glControl.OpenGLInitialized += new System.EventHandler(this.GlControl_OpenGLInitialized);
            this.glControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.GlControl_OpenGLDraw);
            this.glControl.Resized += new System.EventHandler(this.GlControl_Resized);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControlMouseDown);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControlMouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControlMouseUp);
            // 
            // borderWidthControl
            // 
            this.borderWidthControl.BackColor = System.Drawing.Color.Gold;
            this.borderWidthControl.Location = new System.Drawing.Point(106, 24);
            this.borderWidthControl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.borderWidthControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidthControl.Name = "borderWidthControl";
            this.borderWidthControl.Size = new System.Drawing.Size(39, 20);
            this.borderWidthControl.TabIndex = 3;
            this.borderWidthControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidthControl.ValueChanged += new System.EventHandler(this.BorderWidthControlValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.executedTime);
            this.panel2.Controls.Add(this.componentList);
            this.panel2.Controls.Add(this.componetListLabel);
            this.panel2.Controls.Add(this.timeExecutedLabel);
            this.panel2.Controls.Add(this.btnPickColorBorder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.borderWidthControl);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 660);
            this.panel2.TabIndex = 3;
            // 
            // executedTime
            // 
            this.executedTime.AutoSize = true;
            this.executedTime.Location = new System.Drawing.Point(6, 308);
            this.executedTime.Name = "executedTime";
            this.executedTime.Size = new System.Drawing.Size(35, 13);
            this.executedTime.TabIndex = 8;
            this.executedTime.Text = "label2";
            // 
            // componentList
            // 
            this.componentList.FormattingEnabled = true;
            this.componentList.Location = new System.Drawing.Point(6, 189);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(139, 94);
            this.componentList.TabIndex = 7;
            this.componentList.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSelectedIndexChanged);
            // 
            // componetListLabel
            // 
            this.componetListLabel.AutoSize = true;
            this.componetListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componetListLabel.Location = new System.Drawing.Point(3, 160);
            this.componetListLabel.Name = "componetListLabel";
            this.componetListLabel.Size = new System.Drawing.Size(122, 18);
            this.componetListLabel.TabIndex = 6;
            this.componetListLabel.Text = "Component list";
            // 
            // timeExecutedLabel
            // 
            this.timeExecutedLabel.AutoSize = true;
            this.timeExecutedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeExecutedLabel.Location = new System.Drawing.Point(3, 286);
            this.timeExecutedLabel.Name = "timeExecutedLabel";
            this.timeExecutedLabel.Size = new System.Drawing.Size(119, 18);
            this.timeExecutedLabel.TabIndex = 5;
            this.timeExecutedLabel.Text = "Time Executed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Border Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(363, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.glControl);
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_ellipse;
        private SharpGL.OpenGLControl glControl;
        private System.Windows.Forms.NumericUpDown borderWidthControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPickColorBorder;
        private System.Windows.Forms.ColorDialog colorBorderPicker;
        private System.Windows.Forms.Button btn_rectangular;
        private System.Windows.Forms.Label timeExecutedLabel;
        private System.Windows.Forms.CheckedListBox componentList;
        private System.Windows.Forms.Label componetListLabel;
        private System.Windows.Forms.Label executedTime;
    }
}

