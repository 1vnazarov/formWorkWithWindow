﻿namespace _15092023_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_leftBottom = new System.Windows.Forms.Button();
            this.btn_rightBottom = new System.Windows.Forms.Button();
            this.btn_rightTop = new System.Windows.Forms.Button();
            this.btn_leftTop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btn_center);
            this.groupBox1.Controls.Add(this.btn_leftBottom);
            this.groupBox1.Controls.Add(this.btn_rightBottom);
            this.groupBox1.Controls.Add(this.btn_rightTop);
            this.groupBox1.Controls.Add(this.btn_leftTop);
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_center
            // 
            this.btn_center.Image = ((System.Drawing.Image)(resources.GetObject("btn_center.Image")));
            this.btn_center.Location = new System.Drawing.Point(121, 62);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(83, 78);
            this.btn_center.TabIndex = 4;
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_leftBottom
            // 
            this.btn_leftBottom.Image = ((System.Drawing.Image)(resources.GetObject("btn_leftBottom.Image")));
            this.btn_leftBottom.Location = new System.Drawing.Point(2, 123);
            this.btn_leftBottom.Name = "btn_leftBottom";
            this.btn_leftBottom.Size = new System.Drawing.Size(83, 78);
            this.btn_leftBottom.TabIndex = 3;
            this.btn_leftBottom.UseVisualStyleBackColor = true;
            this.btn_leftBottom.Click += new System.EventHandler(this.btn_leftBottom_Click);
            // 
            // btn_rightBottom
            // 
            this.btn_rightBottom.Image = ((System.Drawing.Image)(resources.GetObject("btn_rightBottom.Image")));
            this.btn_rightBottom.Location = new System.Drawing.Point(240, 124);
            this.btn_rightBottom.Name = "btn_rightBottom";
            this.btn_rightBottom.Size = new System.Drawing.Size(83, 78);
            this.btn_rightBottom.TabIndex = 2;
            this.btn_rightBottom.UseVisualStyleBackColor = true;
            this.btn_rightBottom.Click += new System.EventHandler(this.btn_rightBottom_Click);
            // 
            // btn_rightTop
            // 
            this.btn_rightTop.Image = ((System.Drawing.Image)(resources.GetObject("btn_rightTop.Image")));
            this.btn_rightTop.Location = new System.Drawing.Point(238, 12);
            this.btn_rightTop.Name = "btn_rightTop";
            this.btn_rightTop.Size = new System.Drawing.Size(83, 78);
            this.btn_rightTop.TabIndex = 1;
            this.btn_rightTop.UseVisualStyleBackColor = true;
            this.btn_rightTop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_leftTop
            // 
            this.btn_leftTop.Image = ((System.Drawing.Image)(resources.GetObject("btn_leftTop.Image")));
            this.btn_leftTop.Location = new System.Drawing.Point(3, 13);
            this.btn_leftTop.Name = "btn_leftTop";
            this.btn_leftTop.Size = new System.Drawing.Size(83, 78);
            this.btn_leftTop.TabIndex = 0;
            this.btn_leftTop.UseVisualStyleBackColor = true;
            this.btn_leftTop.Click += new System.EventHandler(this.btn_leftTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_rightTop;
        private Button btn_leftTop;
        private Button btn_center;
        private Button btn_leftBottom;
        private Button btn_rightBottom;
    }
}