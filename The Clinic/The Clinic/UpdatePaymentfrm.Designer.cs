namespace The_Clinic
{
    partial class UpdatePaymentfrm
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
            this.components = new System.ComponentModel.Container();
            this.dgAllPayments = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.cbFind = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtFind = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnUpdatePaymentbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbMethod = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtUpdatePaymentNotes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdatePaymentAmountPaid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFind)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllPayments
            // 
            this.dgAllPayments.AllowUserToAddRows = false;
            this.dgAllPayments.AllowUserToDeleteRows = false;
            this.dgAllPayments.AllowUserToResizeRows = false;
            this.dgAllPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllPayments.Location = new System.Drawing.Point(0, 336);
            this.dgAllPayments.Name = "dgAllPayments";
            this.dgAllPayments.Size = new System.Drawing.Size(1649, 475);
            this.dgAllPayments.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgAllPayments.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgAllPayments.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.MintCream;
            this.dgAllPayments.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.dgAllPayments.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPayments.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgAllPayments.StateCommon.HeaderColumn.Border.Rounding = 1;
            this.dgAllPayments.StateCommon.HeaderColumn.Border.Width = 0;
            this.dgAllPayments.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgAllPayments.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.dgAllPayments.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgAllPayments.StateCommon.HeaderRow.Border.Rounding = 4;
            this.dgAllPayments.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPayments.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.dgAllPayments.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPayments.StatePressed.HeaderRow.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.dgAllPayments.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgAllPayments.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.dgAllPayments.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.Lime;
            this.dgAllPayments.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.Lime;
            this.dgAllPayments.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.dgAllPayments.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.dgAllPayments.StateTracking.HeaderRow.Back.Color1 = System.Drawing.Color.PaleGreen;
            this.dgAllPayments.TabIndex = 69;
            this.dgAllPayments.SelectionChanged += new System.EventHandler(this.dgAllPayments_SelectionChanged);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Image = global::The_Clinic.Properties.Resources.LogoClinic;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1649, 67);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 1;
            this.pbHeader.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 55);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(1649, 72);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "The Clinic";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pbHeader);
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1649, 127);
            this.panel2.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1649, 127);
            this.pnlHeader.TabIndex = 61;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::The_Clinic.Properties.Resources.pill__1_;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::The_Clinic.Properties.Resources.pill__1_;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::The_Clinic.Properties.Resources.pill__1_;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::The_Clinic.Properties.Resources.herbal_treatment__1_;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::The_Clinic.Properties.Resources.herbal_treatment__1_;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::The_Clinic.Properties.Resources.herbal_treatment__1_;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::The_Clinic.Properties.Resources.capsule__1_;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // cbFind
            // 
            this.cbFind.DropDownWidth = 103;
            this.cbFind.Location = new System.Drawing.Point(1412, 147);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(109, 27);
            this.cbFind.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Thistle;
            this.cbFind.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Blue;
            this.cbFind.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbFind.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFind.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbFind.StateCommon.ComboBox.Border.Width = 1;
            this.cbFind.TabIndex = 4;
            this.cbFind.Text = "Search By";
            this.cbFind.TextChanged += new System.EventHandler(this.cbFind_TextChanged);
            // 
            // txtFind
            // 
            this.txtFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFind.Location = new System.Drawing.Point(1017, 139);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(365, 35);
            this.txtFind.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtFind.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFind.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtFind.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.txtFind.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtFind.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtFind.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFind.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFind.StateCommon.Border.Rounding = 20;
            this.txtFind.StateCommon.Border.Width = 1;
            this.txtFind.StateCommon.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F);
            this.txtFind.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFind.TabIndex = 5;
            this.txtFind.Text = "User Name";
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // btnUpdatePaymentbtn
            // 
            this.btnUpdatePaymentbtn.Location = new System.Drawing.Point(515, 287);
            this.btnUpdatePaymentbtn.Name = "btnUpdatePaymentbtn";
            this.btnUpdatePaymentbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnUpdatePaymentbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnUpdatePaymentbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUpdatePaymentbtn.Size = new System.Drawing.Size(124, 43);
            this.btnUpdatePaymentbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnUpdatePaymentbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnUpdatePaymentbtn.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdatePaymentbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdatePaymentbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdatePaymentbtn.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdatePaymentbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePaymentbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdatePaymentbtn.StateCommon.Border.Rounding = 20;
            this.btnUpdatePaymentbtn.StateCommon.Border.Width = 1;
            this.btnUpdatePaymentbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdatePaymentbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePaymentbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdatePaymentbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdatePaymentbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePaymentbtn.StatePressed.Border.Width = 2;
            this.btnUpdatePaymentbtn.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdatePaymentbtn.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdatePaymentbtn.TabIndex = 3;
            this.btnUpdatePaymentbtn.Values.Text = "Update Payment";
            this.btnUpdatePaymentbtn.Click += new System.EventHandler(this.btnUpdatePaymenttbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cbMethod);
            this.panel1.Controls.Add(this.txtUpdatePaymentNotes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUpdatePaymentAmountPaid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlHeader);
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnUpdatePaymentbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1649, 336);
            this.panel1.TabIndex = 68;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblDate.Location = new System.Drawing.Point(336, 147);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 19);
            this.lblDate.TabIndex = 74;
            this.lblDate.Text = "Date";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownWidth = 176;
            this.cbMethod.Location = new System.Drawing.Point(331, 204);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Palette = this.kryptonPalette1;
            this.cbMethod.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.cbMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMethod.Size = new System.Drawing.Size(188, 30);
            this.cbMethod.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbMethod.StateActive.ComboBox.Border.Rounding = 20;
            this.cbMethod.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F);
            this.cbMethod.TabIndex = 0;
            this.cbMethod.Text = "Select Method";
            // 
            // txtUpdatePaymentNotes
            // 
            this.txtUpdatePaymentNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUpdatePaymentNotes.Location = new System.Drawing.Point(784, 204);
            this.txtUpdatePaymentNotes.Multiline = true;
            this.txtUpdatePaymentNotes.Name = "txtUpdatePaymentNotes";
            this.txtUpdatePaymentNotes.Size = new System.Drawing.Size(188, 82);
            this.txtUpdatePaymentNotes.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtUpdatePaymentNotes.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUpdatePaymentNotes.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtUpdatePaymentNotes.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePaymentNotes.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtUpdatePaymentNotes.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtUpdatePaymentNotes.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtUpdatePaymentNotes.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUpdatePaymentNotes.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUpdatePaymentNotes.StateCommon.Border.Rounding = 20;
            this.txtUpdatePaymentNotes.StateCommon.Border.Width = 1;
            this.txtUpdatePaymentNotes.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePaymentNotes.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUpdatePaymentNotes.TabIndex = 2;
            this.txtUpdatePaymentNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.Location = new System.Drawing.Point(212, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label5.Location = new System.Drawing.Point(627, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.Location = new System.Drawing.Point(212, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Method";
            // 
            // txtUpdatePaymentAmountPaid
            // 
            this.txtUpdatePaymentAmountPaid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUpdatePaymentAmountPaid.Location = new System.Drawing.Point(784, 147);
            this.txtUpdatePaymentAmountPaid.Multiline = true;
            this.txtUpdatePaymentAmountPaid.Name = "txtUpdatePaymentAmountPaid";
            this.txtUpdatePaymentAmountPaid.Size = new System.Drawing.Size(188, 30);
            this.txtUpdatePaymentAmountPaid.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtUpdatePaymentAmountPaid.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUpdatePaymentAmountPaid.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtUpdatePaymentAmountPaid.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePaymentAmountPaid.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.Rounding = 20;
            this.txtUpdatePaymentAmountPaid.StateCommon.Border.Width = 1;
            this.txtUpdatePaymentAmountPaid.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePaymentAmountPaid.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUpdatePaymentAmountPaid.TabIndex = 1;
            this.txtUpdatePaymentAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.Location = new System.Drawing.Point(627, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "Amount Paid";
            // 
            // UpdatePaymentfrm
            // 
            this.AcceptButton = this.btnUpdatePaymentbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 811);
            this.Controls.Add(this.dgAllPayments);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1665, 850);
            this.MinimumSize = new System.Drawing.Size(1665, 850);
            this.Name = "UpdatePaymentfrm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "UpdatePaymentfrm";
            this.Load += new System.EventHandler(this.UpdatePaymentfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFind)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgAllPayments;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbFind;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFind;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdatePaymentbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUpdatePaymentNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUpdatePaymentAmountPaid;
        private System.Windows.Forms.Label label4;
    }
}