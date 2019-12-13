namespace TietokoneWindowsForms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.labelCPUID = new System.Windows.Forms.Label();
            this.labelNoEditCPUID = new System.Windows.Forms.Label();
            this.labelCPUThreads = new System.Windows.Forms.Label();
            this.labelCPUCores = new System.Windows.Forms.Label();
            this.labelNoEditCPUThreads = new System.Windows.Forms.Label();
            this.labelNoEditCPUCores = new System.Windows.Forms.Label();
            this.labelCPUClockSpeed = new System.Windows.Forms.Label();
            this.labelNoEditCPUClockSpeed = new System.Windows.Forms.Label();
            this.labelCPUModel = new System.Windows.Forms.Label();
            this.labelCPUBrand = new System.Windows.Forms.Label();
            this.comboBoxCPUModel = new System.Windows.Forms.ComboBox();
            this.comboBoxCPUBrand = new System.Windows.Forms.ComboBox();
            this.groupBoxGPU = new System.Windows.Forms.GroupBox();
            this.labelGPUID = new System.Windows.Forms.Label();
            this.labelNoEditGPUID = new System.Windows.Forms.Label();
            this.comboBoxGPU = new System.Windows.Forms.ComboBox();
            this.labelNoEditGPU = new System.Windows.Forms.Label();
            this.comboBoxGPUSeries = new System.Windows.Forms.ComboBox();
            this.labelNoEditGPUSeries = new System.Windows.Forms.Label();
            this.groupBoxRAM = new System.Windows.Forms.GroupBox();
            this.labelGB = new System.Windows.Forms.Label();
            this.textBoxRAMAmount = new System.Windows.Forms.TextBox();
            this.labelNoEditRAMAmount = new System.Windows.Forms.Label();
            this.labelRAMID = new System.Windows.Forms.Label();
            this.comboBoxRAMBrand = new System.Windows.Forms.ComboBox();
            this.labelNoEditRAMID = new System.Windows.Forms.Label();
            this.labelNoEditRAMBrand = new System.Windows.Forms.Label();
            this.labelNoEditRAMModel = new System.Windows.Forms.Label();
            this.comboBoxRAMModel = new System.Windows.Forms.ComboBox();
            this.groupBoxCASE = new System.Windows.Forms.GroupBox();
            this.labelCaseID = new System.Windows.Forms.Label();
            this.comboBoxCaseBrand = new System.Windows.Forms.ComboBox();
            this.labelNoEditCaseID = new System.Windows.Forms.Label();
            this.labelNoEditCaseBrand = new System.Windows.Forms.Label();
            this.labelNoEditCaseModel = new System.Windows.Forms.Label();
            this.comboBoxCaseModel = new System.Windows.Forms.ComboBox();
            this.groupBoxMOBO = new System.Windows.Forms.GroupBox();
            this.labelMOBOID = new System.Windows.Forms.Label();
            this.labelNoEditMOBOID = new System.Windows.Forms.Label();
            this.labelMOBONoEditModel = new System.Windows.Forms.Label();
            this.comboBoxMOBOModel = new System.Windows.Forms.ComboBox();
            this.labelNoEditMOBOBrand = new System.Windows.Forms.Label();
            this.comboBoxMOBOBrand = new System.Windows.Forms.ComboBox();
            this.groupBoxPSU = new System.Windows.Forms.GroupBox();
            this.comboBoxPSUModel = new System.Windows.Forms.ComboBox();
            this.labelNoEditPSUPower = new System.Windows.Forms.Label();
            this.labelNoEditPSUModel = new System.Windows.Forms.Label();
            this.labelPSUID = new System.Windows.Forms.Label();
            this.labelNoEditPSUBrand = new System.Windows.Forms.Label();
            this.comboBoxPSUBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSaveAsNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.labelNoEditComputerID = new System.Windows.Forms.Label();
            this.labelComputerID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPSUPower = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCPU.SuspendLayout();
            this.groupBoxGPU.SuspendLayout();
            this.groupBoxRAM.SuspendLayout();
            this.groupBoxCASE.SuspendLayout();
            this.groupBoxMOBO.SuspendLayout();
            this.groupBoxPSU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.Controls.Add(this.labelCPUID);
            this.groupBoxCPU.Controls.Add(this.labelNoEditCPUID);
            this.groupBoxCPU.Controls.Add(this.labelCPUThreads);
            this.groupBoxCPU.Controls.Add(this.labelCPUCores);
            this.groupBoxCPU.Controls.Add(this.labelNoEditCPUThreads);
            this.groupBoxCPU.Controls.Add(this.labelNoEditCPUCores);
            this.groupBoxCPU.Controls.Add(this.labelCPUClockSpeed);
            this.groupBoxCPU.Controls.Add(this.labelNoEditCPUClockSpeed);
            this.groupBoxCPU.Controls.Add(this.labelCPUModel);
            this.groupBoxCPU.Controls.Add(this.labelCPUBrand);
            this.groupBoxCPU.Controls.Add(this.comboBoxCPUModel);
            this.groupBoxCPU.Controls.Add(this.comboBoxCPUBrand);
            this.groupBoxCPU.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(200, 198);
            this.groupBoxCPU.TabIndex = 1;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // labelCPUID
            // 
            this.labelCPUID.AutoSize = true;
            this.labelCPUID.Location = new System.Drawing.Point(80, 161);
            this.labelCPUID.Name = "labelCPUID";
            this.labelCPUID.Size = new System.Drawing.Size(62, 13);
            this.labelCPUID.TabIndex = 11;
            this.labelCPUID.Text = "labelCPUID";
            // 
            // labelNoEditCPUID
            // 
            this.labelNoEditCPUID.AutoSize = true;
            this.labelNoEditCPUID.Location = new System.Drawing.Point(6, 161);
            this.labelNoEditCPUID.Name = "labelNoEditCPUID";
            this.labelNoEditCPUID.Size = new System.Drawing.Size(21, 13);
            this.labelNoEditCPUID.TabIndex = 10;
            this.labelNoEditCPUID.Text = "ID:";
            // 
            // labelCPUThreads
            // 
            this.labelCPUThreads.AutoSize = true;
            this.labelCPUThreads.Location = new System.Drawing.Point(80, 106);
            this.labelCPUThreads.Name = "labelCPUThreads";
            this.labelCPUThreads.Size = new System.Drawing.Size(90, 13);
            this.labelCPUThreads.TabIndex = 9;
            this.labelCPUThreads.Text = "labelCPUThreads";
            // 
            // labelCPUCores
            // 
            this.labelCPUCores.AutoSize = true;
            this.labelCPUCores.Location = new System.Drawing.Point(80, 78);
            this.labelCPUCores.Name = "labelCPUCores";
            this.labelCPUCores.Size = new System.Drawing.Size(78, 13);
            this.labelCPUCores.TabIndex = 8;
            this.labelCPUCores.Text = "labelCPUCores";
            // 
            // labelNoEditCPUThreads
            // 
            this.labelNoEditCPUThreads.AutoSize = true;
            this.labelNoEditCPUThreads.Location = new System.Drawing.Point(6, 106);
            this.labelNoEditCPUThreads.Name = "labelNoEditCPUThreads";
            this.labelNoEditCPUThreads.Size = new System.Drawing.Size(49, 13);
            this.labelNoEditCPUThreads.TabIndex = 7;
            this.labelNoEditCPUThreads.Text = "Threads:";
            // 
            // labelNoEditCPUCores
            // 
            this.labelNoEditCPUCores.AutoSize = true;
            this.labelNoEditCPUCores.Location = new System.Drawing.Point(6, 78);
            this.labelNoEditCPUCores.Name = "labelNoEditCPUCores";
            this.labelNoEditCPUCores.Size = new System.Drawing.Size(37, 13);
            this.labelNoEditCPUCores.TabIndex = 6;
            this.labelNoEditCPUCores.Text = "Cores:";
            // 
            // labelCPUClockSpeed
            // 
            this.labelCPUClockSpeed.AutoSize = true;
            this.labelCPUClockSpeed.Location = new System.Drawing.Point(80, 134);
            this.labelCPUClockSpeed.Name = "labelCPUClockSpeed";
            this.labelCPUClockSpeed.Size = new System.Drawing.Size(109, 13);
            this.labelCPUClockSpeed.TabIndex = 5;
            this.labelCPUClockSpeed.Text = "labelCPUClockSpeed";
            // 
            // labelNoEditCPUClockSpeed
            // 
            this.labelNoEditCPUClockSpeed.AutoSize = true;
            this.labelNoEditCPUClockSpeed.Location = new System.Drawing.Point(6, 134);
            this.labelNoEditCPUClockSpeed.Name = "labelNoEditCPUClockSpeed";
            this.labelNoEditCPUClockSpeed.Size = new System.Drawing.Size(68, 13);
            this.labelNoEditCPUClockSpeed.TabIndex = 4;
            this.labelNoEditCPUClockSpeed.Text = "ClockSpeed:";
            // 
            // labelCPUModel
            // 
            this.labelCPUModel.AutoSize = true;
            this.labelCPUModel.Location = new System.Drawing.Point(6, 50);
            this.labelCPUModel.Name = "labelCPUModel";
            this.labelCPUModel.Size = new System.Drawing.Size(39, 13);
            this.labelCPUModel.TabIndex = 3;
            this.labelCPUModel.Text = "Model:";
            // 
            // labelCPUBrand
            // 
            this.labelCPUBrand.AutoSize = true;
            this.labelCPUBrand.Location = new System.Drawing.Point(6, 22);
            this.labelCPUBrand.Name = "labelCPUBrand";
            this.labelCPUBrand.Size = new System.Drawing.Size(38, 13);
            this.labelCPUBrand.TabIndex = 2;
            this.labelCPUBrand.Text = "Brand:";
            // 
            // comboBoxCPUModel
            // 
            this.comboBoxCPUModel.FormattingEnabled = true;
            this.comboBoxCPUModel.Location = new System.Drawing.Point(73, 47);
            this.comboBoxCPUModel.Name = "comboBoxCPUModel";
            this.comboBoxCPUModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCPUModel.TabIndex = 1;
            this.comboBoxCPUModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCPUModel_SelectedIndexChanged);
            // 
            // comboBoxCPUBrand
            // 
            this.comboBoxCPUBrand.FormattingEnabled = true;
            this.comboBoxCPUBrand.Location = new System.Drawing.Point(73, 19);
            this.comboBoxCPUBrand.Name = "comboBoxCPUBrand";
            this.comboBoxCPUBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCPUBrand.TabIndex = 0;
            this.comboBoxCPUBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxCPUBrand_SelectedIndexChanged);
            // 
            // groupBoxGPU
            // 
            this.groupBoxGPU.Controls.Add(this.labelGPUID);
            this.groupBoxGPU.Controls.Add(this.labelNoEditGPUID);
            this.groupBoxGPU.Controls.Add(this.comboBoxGPU);
            this.groupBoxGPU.Controls.Add(this.labelNoEditGPU);
            this.groupBoxGPU.Controls.Add(this.comboBoxGPUSeries);
            this.groupBoxGPU.Controls.Add(this.labelNoEditGPUSeries);
            this.groupBoxGPU.Location = new System.Drawing.Point(218, 27);
            this.groupBoxGPU.Name = "groupBoxGPU";
            this.groupBoxGPU.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGPU.TabIndex = 2;
            this.groupBoxGPU.TabStop = false;
            this.groupBoxGPU.Text = "GPU";
            // 
            // labelGPUID
            // 
            this.labelGPUID.AutoSize = true;
            this.labelGPUID.Location = new System.Drawing.Point(70, 78);
            this.labelGPUID.Name = "labelGPUID";
            this.labelGPUID.Size = new System.Drawing.Size(63, 13);
            this.labelGPUID.TabIndex = 5;
            this.labelGPUID.Text = "labelGPUID";
            // 
            // labelNoEditGPUID
            // 
            this.labelNoEditGPUID.AutoSize = true;
            this.labelNoEditGPUID.Location = new System.Drawing.Point(6, 78);
            this.labelNoEditGPUID.Name = "labelNoEditGPUID";
            this.labelNoEditGPUID.Size = new System.Drawing.Size(21, 13);
            this.labelNoEditGPUID.TabIndex = 4;
            this.labelNoEditGPUID.Text = "ID:";
            // 
            // comboBoxGPU
            // 
            this.comboBoxGPU.FormattingEnabled = true;
            this.comboBoxGPU.Location = new System.Drawing.Point(73, 46);
            this.comboBoxGPU.Name = "comboBoxGPU";
            this.comboBoxGPU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGPU.TabIndex = 3;
            this.comboBoxGPU.SelectedIndexChanged += new System.EventHandler(this.comboBoxGPU_SelectedIndexChanged);
            // 
            // labelNoEditGPU
            // 
            this.labelNoEditGPU.AutoSize = true;
            this.labelNoEditGPU.Location = new System.Drawing.Point(6, 49);
            this.labelNoEditGPU.Name = "labelNoEditGPU";
            this.labelNoEditGPU.Size = new System.Drawing.Size(33, 13);
            this.labelNoEditGPU.TabIndex = 2;
            this.labelNoEditGPU.Text = "GPU:";
            // 
            // comboBoxGPUSeries
            // 
            this.comboBoxGPUSeries.FormattingEnabled = true;
            this.comboBoxGPUSeries.Location = new System.Drawing.Point(73, 19);
            this.comboBoxGPUSeries.Name = "comboBoxGPUSeries";
            this.comboBoxGPUSeries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGPUSeries.TabIndex = 1;
            this.comboBoxGPUSeries.SelectedIndexChanged += new System.EventHandler(this.comboBoxGPUSeries_SelectedIndexChanged);
            // 
            // labelNoEditGPUSeries
            // 
            this.labelNoEditGPUSeries.AutoSize = true;
            this.labelNoEditGPUSeries.Location = new System.Drawing.Point(6, 22);
            this.labelNoEditGPUSeries.Name = "labelNoEditGPUSeries";
            this.labelNoEditGPUSeries.Size = new System.Drawing.Size(39, 13);
            this.labelNoEditGPUSeries.TabIndex = 0;
            this.labelNoEditGPUSeries.Text = "Series:";
            // 
            // groupBoxRAM
            // 
            this.groupBoxRAM.Controls.Add(this.labelGB);
            this.groupBoxRAM.Controls.Add(this.textBoxRAMAmount);
            this.groupBoxRAM.Controls.Add(this.labelNoEditRAMAmount);
            this.groupBoxRAM.Controls.Add(this.labelRAMID);
            this.groupBoxRAM.Controls.Add(this.comboBoxRAMBrand);
            this.groupBoxRAM.Controls.Add(this.labelNoEditRAMID);
            this.groupBoxRAM.Controls.Add(this.labelNoEditRAMBrand);
            this.groupBoxRAM.Controls.Add(this.labelNoEditRAMModel);
            this.groupBoxRAM.Controls.Add(this.comboBoxRAMModel);
            this.groupBoxRAM.Location = new System.Drawing.Point(218, 133);
            this.groupBoxRAM.Name = "groupBoxRAM";
            this.groupBoxRAM.Size = new System.Drawing.Size(200, 128);
            this.groupBoxRAM.TabIndex = 3;
            this.groupBoxRAM.TabStop = false;
            this.groupBoxRAM.Text = "RAM";
            // 
            // labelGB
            // 
            this.labelGB.AutoSize = true;
            this.labelGB.Location = new System.Drawing.Point(133, 78);
            this.labelGB.Name = "labelGB";
            this.labelGB.Size = new System.Drawing.Size(22, 13);
            this.labelGB.TabIndex = 24;
            this.labelGB.Text = "GB";
            // 
            // textBoxRAMAmount
            // 
            this.textBoxRAMAmount.Location = new System.Drawing.Point(73, 75);
            this.textBoxRAMAmount.Name = "textBoxRAMAmount";
            this.textBoxRAMAmount.Size = new System.Drawing.Size(60, 20);
            this.textBoxRAMAmount.TabIndex = 23;
            // 
            // labelNoEditRAMAmount
            // 
            this.labelNoEditRAMAmount.AutoSize = true;
            this.labelNoEditRAMAmount.Location = new System.Drawing.Point(7, 78);
            this.labelNoEditRAMAmount.Name = "labelNoEditRAMAmount";
            this.labelNoEditRAMAmount.Size = new System.Drawing.Size(46, 13);
            this.labelNoEditRAMAmount.TabIndex = 22;
            this.labelNoEditRAMAmount.Text = "Amount:";
            // 
            // labelRAMID
            // 
            this.labelRAMID.AutoSize = true;
            this.labelRAMID.Location = new System.Drawing.Point(70, 106);
            this.labelRAMID.Name = "labelRAMID";
            this.labelRAMID.Size = new System.Drawing.Size(64, 13);
            this.labelRAMID.TabIndex = 21;
            this.labelRAMID.Text = "labelRAMID";
            // 
            // comboBoxRAMBrand
            // 
            this.comboBoxRAMBrand.FormattingEnabled = true;
            this.comboBoxRAMBrand.Location = new System.Drawing.Point(73, 19);
            this.comboBoxRAMBrand.Name = "comboBoxRAMBrand";
            this.comboBoxRAMBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRAMBrand.TabIndex = 16;
            this.comboBoxRAMBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAMBrand_SelectedIndexChanged);
            // 
            // labelNoEditRAMID
            // 
            this.labelNoEditRAMID.AutoSize = true;
            this.labelNoEditRAMID.Location = new System.Drawing.Point(6, 106);
            this.labelNoEditRAMID.Name = "labelNoEditRAMID";
            this.labelNoEditRAMID.Size = new System.Drawing.Size(21, 13);
            this.labelNoEditRAMID.TabIndex = 20;
            this.labelNoEditRAMID.Text = "ID:";
            // 
            // labelNoEditRAMBrand
            // 
            this.labelNoEditRAMBrand.AutoSize = true;
            this.labelNoEditRAMBrand.Location = new System.Drawing.Point(6, 22);
            this.labelNoEditRAMBrand.Name = "labelNoEditRAMBrand";
            this.labelNoEditRAMBrand.Size = new System.Drawing.Size(38, 13);
            this.labelNoEditRAMBrand.TabIndex = 18;
            this.labelNoEditRAMBrand.Text = "Brand:";
            // 
            // labelNoEditRAMModel
            // 
            this.labelNoEditRAMModel.AutoSize = true;
            this.labelNoEditRAMModel.Location = new System.Drawing.Point(5, 50);
            this.labelNoEditRAMModel.Name = "labelNoEditRAMModel";
            this.labelNoEditRAMModel.Size = new System.Drawing.Size(68, 13);
            this.labelNoEditRAMModel.TabIndex = 19;
            this.labelNoEditRAMModel.Text = "ClockSpeed:";
            // 
            // comboBoxRAMModel
            // 
            this.comboBoxRAMModel.FormattingEnabled = true;
            this.comboBoxRAMModel.Location = new System.Drawing.Point(73, 47);
            this.comboBoxRAMModel.Name = "comboBoxRAMModel";
            this.comboBoxRAMModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRAMModel.TabIndex = 17;
            this.comboBoxRAMModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAMModel_SelectedIndexChanged);
            // 
            // groupBoxCASE
            // 
            this.groupBoxCASE.Controls.Add(this.labelCaseID);
            this.groupBoxCASE.Controls.Add(this.comboBoxCaseBrand);
            this.groupBoxCASE.Controls.Add(this.labelNoEditCaseID);
            this.groupBoxCASE.Controls.Add(this.labelNoEditCaseBrand);
            this.groupBoxCASE.Controls.Add(this.labelNoEditCaseModel);
            this.groupBoxCASE.Controls.Add(this.comboBoxCaseModel);
            this.groupBoxCASE.Location = new System.Drawing.Point(424, 161);
            this.groupBoxCASE.Name = "groupBoxCASE";
            this.groupBoxCASE.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCASE.TabIndex = 4;
            this.groupBoxCASE.TabStop = false;
            this.groupBoxCASE.Text = "Case";
            // 
            // labelCaseID
            // 
            this.labelCaseID.AutoSize = true;
            this.labelCaseID.Location = new System.Drawing.Point(70, 78);
            this.labelCaseID.Name = "labelCaseID";
            this.labelCaseID.Size = new System.Drawing.Size(64, 13);
            this.labelCaseID.TabIndex = 21;
            this.labelCaseID.Text = "labelCaseID";
            // 
            // comboBoxCaseBrand
            // 
            this.comboBoxCaseBrand.FormattingEnabled = true;
            this.comboBoxCaseBrand.Location = new System.Drawing.Point(73, 19);
            this.comboBoxCaseBrand.Name = "comboBoxCaseBrand";
            this.comboBoxCaseBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCaseBrand.TabIndex = 16;
            this.comboBoxCaseBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaseBrand_SelectedIndexChanged);
            // 
            // labelNoEditCaseID
            // 
            this.labelNoEditCaseID.AutoSize = true;
            this.labelNoEditCaseID.Location = new System.Drawing.Point(6, 78);
            this.labelNoEditCaseID.Name = "labelNoEditCaseID";
            this.labelNoEditCaseID.Size = new System.Drawing.Size(21, 13);
            this.labelNoEditCaseID.TabIndex = 20;
            this.labelNoEditCaseID.Text = "ID:";
            // 
            // labelNoEditCaseBrand
            // 
            this.labelNoEditCaseBrand.AutoSize = true;
            this.labelNoEditCaseBrand.Location = new System.Drawing.Point(6, 22);
            this.labelNoEditCaseBrand.Name = "labelNoEditCaseBrand";
            this.labelNoEditCaseBrand.Size = new System.Drawing.Size(38, 13);
            this.labelNoEditCaseBrand.TabIndex = 18;
            this.labelNoEditCaseBrand.Text = "Brand:";
            // 
            // labelNoEditCaseModel
            // 
            this.labelNoEditCaseModel.AutoSize = true;
            this.labelNoEditCaseModel.Location = new System.Drawing.Point(6, 50);
            this.labelNoEditCaseModel.Name = "labelNoEditCaseModel";
            this.labelNoEditCaseModel.Size = new System.Drawing.Size(39, 13);
            this.labelNoEditCaseModel.TabIndex = 19;
            this.labelNoEditCaseModel.Text = "Model:";
            // 
            // comboBoxCaseModel
            // 
            this.comboBoxCaseModel.FormattingEnabled = true;
            this.comboBoxCaseModel.Location = new System.Drawing.Point(73, 47);
            this.comboBoxCaseModel.Name = "comboBoxCaseModel";
            this.comboBoxCaseModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCaseModel.TabIndex = 17;
            this.comboBoxCaseModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaseModel_SelectedIndexChanged);
            // 
            // groupBoxMOBO
            // 
            this.groupBoxMOBO.Controls.Add(this.labelMOBOID);
            this.groupBoxMOBO.Controls.Add(this.labelNoEditMOBOID);
            this.groupBoxMOBO.Controls.Add(this.labelMOBONoEditModel);
            this.groupBoxMOBO.Controls.Add(this.comboBoxMOBOModel);
            this.groupBoxMOBO.Controls.Add(this.labelNoEditMOBOBrand);
            this.groupBoxMOBO.Controls.Add(this.comboBoxMOBOBrand);
            this.groupBoxMOBO.Location = new System.Drawing.Point(12, 231);
            this.groupBoxMOBO.Name = "groupBoxMOBO";
            this.groupBoxMOBO.Size = new System.Drawing.Size(200, 110);
            this.groupBoxMOBO.TabIndex = 5;
            this.groupBoxMOBO.TabStop = false;
            this.groupBoxMOBO.Text = "MOBO";
            // 
            // labelMOBOID
            // 
            this.labelMOBOID.AutoSize = true;
            this.labelMOBOID.Location = new System.Drawing.Point(70, 80);
            this.labelMOBOID.Name = "labelMOBOID";
            this.labelMOBOID.Size = new System.Drawing.Size(72, 13);
            this.labelMOBOID.TabIndex = 15;
            this.labelMOBOID.Text = "labelMOBOID";
            // 
            // labelNoEditMOBOID
            // 
            this.labelNoEditMOBOID.AutoSize = true;
            this.labelNoEditMOBOID.Location = new System.Drawing.Point(6, 80);
            this.labelNoEditMOBOID.Name = "labelNoEditMOBOID";
            this.labelNoEditMOBOID.Size = new System.Drawing.Size(21, 13);
            this.labelNoEditMOBOID.TabIndex = 14;
            this.labelNoEditMOBOID.Text = "ID:";
            // 
            // labelMOBONoEditModel
            // 
            this.labelMOBONoEditModel.AutoSize = true;
            this.labelMOBONoEditModel.Location = new System.Drawing.Point(6, 52);
            this.labelMOBONoEditModel.Name = "labelMOBONoEditModel";
            this.labelMOBONoEditModel.Size = new System.Drawing.Size(39, 13);
            this.labelMOBONoEditModel.TabIndex = 13;
            this.labelMOBONoEditModel.Text = "Model:";
            // 
            // comboBoxMOBOModel
            // 
            this.comboBoxMOBOModel.FormattingEnabled = true;
            this.comboBoxMOBOModel.Location = new System.Drawing.Point(73, 49);
            this.comboBoxMOBOModel.Name = "comboBoxMOBOModel";
            this.comboBoxMOBOModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMOBOModel.TabIndex = 11;
            this.comboBoxMOBOModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxMOBOModel_SelectedIndexChanged);
            // 
            // labelNoEditMOBOBrand
            // 
            this.labelNoEditMOBOBrand.AutoSize = true;
            this.labelNoEditMOBOBrand.Location = new System.Drawing.Point(6, 24);
            this.labelNoEditMOBOBrand.Name = "labelNoEditMOBOBrand";
            this.labelNoEditMOBOBrand.Size = new System.Drawing.Size(38, 13);
            this.labelNoEditMOBOBrand.TabIndex = 12;
            this.labelNoEditMOBOBrand.Text = "Brand:";
            // 
            // comboBoxMOBOBrand
            // 
            this.comboBoxMOBOBrand.FormattingEnabled = true;
            this.comboBoxMOBOBrand.Location = new System.Drawing.Point(73, 21);
            this.comboBoxMOBOBrand.Name = "comboBoxMOBOBrand";
            this.comboBoxMOBOBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMOBOBrand.TabIndex = 10;
            this.comboBoxMOBOBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxMOBOBrand_SelectedIndexChanged);
            // 
            // groupBoxPSU
            // 
            this.groupBoxPSU.Controls.Add(this.labelPSUPower);
            this.groupBoxPSU.Controls.Add(this.comboBoxPSUModel);
            this.groupBoxPSU.Controls.Add(this.labelNoEditPSUPower);
            this.groupBoxPSU.Controls.Add(this.labelNoEditPSUModel);
            this.groupBoxPSU.Controls.Add(this.labelPSUID);
            this.groupBoxPSU.Controls.Add(this.labelNoEditPSUBrand);
            this.groupBoxPSU.Controls.Add(this.comboBoxPSUBrand);
            this.groupBoxPSU.Controls.Add(this.label5);
            this.groupBoxPSU.Location = new System.Drawing.Point(424, 27);
            this.groupBoxPSU.Name = "groupBoxPSU";
            this.groupBoxPSU.Size = new System.Drawing.Size(200, 123);
            this.groupBoxPSU.TabIndex = 6;
            this.groupBoxPSU.TabStop = false;
            this.groupBoxPSU.Text = "PSU";
            // 
            // comboBoxPSUModel
            // 
            this.comboBoxPSUModel.FormattingEnabled = true;
            this.comboBoxPSUModel.Location = new System.Drawing.Point(73, 46);
            this.comboBoxPSUModel.Name = "comboBoxPSUModel";
            this.comboBoxPSUModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPSUModel.TabIndex = 26;
            this.comboBoxPSUModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPSUModel_SelectedIndexChanged);
            // 
            // labelNoEditPSUPower
            // 
            this.labelNoEditPSUPower.AutoSize = true;
            this.labelNoEditPSUPower.Location = new System.Drawing.Point(7, 78);
            this.labelNoEditPSUPower.Name = "labelNoEditPSUPower";
            this.labelNoEditPSUPower.Size = new System.Drawing.Size(40, 13);
            this.labelNoEditPSUPower.TabIndex = 31;
            this.labelNoEditPSUPower.Text = "Power:";
            // 
            // labelNoEditPSUModel
            // 
            this.labelNoEditPSUModel.AutoSize = true;
            this.labelNoEditPSUModel.Location = new System.Drawing.Point(6, 50);
            this.labelNoEditPSUModel.Name = "labelNoEditPSUModel";
            this.labelNoEditPSUModel.Size = new System.Drawing.Size(39, 13);
            this.labelNoEditPSUModel.TabIndex = 28;
            this.labelNoEditPSUModel.Text = "Model:";
            // 
            // labelPSUID
            // 
            this.labelPSUID.AutoSize = true;
            this.labelPSUID.Location = new System.Drawing.Point(70, 101);
            this.labelPSUID.Name = "labelPSUID";
            this.labelPSUID.Size = new System.Drawing.Size(62, 13);
            this.labelPSUID.TabIndex = 30;
            this.labelPSUID.Text = "labelPSUID";
            // 
            // labelNoEditPSUBrand
            // 
            this.labelNoEditPSUBrand.AutoSize = true;
            this.labelNoEditPSUBrand.Location = new System.Drawing.Point(7, 22);
            this.labelNoEditPSUBrand.Name = "labelNoEditPSUBrand";
            this.labelNoEditPSUBrand.Size = new System.Drawing.Size(38, 13);
            this.labelNoEditPSUBrand.TabIndex = 27;
            this.labelNoEditPSUBrand.Text = "Brand:";
            // 
            // comboBoxPSUBrand
            // 
            this.comboBoxPSUBrand.FormattingEnabled = true;
            this.comboBoxPSUBrand.Location = new System.Drawing.Point(73, 19);
            this.comboBoxPSUBrand.Name = "comboBoxPSUBrand";
            this.comboBoxPSUBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPSUBrand.TabIndex = 25;
            this.comboBoxPSUBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxPSUBrand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "ID:";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(218, 308);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(98, 33);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "Previous";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(320, 308);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(98, 33);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSaveAsNew
            // 
            this.buttonSaveAsNew.Location = new System.Drawing.Point(433, 269);
            this.buttonSaveAsNew.Name = "buttonSaveAsNew";
            this.buttonSaveAsNew.Size = new System.Drawing.Size(191, 36);
            this.buttonSaveAsNew.TabIndex = 9;
            this.buttonSaveAsNew.Text = "Save as new";
            this.buttonSaveAsNew.UseVisualStyleBackColor = true;
            this.buttonSaveAsNew.Click += new System.EventHandler(this.buttonSaveAsNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(507, 308);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 33);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete from database";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(433, 308);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(68, 33);
            this.buttonErase.TabIndex = 11;
            this.buttonErase.Text = "Clear Info";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // labelNoEditComputerID
            // 
            this.labelNoEditComputerID.AutoSize = true;
            this.labelNoEditComputerID.Location = new System.Drawing.Point(230, 280);
            this.labelNoEditComputerID.Name = "labelNoEditComputerID";
            this.labelNoEditComputerID.Size = new System.Drawing.Size(69, 13);
            this.labelNoEditComputerID.TabIndex = 12;
            this.labelNoEditComputerID.Text = "Computer ID:";
            // 
            // labelComputerID
            // 
            this.labelComputerID.AutoSize = true;
            this.labelComputerID.Location = new System.Drawing.Point(297, 280);
            this.labelComputerID.Name = "labelComputerID";
            this.labelComputerID.Size = new System.Drawing.Size(85, 13);
            this.labelComputerID.TabIndex = 13;
            this.labelComputerID.Text = "labelComputerID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 234);
            this.dataGridView1.TabIndex = 14;
            // 
            // labelPSUPower
            // 
            this.labelPSUPower.AutoSize = true;
            this.labelPSUPower.Location = new System.Drawing.Point(70, 78);
            this.labelPSUPower.Name = "labelPSUPower";
            this.labelPSUPower.Size = new System.Drawing.Size(81, 13);
            this.labelPSUPower.TabIndex = 32;
            this.labelPSUPower.Text = "labelPSUPower";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelComputerID);
            this.Controls.Add(this.labelNoEditComputerID);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaveAsNew);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.groupBoxPSU);
            this.Controls.Add(this.groupBoxMOBO);
            this.Controls.Add(this.groupBoxCASE);
            this.Controls.Add(this.groupBoxRAM);
            this.Controls.Add(this.groupBoxGPU);
            this.Controls.Add(this.groupBoxCPU);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Computer Database";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            this.groupBoxGPU.ResumeLayout(false);
            this.groupBoxGPU.PerformLayout();
            this.groupBoxRAM.ResumeLayout(false);
            this.groupBoxRAM.PerformLayout();
            this.groupBoxCASE.ResumeLayout(false);
            this.groupBoxCASE.PerformLayout();
            this.groupBoxMOBO.ResumeLayout(false);
            this.groupBoxMOBO.PerformLayout();
            this.groupBoxPSU.ResumeLayout(false);
            this.groupBoxPSU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.Label labelNoEditCPUID;
        private System.Windows.Forms.Label labelCPUThreads;
        private System.Windows.Forms.Label labelCPUCores;
        private System.Windows.Forms.Label labelNoEditCPUThreads;
        private System.Windows.Forms.Label labelNoEditCPUCores;
        private System.Windows.Forms.Label labelCPUClockSpeed;
        private System.Windows.Forms.Label labelNoEditCPUClockSpeed;
        private System.Windows.Forms.Label labelCPUModel;
        private System.Windows.Forms.Label labelCPUBrand;
        private System.Windows.Forms.ComboBox comboBoxCPUModel;
        private System.Windows.Forms.ComboBox comboBoxCPUBrand;
        private System.Windows.Forms.GroupBox groupBoxGPU;
        private System.Windows.Forms.Label labelNoEditGPUID;
        private System.Windows.Forms.ComboBox comboBoxGPU;
        private System.Windows.Forms.Label labelNoEditGPU;
        private System.Windows.Forms.ComboBox comboBoxGPUSeries;
        private System.Windows.Forms.Label labelNoEditGPUSeries;
        private System.Windows.Forms.GroupBox groupBoxRAM;
        private System.Windows.Forms.GroupBox groupBoxCASE;
        private System.Windows.Forms.GroupBox groupBoxMOBO;
        private System.Windows.Forms.Label labelNoEditMOBOID;
        private System.Windows.Forms.Label labelMOBONoEditModel;
        private System.Windows.Forms.ComboBox comboBoxMOBOModel;
        private System.Windows.Forms.Label labelNoEditMOBOBrand;
        private System.Windows.Forms.ComboBox comboBoxMOBOBrand;
        private System.Windows.Forms.GroupBox groupBoxPSU;
        private System.Windows.Forms.Label labelCPUID;
        private System.Windows.Forms.Label labelGPUID;
        private System.Windows.Forms.Label labelGB;
        private System.Windows.Forms.TextBox textBoxRAMAmount;
        private System.Windows.Forms.Label labelNoEditRAMAmount;
        private System.Windows.Forms.Label labelRAMID;
        private System.Windows.Forms.ComboBox comboBoxRAMBrand;
        private System.Windows.Forms.Label labelNoEditRAMID;
        private System.Windows.Forms.Label labelNoEditRAMBrand;
        private System.Windows.Forms.Label labelNoEditRAMModel;
        private System.Windows.Forms.ComboBox comboBoxRAMModel;
        private System.Windows.Forms.Label labelCaseID;
        private System.Windows.Forms.ComboBox comboBoxCaseBrand;
        private System.Windows.Forms.Label labelNoEditCaseID;
        private System.Windows.Forms.Label labelNoEditCaseBrand;
        private System.Windows.Forms.Label labelNoEditCaseModel;
        private System.Windows.Forms.ComboBox comboBoxCaseModel;
        private System.Windows.Forms.Label labelMOBOID;
        private System.Windows.Forms.ComboBox comboBoxPSUModel;
        private System.Windows.Forms.Label labelNoEditPSUPower;
        private System.Windows.Forms.Label labelNoEditPSUModel;
        private System.Windows.Forms.Label labelPSUID;
        private System.Windows.Forms.Label labelNoEditPSUBrand;
        private System.Windows.Forms.ComboBox comboBoxPSUBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSaveAsNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Label labelNoEditComputerID;
        private System.Windows.Forms.Label labelComputerID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPSUPower;
    }
}

