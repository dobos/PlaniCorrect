namespace Elte.PlaniCorrect.UI.Controls
{
    partial class RayParameters
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
            this.label1 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthUp = new System.Windows.Forms.Button();
            this.widthDown = new System.Windows.Forms.Button();
            this.radiusUp = new System.Windows.Forms.Button();
            this.radiusDown = new System.Windows.Forms.Button();
            this.width2Up = new System.Windows.Forms.Button();
            this.width2Down = new System.Windows.Forms.Button();
            this.angleUp = new System.Windows.Forms.Button();
            this.angleDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius:";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(97, 4);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(50, 20);
            this.radius.TabIndex = 1;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(97, 108);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(50, 20);
            this.width.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // widthUp
            // 
            this.widthUp.Location = new System.Drawing.Point(84, 156);
            this.widthUp.Name = "widthUp";
            this.widthUp.Size = new System.Drawing.Size(23, 23);
            this.widthUp.TabIndex = 7;
            this.widthUp.Tag = Elte.PlaniCorrect.UI.Commands.WidthUp;
            this.widthUp.Text = "+";
            this.widthUp.UseVisualStyleBackColor = true;
            this.widthUp.Click += new System.EventHandler(this.OnClick);
            // 
            // widthDown
            // 
            this.widthDown.Location = new System.Drawing.Point(43, 156);
            this.widthDown.Name = "widthDown";
            this.widthDown.Size = new System.Drawing.Size(23, 23);
            this.widthDown.TabIndex = 6;
            this.widthDown.Tag = Elte.PlaniCorrect.UI.Commands.WidthDown;
            this.widthDown.Text = "-";
            this.widthDown.UseVisualStyleBackColor = true;
            this.widthDown.Click += new System.EventHandler(this.OnClick);
            // 
            // radiusUp
            // 
            this.radiusUp.Location = new System.Drawing.Point(84, 30);
            this.radiusUp.Name = "radiusUp";
            this.radiusUp.Size = new System.Drawing.Size(23, 23);
            this.radiusUp.TabIndex = 5;
            this.radiusUp.Tag = Elte.PlaniCorrect.UI.Commands.RadiusUp;
            this.radiusUp.Text = "+";
            this.radiusUp.UseVisualStyleBackColor = true;
            this.radiusUp.Click += new System.EventHandler(this.OnClick);
            // 
            // radiusDown
            // 
            this.radiusDown.Location = new System.Drawing.Point(43, 30);
            this.radiusDown.Name = "radiusDown";
            this.radiusDown.Size = new System.Drawing.Size(23, 23);
            this.radiusDown.TabIndex = 4;
            this.radiusDown.Tag = Elte.PlaniCorrect.UI.Commands.RadiusDown;
            this.radiusDown.Text = "-";
            this.radiusDown.UseVisualStyleBackColor = true;
            this.radiusDown.Click += new System.EventHandler(this.OnClick);
            // 
            // width2Up
            // 
            this.width2Up.Location = new System.Drawing.Point(84, 185);
            this.width2Up.Name = "width2Up";
            this.width2Up.Size = new System.Drawing.Size(23, 23);
            this.width2Up.TabIndex = 9;
            this.width2Up.Tag = Elte.PlaniCorrect.UI.Commands.Width2Up;
            this.width2Up.Text = "+";
            this.width2Up.UseVisualStyleBackColor = true;
            this.width2Up.Click += new System.EventHandler(this.OnClick);
            // 
            // width2Down
            // 
            this.width2Down.Location = new System.Drawing.Point(43, 185);
            this.width2Down.Name = "width2Down";
            this.width2Down.Size = new System.Drawing.Size(23, 23);
            this.width2Down.TabIndex = 8;
            this.width2Down.Tag = Elte.PlaniCorrect.UI.Commands.Width2Down;
            this.width2Down.Text = "-";
            this.width2Down.UseVisualStyleBackColor = true;
            this.width2Down.Click += new System.EventHandler(this.OnClick);
            // 
            // angleUp
            // 
            this.angleUp.Location = new System.Drawing.Point(84, 79);
            this.angleUp.Name = "angleUp";
            this.angleUp.Size = new System.Drawing.Size(23, 23);
            this.angleUp.TabIndex = 12;
            this.angleUp.Tag = Elte.PlaniCorrect.UI.Commands.AngleUp;
            this.angleUp.Text = "+";
            this.angleUp.UseVisualStyleBackColor = true;
            this.angleUp.Click += new System.EventHandler(this.OnClick);
            // 
            // angleDown
            // 
            this.angleDown.Location = new System.Drawing.Point(43, 79);
            this.angleDown.Name = "angleDown";
            this.angleDown.Size = new System.Drawing.Size(23, 23);
            this.angleDown.TabIndex = 11;
            this.angleDown.Tag = Elte.PlaniCorrect.UI.Commands.AngleDown;
            this.angleDown.Text = "-";
            this.angleDown.UseVisualStyleBackColor = true;
            this.angleDown.Click += new System.EventHandler(this.OnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Angle:";
            // 
            // RayParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.angleUp);
            this.Controls.Add(this.angleDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.width2Up);
            this.Controls.Add(this.width2Down);
            this.Controls.Add(this.widthUp);
            this.Controls.Add(this.widthDown);
            this.Controls.Add(this.radiusUp);
            this.Controls.Add(this.radiusDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.width);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.label1);
            this.Name = "RayParameters";
            this.Size = new System.Drawing.Size(150, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button radiusDown;
        private System.Windows.Forms.Button radiusUp;
        private System.Windows.Forms.Button widthUp;
        private System.Windows.Forms.Button widthDown;
        private System.Windows.Forms.Button width2Up;
        private System.Windows.Forms.Button width2Down;
        private System.Windows.Forms.Button angleUp;
        private System.Windows.Forms.Button angleDown;
        private System.Windows.Forms.Label label3;
    }
}
