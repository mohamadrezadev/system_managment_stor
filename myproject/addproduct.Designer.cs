
namespace myproject
{
    partial class addproduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.dgkala = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txttedad = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtprice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtname = new Guna.UI.WinForms.GunaLineTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.groupBox1.Controls.Add(this.dgkala);
            this.groupBox1.Controls.Add(this.gunaButton4);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Controls.Add(this.txttedad);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1253, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت کالا ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(618, 274);
            this.gunaWinCircleProgressIndicator1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.FloralWhite;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(64, 64);
            this.gunaWinCircleProgressIndicator1.TabIndex = 36;
            this.gunaWinCircleProgressIndicator1.Visible = false;
            // 
            // dgkala
            // 
            this.dgkala.AllowUserToAddRows = false;
            this.dgkala.AllowUserToDeleteRows = false;
            this.dgkala.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgkala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgkala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgkala.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgkala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgkala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgkala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgkala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgkala.ColumnHeadersHeight = 46;
            this.dgkala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgkala.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgkala.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgkala.EnableHeadersVisualStyles = false;
            this.dgkala.GridColor = System.Drawing.Color.SeaShell;
            this.dgkala.Location = new System.Drawing.Point(74, 274);
            this.dgkala.MultiSelect = false;
            this.dgkala.Name = "dgkala";
            this.dgkala.ReadOnly = true;
            this.dgkala.RowHeadersVisible = false;
            this.dgkala.RowHeadersWidth = 51;
            this.dgkala.RowTemplate.Height = 24;
            this.dgkala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgkala.Size = new System.Drawing.Size(407, 326);
            this.dgkala.TabIndex = 35;
            this.dgkala.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgkala.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.dgkala.ThemeStyle.GridColor = System.Drawing.Color.SeaShell;
            this.dgkala.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgkala.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgkala.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansWeb Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgkala.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgkala.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgkala.ThemeStyle.HeaderStyle.Height = 46;
            this.dgkala.ThemeStyle.ReadOnly = true;
            this.dgkala.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgkala.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgkala.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansWeb Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgkala.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgkala.ThemeStyle.RowsStyle.Height = 24;
            this.dgkala.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgkala.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgkala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkala_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ردیف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام کالا ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "قیمت کالا ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "تعداد موجودی ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaButton4.BaseColor = System.Drawing.Color.LightGreen;
            this.gunaButton4.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderSize = 2;
            this.gunaButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Transparent;
            this.gunaButton4.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(16, 212);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaButton4.Padding = new System.Windows.Forms.Padding(2);
            this.gunaButton4.Size = new System.Drawing.Size(272, 41);
            this.gunaButton4.TabIndex = 34;
            this.gunaButton4.Text = "ثبت اطلاعات ";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(350, 92);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 25);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "تعداد :";
            // 
            // txttedad
            // 
            this.txttedad.BaseColor = System.Drawing.Color.White;
            this.txttedad.BorderColor = System.Drawing.Color.Silver;
            this.txttedad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttedad.ButtonForeColor = System.Drawing.Color.White;
            this.txttedad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttedad.ForeColor = System.Drawing.Color.Black;
            this.txttedad.Location = new System.Drawing.Point(111, 130);
            this.txttedad.Maximum = ((long)(9999999));
            this.txttedad.Minimum = ((long)(0));
            this.txttedad.Name = "txttedad";
            this.txttedad.Size = new System.Drawing.Size(297, 30);
            this.txttedad.TabIndex = 32;
            this.txttedad.Text = "gunaNumeric1";
            this.txttedad.Value = ((long)(0));
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(728, 92);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 25);
            this.gunaLabel2.TabIndex = 31;
            this.gunaLabel2.Text = "قیمت کالا :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1173, 92);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(74, 25);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = "نام کالا :";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtprice.Location = new System.Drawing.Point(522, 130);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.SelectedText = "";
            this.txtprice.ShortcutsEnabled = false;
            this.txtprice.Size = new System.Drawing.Size(297, 34);
            this.txtprice.TabIndex = 29;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.LineColor = System.Drawing.Color.Gainsboro;
            this.txtname.Location = new System.Drawing.Point(945, 130);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.ShortcutsEnabled = false;
            this.txtname.Size = new System.Drawing.Size(297, 34);
            this.txtname.TabIndex = 28;
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "addproduct";
            this.Size = new System.Drawing.Size(1253, 640);
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtprice;
        private Guna.UI.WinForms.GunaLineTextBox txtname;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaNumeric txttedad;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI2.WinForms.Guna2DataGridView dgkala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
    }
}
