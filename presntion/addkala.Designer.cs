
namespace Real_Estate_Agent_Dashboard
{
    partial class addkala
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcount = new Guna.UI.WinForms.GunaTextBox();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtpric = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgkala = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menukala = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کپیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.gunaGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkala)).BeginInit();
            this.menukala.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.BorderSize = 3;
            this.gunaGroupBox1.Controls.Add(this.circularProgress1);
            this.gunaGroupBox1.Controls.Add(this.groupBox1);
            this.gunaGroupBox1.Controls.Add(this.dgkala);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.LineTop = 45;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 25;
            this.gunaGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaGroupBox1.Size = new System.Drawing.Size(840, 680);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "ثبت کالا ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(750, 8);
            this.gunaGroupBox1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtcount);
            this.groupBox1.Controls.Add(this.guna2Button10);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Controls.Add(this.txtpric);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 230);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtcount
            // 
            this.txtcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcount.BackColor = System.Drawing.Color.Transparent;
            this.txtcount.BaseColor = System.Drawing.Color.White;
            this.txtcount.BorderColor = System.Drawing.Color.Blue;
            this.txtcount.BorderSize = 3;
            this.txtcount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcount.Font = new System.Drawing.Font("IRANSansWeb", 10.8F);
            this.txtcount.Location = new System.Drawing.Point(477, 168);
            this.txtcount.Name = "txtcount";
            this.txtcount.PasswordChar = '\0';
            this.txtcount.Radius = 2;
            this.txtcount.SelectedText = "";
            this.txtcount.Size = new System.Drawing.Size(304, 40);
            this.txtcount.TabIndex = 41;
            this.txtcount.TextChanged += new System.EventHandler(this.txtcount_TextChanged);
            this.txtcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTextBox2_KeyPress);
            // 
            // guna2Button10
            // 
            this.guna2Button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button10.Animated = true;
            this.guna2Button10.BorderRadius = 10;
            this.guna2Button10.CheckedState.Parent = this.guna2Button10;
            this.guna2Button10.CustomImages.Parent = this.guna2Button10;
            this.guna2Button10.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2Button10.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.Parent = this.guna2Button10;
            this.guna2Button10.Location = new System.Drawing.Point(40, 157);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.ShadowDecoration.Parent = this.guna2Button10;
            this.guna2Button10.Size = new System.Drawing.Size(317, 46);
            this.guna2Button10.TabIndex = 24;
            this.guna2Button10.Text = "ذخیره";
            this.guna2Button10.Click += new System.EventHandler(this.guna2Button10_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(723, 140);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 25);
            this.gunaLabel3.TabIndex = 40;
            this.gunaLabel3.Text = "تعداد :";
            // 
            // txtpric
            // 
            this.txtpric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpric.BackColor = System.Drawing.Color.Transparent;
            this.txtpric.BaseColor = System.Drawing.Color.White;
            this.txtpric.BorderColor = System.Drawing.Color.Blue;
            this.txtpric.BorderSize = 3;
            this.txtpric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpric.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpric.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpric.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpric.Font = new System.Drawing.Font("IRANSansWeb", 10.8F);
            this.txtpric.Location = new System.Drawing.Point(47, 68);
            this.txtpric.Name = "txtpric";
            this.txtpric.PasswordChar = '\0';
            this.txtpric.Radius = 2;
            this.txtpric.SelectedText = "";
            this.txtpric.Size = new System.Drawing.Size(304, 40);
            this.txtpric.TabIndex = 22;
            this.txtpric.TextChanged += new System.EventHandler(this.txtpric_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(260, 37);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 25);
            this.gunaLabel2.TabIndex = 39;
            this.gunaLabel2.Text = "قیمت کالا :";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.Blue;
            this.txtname.BorderSize = 3;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("IRANSansWeb", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(477, 68);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.Radius = 2;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(304, 40);
            this.txtname.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(712, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(74, 25);
            this.gunaLabel1.TabIndex = 38;
            this.gunaLabel1.Text = "نام کالا :";
            // 
            // dgkala
            // 
            this.dgkala.AllowUserToAddRows = false;
            this.dgkala.AllowUserToDeleteRows = false;
            this.dgkala.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgkala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgkala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgkala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgkala.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgkala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgkala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgkala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgkala.ContextMenuStrip = this.menukala;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgkala.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgkala.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgkala.EnableHeadersVisualStyles = false;
            this.dgkala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgkala.Location = new System.Drawing.Point(17, 279);
            this.dgkala.MultiSelect = false;
            this.dgkala.Name = "dgkala";
            this.dgkala.ReadOnly = true;
            this.dgkala.RowHeadersVisible = false;
            this.dgkala.RowHeadersWidth = 51;
            this.dgkala.RowTemplate.Height = 24;
            this.dgkala.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgkala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgkala.Size = new System.Drawing.Size(795, 378);
            this.dgkala.TabIndex = 36;
            this.dgkala.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgkala.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgkala.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgkala.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgkala.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgkala.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgkala.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgkala.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgkala.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgkala.ThemeStyle.HeaderStyle.Height = 46;
            this.dgkala.ThemeStyle.ReadOnly = true;
            this.dgkala.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgkala.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgkala.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgkala.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgkala.ThemeStyle.RowsStyle.Height = 24;
            this.dgkala.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgkala.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgkala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkala_CellClick);
            this.dgkala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkala_CellContentClick);
            this.dgkala.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkala_CellValueChanged);
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
            // menukala
            // 
            this.menukala.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menukala.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.کپیToolStripMenuItem});
            this.menukala.Name = "menukala";
            this.menukala.Size = new System.Drawing.Size(125, 76);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // کپیToolStripMenuItem
            // 
            this.کپیToolStripMenuItem.Name = "کپیToolStripMenuItem";
            this.کپیToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.کپیToolStripMenuItem.Text = "کپی";
            this.کپیToolStripMenuItem.Click += new System.EventHandler(this.کپیToolStripMenuItem_Click);
            // 
            // circularProgress1
            // 
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(367, 319);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgress1.Size = new System.Drawing.Size(117, 66);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 42;
            this.circularProgress1.Visible = false;
            // 
            // addkala
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "addkala";
            this.Size = new System.Drawing.Size(840, 680);
            this.Load += new System.EventHandler(this.addkala_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkala)).EndInit();
            this.menukala.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI.WinForms.GunaTextBox txtpric;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgkala;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaTextBox txtcount;
        private System.Windows.Forms.ContextMenuStrip menukala;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کپیToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}
