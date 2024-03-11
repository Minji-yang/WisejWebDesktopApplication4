namespace WisejWebDesktopApplication4
{
    partial class Window1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.timer1 = new Wisej.Web.Timer(this.components);
            this.timer2 = new Wisej.Web.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(12, 80, 84);
            this.label1.Font = new System.Drawing.Font("Noto Sans KR ExtraBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@window");
            this.label1.Location = new System.Drawing.Point(92, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "소화기 내과";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(12, 80, 84);
            this.label2.Font = new System.Drawing.Font("Noto Sans KR ExtraBold", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@window");
            this.label2.Location = new System.Drawing.Point(165, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "김효진";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(12, 80, 84);
            this.label3.Font = new System.Drawing.Font("Noto Sans KR ExtraBold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromName("@window");
            this.label3.Location = new System.Drawing.Point(69, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "담당의";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            this.label4.Font = new System.Drawing.Font("Noto Sans KR ExtraBold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(6, 40, 86);
            this.label4.Location = new System.Drawing.Point(121, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "김효진";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackgroundImage = global::WisejWebDesktopApplication4.Properties.Resources.Frame_7__1_;
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize;
            this.ClientSize = new System.Drawing.Size(849, 1340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Window1";
            this.RightToLeft = Wisej.Web.RightToLeft.No;
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.Paint += new Wisej.Web.PaintEventHandler(this.Window1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Timer timer1;
        private Wisej.Web.Timer timer2;
    }
}