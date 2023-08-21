namespace The_Clinic
{
    partial class AllPaymentsfrm
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFind = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtFind = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDeletePayment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPayments)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFind)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
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
            this.dgAllPayments.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgAllPayments.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgAllPayments.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPayments.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPayments.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPayments.Location = new System.Drawing.Point(0, 197);
            this.dgAllPayments.Name = "dgAllPayments";
            this.dgAllPayments.Size = new System.Drawing.Size(1649, 614);
            this.dgAllPayments.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgAllPayments.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
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
            this.dgAllPayments.TabIndex = 68;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnDeletePayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1649, 70);
            this.panel1.TabIndex = 67;
            // 
            // cbFind
            // 
            this.cbFind.DropDownWidth = 103;
            this.cbFind.Location = new System.Drawing.Point(1076, 30);
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
            this.cbFind.TabIndex = 0;
            this.cbFind.Text = "Search By";
            this.cbFind.TextChanged += new System.EventHandler(this.cbFind_TextChanged);
            // 
            // txtFind
            // 
            this.txtFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFind.Location = new System.Drawing.Point(681, 22);
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
            this.txtFind.StateCommon.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFind.TabIndex = 1;
            this.txtFind.Text = "User Name";
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(283, 14);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnDeletePayment.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeletePayment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDeletePayment.Size = new System.Drawing.Size(124, 43);
            this.btnDeletePayment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePayment.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePayment.StateCommon.Back.ColorAngle = 45F;
            this.btnDeletePayment.StateCommon.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btnDeletePayment.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletePayment.StateCommon.Border.ColorAngle = 45F;
            this.btnDeletePayment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeletePayment.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeletePayment.StateCommon.Border.Rounding = 20;
            this.btnDeletePayment.StateCommon.Border.Width = 1;
            this.btnDeletePayment.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeletePayment.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeletePayment.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btnDeletePayment.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btnDeletePayment.StateNormal.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnDeletePayment.StateNormal.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.btnDeletePayment.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDeletePayment.StatePressed.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDeletePayment.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeletePayment.StatePressed.Border.Width = 2;
            this.btnDeletePayment.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeletePayment.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnDeletePayment.TabIndex = 2;
            this.btnDeletePayment.Values.Text = "Delete";
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1649, 127);
            this.pnlHeader.TabIndex = 66;
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
            // AllPaymentsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 811);
            this.Controls.Add(this.dgAllPayments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(1665, 850);
            this.MinimumSize = new System.Drawing.Size(1665, 850);
            this.Name = "AllPaymentsfrm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "AllPayments";
            this.Load += new System.EventHandler(this.AllPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPayments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFind)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgAllPayments;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbFind;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFind;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeletePayment;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Label lblHeader;
    }
}