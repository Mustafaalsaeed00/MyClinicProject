namespace The_Clinic
{
    partial class AddPrescriptionfrm
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
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddFrequency = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddDosage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddMedicationName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddPrescription = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tpAddStartDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgAllPrescriptions = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddSpecialInstructions = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpAddEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPrescriptions)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // txtAddFrequency
            // 
            this.txtAddFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddFrequency.Location = new System.Drawing.Point(572, 274);
            this.txtAddFrequency.Multiline = true;
            this.txtAddFrequency.Name = "txtAddFrequency";
            this.txtAddFrequency.Size = new System.Drawing.Size(188, 30);
            this.txtAddFrequency.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAddFrequency.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddFrequency.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtAddFrequency.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFrequency.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddFrequency.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtAddFrequency.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtAddFrequency.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddFrequency.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAddFrequency.StateCommon.Border.Rounding = 20;
            this.txtAddFrequency.StateCommon.Border.Width = 1;
            this.txtAddFrequency.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFrequency.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAddFrequency.TabIndex = 2;
            this.txtAddFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddDosage
            // 
            this.txtAddDosage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddDosage.Location = new System.Drawing.Point(572, 202);
            this.txtAddDosage.Multiline = true;
            this.txtAddDosage.Name = "txtAddDosage";
            this.txtAddDosage.Size = new System.Drawing.Size(188, 30);
            this.txtAddDosage.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAddDosage.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddDosage.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtAddDosage.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDosage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddDosage.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtAddDosage.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtAddDosage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddDosage.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAddDosage.StateCommon.Border.Rounding = 20;
            this.txtAddDosage.StateCommon.Border.Width = 1;
            this.txtAddDosage.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDosage.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAddDosage.TabIndex = 1;
            this.txtAddDosage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddMedicationName
            // 
            this.txtAddMedicationName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddMedicationName.Location = new System.Drawing.Point(572, 143);
            this.txtAddMedicationName.Multiline = true;
            this.txtAddMedicationName.Name = "txtAddMedicationName";
            this.txtAddMedicationName.Size = new System.Drawing.Size(188, 30);
            this.txtAddMedicationName.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAddMedicationName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddMedicationName.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtAddMedicationName.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMedicationName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddMedicationName.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtAddMedicationName.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtAddMedicationName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddMedicationName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAddMedicationName.StateCommon.Border.Rounding = 20;
            this.txtAddMedicationName.StateCommon.Border.Width = 1;
            this.txtAddMedicationName.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMedicationName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAddMedicationName.TabIndex = 0;
            this.txtAddMedicationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1649, 127);
            this.pnlHeader.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label27.Location = new System.Drawing.Point(375, 154);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(147, 19);
            this.label27.TabIndex = 9;
            this.label27.Text = "Medication Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label10.Location = new System.Drawing.Point(375, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Frequency";
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Location = new System.Drawing.Point(607, 339);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAddPrescription.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAddPrescription.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddPrescription.Size = new System.Drawing.Size(124, 43);
            this.btnAddPrescription.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAddPrescription.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAddPrescription.StateCommon.Back.ColorAngle = 45F;
            this.btnAddPrescription.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddPrescription.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddPrescription.StateCommon.Border.ColorAngle = 45F;
            this.btnAddPrescription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddPrescription.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddPrescription.StateCommon.Border.Rounding = 20;
            this.btnAddPrescription.StateCommon.Border.Width = 1;
            this.btnAddPrescription.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddPrescription.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrescription.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddPrescription.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddPrescription.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddPrescription.StatePressed.Border.Width = 2;
            this.btnAddPrescription.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAddPrescription.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddPrescription.TabIndex = 6;
            this.btnAddPrescription.Values.Text = "Add Prescription";
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // tpAddStartDate
            // 
            this.tpAddStartDate.CalendarTodayDate = new System.DateTime(2023, 8, 8, 0, 0, 0, 0);
            this.tpAddStartDate.Location = new System.Drawing.Point(1009, 143);
            this.tpAddStartDate.Name = "tpAddStartDate";
            this.tpAddStartDate.Size = new System.Drawing.Size(188, 33);
            this.tpAddStartDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tpAddStartDate.StateCommon.Border.Rounding = 20;
            this.tpAddStartDate.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label28.Location = new System.Drawing.Point(827, 154);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 19);
            this.label28.TabIndex = 13;
            this.label28.Text = "Start Date";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label32.Location = new System.Drawing.Point(375, 219);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 19);
            this.label32.TabIndex = 11;
            this.label32.Text = "Dosage";
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
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgAllPrescriptions
            // 
            this.dgAllPrescriptions.AllowUserToAddRows = false;
            this.dgAllPrescriptions.AllowUserToDeleteRows = false;
            this.dgAllPrescriptions.AllowUserToResizeRows = false;
            this.dgAllPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllPrescriptions.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgAllPrescriptions.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgAllPrescriptions.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPrescriptions.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPrescriptions.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgAllPrescriptions.Location = new System.Drawing.Point(0, 388);
            this.dgAllPrescriptions.Name = "dgAllPrescriptions";
            this.dgAllPrescriptions.Size = new System.Drawing.Size(1649, 423);
            this.dgAllPrescriptions.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgAllPrescriptions.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgAllPrescriptions.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.MintCream;
            this.dgAllPrescriptions.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgAllPrescriptions.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPrescriptions.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgAllPrescriptions.StateCommon.HeaderColumn.Border.Rounding = 1;
            this.dgAllPrescriptions.StateCommon.HeaderColumn.Border.Width = 0;
            this.dgAllPrescriptions.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgAllPrescriptions.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.dgAllPrescriptions.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgAllPrescriptions.StateCommon.HeaderRow.Border.Rounding = 4;
            this.dgAllPrescriptions.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPrescriptions.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.dgAllPrescriptions.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgAllPrescriptions.StatePressed.HeaderRow.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.dgAllPrescriptions.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgAllPrescriptions.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.dgAllPrescriptions.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.Lime;
            this.dgAllPrescriptions.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.Lime;
            this.dgAllPrescriptions.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.BlueViolet;
            this.dgAllPrescriptions.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.BlueViolet;
            this.dgAllPrescriptions.StateTracking.HeaderRow.Back.Color1 = System.Drawing.Color.PaleGreen;
            this.dgAllPrescriptions.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.txtAddSpecialInstructions);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tpAddEndDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtAddFrequency);
            this.panel4.Controls.Add(this.txtAddDosage);
            this.panel4.Controls.Add(this.txtAddMedicationName);
            this.panel4.Controls.Add(this.pnlHeader);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnAddPrescription);
            this.panel4.Controls.Add(this.tpAddStartDate);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1649, 388);
            this.panel4.TabIndex = 67;
            // 
            // txtAddSpecialInstructions
            // 
            this.txtAddSpecialInstructions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddSpecialInstructions.Location = new System.Drawing.Point(1009, 274);
            this.txtAddSpecialInstructions.Multiline = true;
            this.txtAddSpecialInstructions.Name = "txtAddSpecialInstructions";
            this.txtAddSpecialInstructions.Size = new System.Drawing.Size(188, 76);
            this.txtAddSpecialInstructions.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAddSpecialInstructions.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddSpecialInstructions.StateActive.Content.Color1 = System.Drawing.Color.BlueViolet;
            this.txtAddSpecialInstructions.StateActive.Content.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSpecialInstructions.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddSpecialInstructions.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtAddSpecialInstructions.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtAddSpecialInstructions.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddSpecialInstructions.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAddSpecialInstructions.StateCommon.Border.Rounding = 20;
            this.txtAddSpecialInstructions.StateCommon.Border.Width = 1;
            this.txtAddSpecialInstructions.StateCommon.Content.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSpecialInstructions.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAddSpecialInstructions.TabIndex = 5;
            this.txtAddSpecialInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.Location = new System.Drawing.Point(827, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Special Instructions";
            // 
            // tpAddEndDate
            // 
            this.tpAddEndDate.CalendarTodayDate = new System.DateTime(2023, 8, 8, 0, 0, 0, 0);
            this.tpAddEndDate.Location = new System.Drawing.Point(1009, 213);
            this.tpAddEndDate.Name = "tpAddEndDate";
            this.tpAddEndDate.Size = new System.Drawing.Size(188, 33);
            this.tpAddEndDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tpAddEndDate.StateCommon.Border.Rounding = 20;
            this.tpAddEndDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.Location = new System.Drawing.Point(827, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "End Date";
            // 
            // AddPrescriptionfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 811);
            this.Controls.Add(this.dgAllPrescriptions);
            this.Controls.Add(this.panel4);
            this.MaximumSize = new System.Drawing.Size(1665, 850);
            this.MinimumSize = new System.Drawing.Size(1665, 850);
            this.Name = "AddPrescriptionfrm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "AddPrescriptionfrm";
            this.Load += new System.EventHandler(this.AddPrescriptionfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllPrescriptions)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddFrequency;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddDosage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddMedicationName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddPrescription;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker tpAddStartDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgAllPrescriptions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker tpAddEndDate;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddSpecialInstructions;
        private System.Windows.Forms.Label label2;
    }
}