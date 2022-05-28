
namespace pr
{
    partial class bakup_restor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakup_restor));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(207, 91);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(418, 382);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // guna2Button15
            // 
            this.guna2Button15.Animated = true;
            this.guna2Button15.BorderRadius = 10;
            this.guna2Button15.CheckedState.Parent = this.guna2Button15;
            this.guna2Button15.CustomImages.Parent = this.guna2Button15;
            this.guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(210)))));
            this.guna2Button15.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.HoverState.Parent = this.guna2Button15;
            this.guna2Button15.Location = new System.Drawing.Point(207, 496);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.ShadowDecoration.Parent = this.guna2Button15;
            this.guna2Button15.Size = new System.Drawing.Size(418, 56);
            this.guna2Button15.TabIndex = 7;
            this.guna2Button15.Text = "تهیه نسخه پشتیبانی";
            this.guna2Button15.Click += new System.EventHandler(this.guna2Button15_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(210)))));
            this.guna2Button1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(207, 558);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(418, 56);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "بازیابی نسخه های پشتیبان ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // circularProgress1
            // 
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(347, 620);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgress1.Size = new System.Drawing.Size(129, 60);
            this.circularProgress1.SpokeBorderLight = System.Drawing.Color.Linen;
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 9;
            this.circularProgress1.Visible = false;
            // 
            // bakup_restor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button15);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "bakup_restor";
            this.Size = new System.Drawing.Size(837, 680);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}
