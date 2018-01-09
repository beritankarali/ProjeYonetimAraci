namespace YazılımSınamaProje
{
    partial class frmProjeYonetimAraci
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
            System.Windows.Forms.Label testLabel;
            System.Windows.Forms.Label arayüzLabel;
            System.Windows.Forms.Label tabloLabel;
            System.Windows.Forms.Label analizLabel;
            System.Windows.Forms.Label complateRateLabel1;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label workNameIDLabel;
            System.Windows.Forms.Label workFinishDateLabel;
            System.Windows.Forms.Label workStartDateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label complateRateLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label finishDateLabel1;
            System.Windows.Forms.Label startDateLabel1;
            System.Windows.Forms.Label processNameLabel;
            System.Windows.Forms.Label finishDateLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label budgetLabel;
            System.Windows.Forms.Label projectNameLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeYonetimAraci));
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbYazilimTestDataSet = new YazılımSınamaProje.dbYazilimTestDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new YazılımSınamaProje.dbYazilimTestDataSetTableAdapters.ProjectTableAdapter();
            this.tableAdapterManager = new YazılımSınamaProje.dbYazilimTestDataSetTableAdapters.TableAdapterManager();
            this.processTableAdapter = new YazılımSınamaProje.dbYazilimTestDataSetTableAdapters.ProcessTableAdapter();
            this.workTableAdapter = new YazılımSınamaProje.dbYazilimTestDataSetTableAdapters.WorkTableAdapter();
            this.tbIsDetaylandirma = new System.Windows.Forms.TabPage();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.workBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.workBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workNameIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.complateRateTextBox1 = new System.Windows.Forms.TextBox();
            this.analizTextBox = new System.Windows.Forms.TextBox();
            this.tabloTextBox = new System.Windows.Forms.TextBox();
            this.arayüzTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.workStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workFinishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIsSureci = new System.Windows.Forms.TabPage();
            this.processBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.processBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.complateRateTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.finishDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.processDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbYonetici = new System.Windows.Forms.TabPage();
            this.btnIsSureciEkle = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.projectDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMusteriIslemleri = new System.Windows.Forms.TabPage();
            this.grpBoxProjeEkle = new System.Windows.Forms.GroupBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.projectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGiris = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxMusteri = new System.Windows.Forms.GroupBox();
            this.lblMusteriKullaniciAdi = new System.Windows.Forms.Label();
            this.txtMusteriKulAd = new System.Windows.Forms.TextBox();
            this.lblMusteriSifre = new System.Windows.Forms.Label();
            this.btnMusteriGiris = new System.Windows.Forms.Button();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.grpBoxYonetici = new System.Windows.Forms.GroupBox();
            this.txtYoneticiAd = new System.Windows.Forms.TextBox();
            this.lblYoneticiKullaniciAdi = new System.Windows.Forms.Label();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.lblYoneticiSifre = new System.Windows.Forms.Label();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.tbProjeYonetimAraci = new System.Windows.Forms.TabControl();
            this.tbRapor = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            testLabel = new System.Windows.Forms.Label();
            arayüzLabel = new System.Windows.Forms.Label();
            tabloLabel = new System.Windows.Forms.Label();
            analizLabel = new System.Windows.Forms.Label();
            complateRateLabel1 = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            workNameIDLabel = new System.Windows.Forms.Label();
            workFinishDateLabel = new System.Windows.Forms.Label();
            workStartDateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            complateRateLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            finishDateLabel1 = new System.Windows.Forms.Label();
            startDateLabel1 = new System.Windows.Forms.Label();
            processNameLabel = new System.Windows.Forms.Label();
            finishDateLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYazilimTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.tbIsDetaylandirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingNavigator)).BeginInit();
            this.workBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).BeginInit();
            this.tbIsSureci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingNavigator)).BeginInit();
            this.processBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGridView)).BeginInit();
            this.tbYonetici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView1)).BeginInit();
            this.tbMusteriIslemleri.SuspendLayout();
            this.grpBoxProjeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingNavigator)).BeginInit();
            this.projectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.tbGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxMusteri.SuspendLayout();
            this.grpBoxYonetici.SuspendLayout();
            this.tbProjeYonetimAraci.SuspendLayout();
            this.tbRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new System.Drawing.Point(19, 260);
            testLabel.Name = "testLabel";
            testLabel.Size = new System.Drawing.Size(31, 13);
            testLabel.TabIndex = 21;
            testLabel.Text = "Test:";
            // 
            // arayüzLabel
            // 
            arayüzLabel.AutoSize = true;
            arayüzLabel.Location = new System.Drawing.Point(19, 234);
            arayüzLabel.Name = "arayüzLabel";
            arayüzLabel.Size = new System.Drawing.Size(42, 13);
            arayüzLabel.TabIndex = 19;
            arayüzLabel.Text = "Arayüz:";
            // 
            // tabloLabel
            // 
            tabloLabel.AutoSize = true;
            tabloLabel.Location = new System.Drawing.Point(19, 208);
            tabloLabel.Name = "tabloLabel";
            tabloLabel.Size = new System.Drawing.Size(37, 13);
            tabloLabel.TabIndex = 17;
            tabloLabel.Text = "Tablo:";
            // 
            // analizLabel
            // 
            analizLabel.AutoSize = true;
            analizLabel.Location = new System.Drawing.Point(19, 182);
            analizLabel.Name = "analizLabel";
            analizLabel.Size = new System.Drawing.Size(38, 13);
            analizLabel.TabIndex = 15;
            analizLabel.Text = "Analiz:";
            // 
            // complateRateLabel1
            // 
            complateRateLabel1.AutoSize = true;
            complateRateLabel1.Location = new System.Drawing.Point(19, 156);
            complateRateLabel1.Name = "complateRateLabel1";
            complateRateLabel1.Size = new System.Drawing.Size(80, 13);
            complateRateLabel1.TabIndex = 13;
            complateRateLabel1.Text = "Complate Rate:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(19, 130);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 11;
            userIDLabel.Text = "User ID:";
            // 
            // workNameIDLabel
            // 
            workNameIDLabel.AutoSize = true;
            workNameIDLabel.Location = new System.Drawing.Point(19, 104);
            workNameIDLabel.Name = "workNameIDLabel";
            workNameIDLabel.Size = new System.Drawing.Size(81, 13);
            workNameIDLabel.TabIndex = 9;
            workNameIDLabel.Text = "Work Name ID:";
            // 
            // workFinishDateLabel
            // 
            workFinishDateLabel.AutoSize = true;
            workFinishDateLabel.Location = new System.Drawing.Point(19, 79);
            workFinishDateLabel.Name = "workFinishDateLabel";
            workFinishDateLabel.Size = new System.Drawing.Size(92, 13);
            workFinishDateLabel.TabIndex = 7;
            workFinishDateLabel.Text = "Work Finish Date:";
            // 
            // workStartDateLabel
            // 
            workStartDateLabel.AutoSize = true;
            workStartDateLabel.Location = new System.Drawing.Point(19, 53);
            workStartDateLabel.Name = "workStartDateLabel";
            workStartDateLabel.Size = new System.Drawing.Size(87, 13);
            workStartDateLabel.TabIndex = 5;
            workStartDateLabel.Text = "Work Start Date:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(6, 199);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(6, 170);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(41, 13);
            priorityLabel.TabIndex = 15;
            priorityLabel.Text = "Priority:";
            // 
            // complateRateLabel
            // 
            complateRateLabel.AutoSize = true;
            complateRateLabel.Location = new System.Drawing.Point(6, 144);
            complateRateLabel.Name = "complateRateLabel";
            complateRateLabel.Size = new System.Drawing.Size(80, 13);
            complateRateLabel.TabIndex = 13;
            complateRateLabel.Text = "Complate Rate:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(6, 118);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 11;
            durationLabel.Text = "Duration:";
            // 
            // finishDateLabel1
            // 
            finishDateLabel1.AutoSize = true;
            finishDateLabel1.Location = new System.Drawing.Point(6, 91);
            finishDateLabel1.Name = "finishDateLabel1";
            finishDateLabel1.Size = new System.Drawing.Size(63, 13);
            finishDateLabel1.TabIndex = 9;
            finishDateLabel1.Text = "Finish Date:";
            // 
            // startDateLabel1
            // 
            startDateLabel1.AutoSize = true;
            startDateLabel1.Location = new System.Drawing.Point(6, 65);
            startDateLabel1.Name = "startDateLabel1";
            startDateLabel1.Size = new System.Drawing.Size(58, 13);
            startDateLabel1.TabIndex = 7;
            startDateLabel1.Text = "Start Date:";
            // 
            // processNameLabel
            // 
            processNameLabel.AutoSize = true;
            processNameLabel.Location = new System.Drawing.Point(6, 42);
            processNameLabel.Name = "processNameLabel";
            processNameLabel.Size = new System.Drawing.Size(79, 13);
            processNameLabel.TabIndex = 3;
            processNameLabel.Text = "Process Name:";
            // 
            // finishDateLabel
            // 
            finishDateLabel.AutoSize = true;
            finishDateLabel.Location = new System.Drawing.Point(9, 107);
            finishDateLabel.Name = "finishDateLabel";
            finishDateLabel.Size = new System.Drawing.Size(63, 13);
            finishDateLabel.TabIndex = 7;
            finishDateLabel.Text = "Finish Date:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(9, 134);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 9;
            isActiveLabel.Text = "Is Active:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(9, 81);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 5;
            startDateLabel.Text = "Start Date:";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(9, 162);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(44, 13);
            budgetLabel.TabIndex = 11;
            budgetLabel.Text = "Budget:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(9, 54);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 3;
            projectNameLabel.Text = "Project Name:";
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataMember = "Work";
            this.workBindingSource.DataSource = this.dbYazilimTestDataSet;
            // 
            // dbYazilimTestDataSet
            // 
            this.dbYazilimTestDataSet.DataSetName = "dbYazilimTestDataSet";
            this.dbYazilimTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.dbYazilimTestDataSet;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataMember = "Process";
            this.processBindingSource.DataSource = this.dbYazilimTestDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProcessTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.RoleNamesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YazılımSınamaProje.dbYazilimTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLogDetayTableAdapter = null;
            this.tableAdapterManager.UserLogTableAdapter = null;
            this.tableAdapterManager.UserProcessTableAdapter = null;
            this.tableAdapterManager.UserRolesTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WorkNameTableAdapter = null;
            this.tableAdapterManager.WorkTableAdapter = null;
            // 
            // processTableAdapter
            // 
            this.processTableAdapter.ClearBeforeFill = true;
            // 
            // workTableAdapter
            // 
            this.workTableAdapter.ClearBeforeFill = true;
            // 
            // tbIsDetaylandirma
            // 
            this.tbIsDetaylandirma.AutoScroll = true;
            this.tbIsDetaylandirma.Controls.Add(this.pictureBox6);
            this.tbIsDetaylandirma.Controls.Add(this.btnYazdir);
            this.tbIsDetaylandirma.Controls.Add(this.workBindingNavigator);
            this.tbIsDetaylandirma.Controls.Add(this.workNameIDTextBox);
            this.tbIsDetaylandirma.Controls.Add(this.userIDTextBox);
            this.tbIsDetaylandirma.Controls.Add(this.complateRateTextBox1);
            this.tbIsDetaylandirma.Controls.Add(this.analizTextBox);
            this.tbIsDetaylandirma.Controls.Add(this.tabloTextBox);
            this.tbIsDetaylandirma.Controls.Add(this.arayüzTextBox);
            this.tbIsDetaylandirma.Controls.Add(this.testTextBox);
            this.tbIsDetaylandirma.Controls.Add(workStartDateLabel);
            this.tbIsDetaylandirma.Controls.Add(this.workStartDateDateTimePicker);
            this.tbIsDetaylandirma.Controls.Add(workFinishDateLabel);
            this.tbIsDetaylandirma.Controls.Add(this.workFinishDateDateTimePicker);
            this.tbIsDetaylandirma.Controls.Add(workNameIDLabel);
            this.tbIsDetaylandirma.Controls.Add(userIDLabel);
            this.tbIsDetaylandirma.Controls.Add(complateRateLabel1);
            this.tbIsDetaylandirma.Controls.Add(analizLabel);
            this.tbIsDetaylandirma.Controls.Add(tabloLabel);
            this.tbIsDetaylandirma.Controls.Add(arayüzLabel);
            this.tbIsDetaylandirma.Controls.Add(testLabel);
            this.tbIsDetaylandirma.Controls.Add(this.workDataGridView);
            this.tbIsDetaylandirma.Location = new System.Drawing.Point(4, 22);
            this.tbIsDetaylandirma.Name = "tbIsDetaylandirma";
            this.tbIsDetaylandirma.Padding = new System.Windows.Forms.Padding(3);
            this.tbIsDetaylandirma.Size = new System.Drawing.Size(1126, 408);
            this.tbIsDetaylandirma.TabIndex = 5;
            this.tbIsDetaylandirma.Text = "İş Detaylandırma";
            this.tbIsDetaylandirma.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(284, 3);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(63, 23);
            this.btnYazdir.TabIndex = 25;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // workBindingNavigator
            // 
            this.workBindingNavigator.AddNewItem = this.toolStripButton15;
            this.workBindingNavigator.BindingSource = this.workBindingSource;
            this.workBindingNavigator.CountItem = this.toolStripLabel3;
            this.workBindingNavigator.DeleteItem = this.toolStripButton16;
            this.workBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator9,
            this.toolStripButton15,
            this.toolStripButton16,
            this.workBindingNavigatorSaveItem});
            this.workBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.workBindingNavigator.MoveFirstItem = this.toolStripButton17;
            this.workBindingNavigator.MoveLastItem = this.toolStripButton20;
            this.workBindingNavigator.MoveNextItem = this.toolStripButton19;
            this.workBindingNavigator.MovePreviousItem = this.toolStripButton18;
            this.workBindingNavigator.Name = "workBindingNavigator";
            this.workBindingNavigator.PositionItem = this.toolStripTextBox3;
            this.workBindingNavigator.Size = new System.Drawing.Size(1120, 25);
            this.workBindingNavigator.TabIndex = 24;
            this.workBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Add new";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Delete";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Move first";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Move previous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "Move next";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Move last";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // workBindingNavigatorSaveItem
            // 
            this.workBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workBindingNavigatorSaveItem.Image")));
            this.workBindingNavigatorSaveItem.Name = "workBindingNavigatorSaveItem";
            this.workBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.workBindingNavigatorSaveItem.Text = "Save Data";
            this.workBindingNavigatorSaveItem.Click += new System.EventHandler(this.workBindingNavigatorSaveItem_Click);
            // 
            // workNameIDTextBox
            // 
            this.workNameIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "WorkNameID", true));
            this.workNameIDTextBox.Location = new System.Drawing.Point(117, 101);
            this.workNameIDTextBox.Name = "workNameIDTextBox";
            this.workNameIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.workNameIDTextBox.TabIndex = 10;
            this.workNameIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.workNameIDTextBox_KeyPress);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(117, 127);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.userIDTextBox.TabIndex = 12;
            this.userIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userIDTextBox_KeyPress);
            // 
            // complateRateTextBox1
            // 
            this.complateRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "ComplateRate", true));
            this.complateRateTextBox1.Location = new System.Drawing.Point(117, 153);
            this.complateRateTextBox1.Name = "complateRateTextBox1";
            this.complateRateTextBox1.Size = new System.Drawing.Size(114, 20);
            this.complateRateTextBox1.TabIndex = 14;
            this.complateRateTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.complateRateTextBox1_KeyPress);
            // 
            // analizTextBox
            // 
            this.analizTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Analiz", true));
            this.analizTextBox.Location = new System.Drawing.Point(117, 179);
            this.analizTextBox.Name = "analizTextBox";
            this.analizTextBox.Size = new System.Drawing.Size(114, 20);
            this.analizTextBox.TabIndex = 16;
            this.analizTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.analizTextBox_KeyPress);
            // 
            // tabloTextBox
            // 
            this.tabloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Tablo", true));
            this.tabloTextBox.Location = new System.Drawing.Point(117, 205);
            this.tabloTextBox.Name = "tabloTextBox";
            this.tabloTextBox.Size = new System.Drawing.Size(114, 20);
            this.tabloTextBox.TabIndex = 18;
            this.tabloTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabloTextBox_KeyPress);
            // 
            // arayüzTextBox
            // 
            this.arayüzTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Arayüz", true));
            this.arayüzTextBox.Location = new System.Drawing.Point(117, 231);
            this.arayüzTextBox.Name = "arayüzTextBox";
            this.arayüzTextBox.Size = new System.Drawing.Size(114, 20);
            this.arayüzTextBox.TabIndex = 20;
            this.arayüzTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arayüzTextBox_KeyPress);
            // 
            // testTextBox
            // 
            this.testTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Test", true));
            this.testTextBox.Location = new System.Drawing.Point(117, 257);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(114, 20);
            this.testTextBox.TabIndex = 22;
            this.testTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.testTextBox_KeyPress);
            // 
            // workStartDateDateTimePicker
            // 
            this.workStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workBindingSource, "WorkStartDate", true));
            this.workStartDateDateTimePicker.Location = new System.Drawing.Point(117, 49);
            this.workStartDateDateTimePicker.Name = "workStartDateDateTimePicker";
            this.workStartDateDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.workStartDateDateTimePicker.TabIndex = 6;
            // 
            // workFinishDateDateTimePicker
            // 
            this.workFinishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workBindingSource, "WorkFinishDate", true));
            this.workFinishDateDateTimePicker.Location = new System.Drawing.Point(117, 75);
            this.workFinishDateDateTimePicker.Name = "workFinishDateDateTimePicker";
            this.workFinishDateDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.workFinishDateDateTimePicker.TabIndex = 8;
            // 
            // workDataGridView
            // 
            this.workDataGridView.AutoGenerateColumns = false;
            this.workDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.workDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.workDataGridView.DataSource = this.workBindingSource;
            this.workDataGridView.Location = new System.Drawing.Point(237, 49);
            this.workDataGridView.Name = "workDataGridView";
            this.workDataGridView.Size = new System.Drawing.Size(886, 356);
            this.workDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ProcessID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ProcessID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "WorkStartDate";
            this.dataGridViewTextBoxColumn21.HeaderText = "WorkStartDate";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "WorkFinishDate";
            this.dataGridViewTextBoxColumn22.HeaderText = "WorkFinishDate";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "WorkNameID";
            this.dataGridViewTextBoxColumn23.HeaderText = "WorkNameID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn24.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ComplateRate";
            this.dataGridViewTextBoxColumn25.HeaderText = "ComplateRate";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Analiz";
            this.dataGridViewTextBoxColumn26.HeaderText = "Analiz";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Tablo";
            this.dataGridViewTextBoxColumn27.HeaderText = "Tablo";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Arayüz";
            this.dataGridViewTextBoxColumn28.HeaderText = "Arayüz";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Test";
            this.dataGridViewTextBoxColumn29.HeaderText = "Test";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // tbIsSureci
            // 
            this.tbIsSureci.AutoScroll = true;
            this.tbIsSureci.Controls.Add(this.pictureBox5);
            this.tbIsSureci.Controls.Add(this.processBindingNavigator);
            this.tbIsSureci.Controls.Add(this.processNameTextBox);
            this.tbIsSureci.Controls.Add(this.durationTextBox);
            this.tbIsSureci.Controls.Add(this.complateRateTextBox);
            this.tbIsSureci.Controls.Add(this.priorityTextBox);
            this.tbIsSureci.Controls.Add(this.notesTextBox);
            this.tbIsSureci.Controls.Add(processNameLabel);
            this.tbIsSureci.Controls.Add(startDateLabel1);
            this.tbIsSureci.Controls.Add(this.startDateDateTimePicker1);
            this.tbIsSureci.Controls.Add(finishDateLabel1);
            this.tbIsSureci.Controls.Add(this.finishDateDateTimePicker1);
            this.tbIsSureci.Controls.Add(durationLabel);
            this.tbIsSureci.Controls.Add(complateRateLabel);
            this.tbIsSureci.Controls.Add(priorityLabel);
            this.tbIsSureci.Controls.Add(notesLabel);
            this.tbIsSureci.Controls.Add(this.processDataGridView);
            this.tbIsSureci.Location = new System.Drawing.Point(4, 22);
            this.tbIsSureci.Name = "tbIsSureci";
            this.tbIsSureci.Padding = new System.Windows.Forms.Padding(3);
            this.tbIsSureci.Size = new System.Drawing.Size(1126, 408);
            this.tbIsSureci.TabIndex = 3;
            this.tbIsSureci.Text = "İş Süreci İşlemleri";
            this.tbIsSureci.UseVisualStyleBackColor = true;
            // 
            // processBindingNavigator
            // 
            this.processBindingNavigator.AddNewItem = this.toolStripButton9;
            this.processBindingNavigator.BindingSource = this.processBindingSource;
            this.processBindingNavigator.CountItem = this.toolStripLabel2;
            this.processBindingNavigator.DeleteItem = this.toolStripButton10;
            this.processBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator6,
            this.toolStripButton9,
            this.toolStripButton10,
            this.processBindingNavigatorSaveItem});
            this.processBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.processBindingNavigator.MoveFirstItem = this.toolStripButton11;
            this.processBindingNavigator.MoveLastItem = this.toolStripButton14;
            this.processBindingNavigator.MoveNextItem = this.toolStripButton13;
            this.processBindingNavigator.MovePreviousItem = this.toolStripButton12;
            this.processBindingNavigator.Name = "processBindingNavigator";
            this.processBindingNavigator.PositionItem = this.toolStripTextBox2;
            this.processBindingNavigator.Size = new System.Drawing.Size(1120, 25);
            this.processBindingNavigator.TabIndex = 27;
            this.processBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Delete";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move first";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move next";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // processBindingNavigatorSaveItem
            // 
            this.processBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("processBindingNavigatorSaveItem.Image")));
            this.processBindingNavigatorSaveItem.Name = "processBindingNavigatorSaveItem";
            this.processBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.processBindingNavigatorSaveItem.Text = "Save Data";
            this.processBindingNavigatorSaveItem.Click += new System.EventHandler(this.processBindingNavigatorSaveItem_Click);
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processBindingSource, "ProcessName", true));
            this.processNameTextBox.Location = new System.Drawing.Point(92, 39);
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.processNameTextBox.TabIndex = 4;
            this.processNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.processNameTextBox_KeyPress);
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(92, 115);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(118, 20);
            this.durationTextBox.TabIndex = 12;
            this.durationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationTextBox_KeyPress);
            // 
            // complateRateTextBox
            // 
            this.complateRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processBindingSource, "ComplateRate", true));
            this.complateRateTextBox.Location = new System.Drawing.Point(92, 141);
            this.complateRateTextBox.Name = "complateRateTextBox";
            this.complateRateTextBox.Size = new System.Drawing.Size(118, 20);
            this.complateRateTextBox.TabIndex = 14;
            this.complateRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.complateRateTextBox_KeyPress);
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(92, 167);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(118, 20);
            this.priorityTextBox.TabIndex = 16;
            this.priorityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priorityTextBox_KeyPress);
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(92, 196);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(118, 20);
            this.notesTextBox.TabIndex = 20;
            this.notesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notesTextBox_KeyPress);
            // 
            // startDateDateTimePicker1
            // 
            this.startDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processBindingSource, "StartDate", true));
            this.startDateDateTimePicker1.Location = new System.Drawing.Point(92, 65);
            this.startDateDateTimePicker1.Name = "startDateDateTimePicker1";
            this.startDateDateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.startDateDateTimePicker1.TabIndex = 8;
            // 
            // finishDateDateTimePicker1
            // 
            this.finishDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processBindingSource, "FinishDate", true));
            this.finishDateDateTimePicker1.Location = new System.Drawing.Point(92, 91);
            this.finishDateDateTimePicker1.Name = "finishDateDateTimePicker1";
            this.finishDateDateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.finishDateDateTimePicker1.TabIndex = 10;
            // 
            // processDataGridView
            // 
            this.processDataGridView.AutoGenerateColumns = false;
            this.processDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.processDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn20});
            this.processDataGridView.DataSource = this.processBindingSource;
            this.processDataGridView.Location = new System.Drawing.Point(218, 39);
            this.processDataGridView.Name = "processDataGridView";
            this.processDataGridView.Size = new System.Drawing.Size(841, 361);
            this.processDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProcessID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ProcessID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProcessName";
            this.dataGridViewTextBoxColumn12.HeaderText = "ProcessName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FinishDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "FinishDate";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn16.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ComplateRate";
            this.dataGridViewTextBoxColumn17.HeaderText = "ComplateRate";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Priority";
            this.dataGridViewTextBoxColumn18.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn20.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // tbYonetici
            // 
            this.tbYonetici.BackColor = System.Drawing.Color.White;
            this.tbYonetici.Controls.Add(this.pictureBox4);
            this.tbYonetici.Controls.Add(this.btnIsSureciEkle);
            this.tbYonetici.Controls.Add(this.bindingNavigator1);
            this.tbYonetici.Controls.Add(this.projectDataGridView1);
            this.tbYonetici.Location = new System.Drawing.Point(4, 22);
            this.tbYonetici.Name = "tbYonetici";
            this.tbYonetici.Padding = new System.Windows.Forms.Padding(3);
            this.tbYonetici.Size = new System.Drawing.Size(1126, 408);
            this.tbYonetici.TabIndex = 2;
            this.tbYonetici.Text = "Yönetici İşlemleri";
            // 
            // btnIsSureciEkle
            // 
            this.btnIsSureciEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIsSureciEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIsSureciEkle.Location = new System.Drawing.Point(50, 53);
            this.btnIsSureciEkle.Name = "btnIsSureciEkle";
            this.btnIsSureciEkle.Size = new System.Drawing.Size(158, 59);
            this.btnIsSureciEkle.TabIndex = 19;
            this.btnIsSureciEkle.Text = "İş Süreci Ekle";
            this.btnIsSureciEkle.UseVisualStyleBackColor = false;
            this.btnIsSureciEkle.Click += new System.EventHandler(this.btnIsSureciEkle_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.projectBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripButton8});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1120, 25);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // projectDataGridView1
            // 
            this.projectDataGridView1.AutoGenerateColumns = false;
            this.projectDataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.projectDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10});
            this.projectDataGridView1.DataSource = this.projectBindingSource;
            this.projectDataGridView1.Location = new System.Drawing.Point(269, 41);
            this.projectDataGridView1.Name = "projectDataGridView1";
            this.projectDataGridView1.Size = new System.Drawing.Size(642, 359);
            this.projectDataGridView1.TabIndex = 0;
            this.projectDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProjectID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProjectID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProjectName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FinishDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "FinishDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Budget";
            this.dataGridViewTextBoxColumn10.HeaderText = "Budget";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tbMusteriIslemleri
            // 
            this.tbMusteriIslemleri.Controls.Add(this.grpBoxProjeEkle);
            this.tbMusteriIslemleri.Controls.Add(this.projectBindingNavigator);
            this.tbMusteriIslemleri.Controls.Add(this.projectDataGridView);
            this.tbMusteriIslemleri.Location = new System.Drawing.Point(4, 22);
            this.tbMusteriIslemleri.Name = "tbMusteriIslemleri";
            this.tbMusteriIslemleri.Padding = new System.Windows.Forms.Padding(3);
            this.tbMusteriIslemleri.Size = new System.Drawing.Size(1126, 408);
            this.tbMusteriIslemleri.TabIndex = 1;
            this.tbMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.tbMusteriIslemleri.UseVisualStyleBackColor = true;
            // 
            // grpBoxProjeEkle
            // 
            this.grpBoxProjeEkle.Controls.Add(this.pictureBox3);
            this.grpBoxProjeEkle.Controls.Add(projectNameLabel);
            this.grpBoxProjeEkle.Controls.Add(this.budgetTextBox);
            this.grpBoxProjeEkle.Controls.Add(budgetLabel);
            this.grpBoxProjeEkle.Controls.Add(this.projectNameTextBox);
            this.grpBoxProjeEkle.Controls.Add(this.isActiveCheckBox);
            this.grpBoxProjeEkle.Controls.Add(startDateLabel);
            this.grpBoxProjeEkle.Controls.Add(isActiveLabel);
            this.grpBoxProjeEkle.Controls.Add(this.startDateDateTimePicker);
            this.grpBoxProjeEkle.Controls.Add(this.finishDateDateTimePicker);
            this.grpBoxProjeEkle.Controls.Add(finishDateLabel);
            this.grpBoxProjeEkle.Location = new System.Drawing.Point(25, 51);
            this.grpBoxProjeEkle.Name = "grpBoxProjeEkle";
            this.grpBoxProjeEkle.Size = new System.Drawing.Size(341, 349);
            this.grpBoxProjeEkle.TabIndex = 18;
            this.grpBoxProjeEkle.TabStop = false;
            this.grpBoxProjeEkle.Text = "Proje Ekleme İşlemleri";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Budget", true));
            this.budgetTextBox.Location = new System.Drawing.Point(97, 159);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(192, 20);
            this.budgetTextBox.TabIndex = 12;
            this.budgetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budgetTextBox_KeyPress);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(97, 47);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.projectNameTextBox.TabIndex = 4;
            this.projectNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.projectNameTextBox_KeyPress);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.projectBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(97, 129);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(192, 30);
            this.isActiveCheckBox.TabIndex = 10;
            this.isActiveCheckBox.Text = "True/False";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(97, 77);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.startDateDateTimePicker.TabIndex = 6;
            // 
            // finishDateDateTimePicker
            // 
            this.finishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectBindingSource, "FinishDate", true));
            this.finishDateDateTimePicker.Location = new System.Drawing.Point(97, 103);
            this.finishDateDateTimePicker.Name = "finishDateDateTimePicker";
            this.finishDateDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.finishDateDateTimePicker.TabIndex = 8;
            // 
            // projectBindingNavigator
            // 
            this.projectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.projectBindingNavigator.BindingSource = this.projectBindingSource;
            this.projectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.projectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.projectBindingNavigatorSaveItem});
            this.projectBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.projectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projectBindingNavigator.Name = "projectBindingNavigator";
            this.projectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projectBindingNavigator.Size = new System.Drawing.Size(1120, 25);
            this.projectBindingNavigator.TabIndex = 17;
            this.projectBindingNavigator.Text = "bindingNavigator1";
            this.projectBindingNavigator.RefreshItems += new System.EventHandler(this.projectBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // projectBindingNavigatorSaveItem
            // 
            this.projectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projectBindingNavigatorSaveItem.Image")));
            this.projectBindingNavigatorSaveItem.Name = "projectBindingNavigatorSaveItem";
            this.projectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.projectBindingNavigatorSaveItem.Text = "Save Data";
            this.projectBindingNavigatorSaveItem.Click += new System.EventHandler(this.projectBindingNavigatorSaveItem_Click);
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AutoGenerateColumns = false;
            this.projectDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.projectDataGridView.DataSource = this.projectBindingSource;
            this.projectDataGridView.Location = new System.Drawing.Point(402, 51);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.Size = new System.Drawing.Size(643, 349);
            this.projectDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProjectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProjectID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProjectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FinishDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "FinishDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Budget";
            this.dataGridViewTextBoxColumn5.HeaderText = "Budget";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tbGiris
            // 
            this.tbGiris.Controls.Add(this.pictureBox2);
            this.tbGiris.Controls.Add(this.pictureBox1);
            this.tbGiris.Controls.Add(this.grpBoxMusteri);
            this.tbGiris.Controls.Add(this.grpBoxYonetici);
            this.tbGiris.Location = new System.Drawing.Point(4, 22);
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.Padding = new System.Windows.Forms.Padding(3);
            this.tbGiris.Size = new System.Drawing.Size(1126, 408);
            this.tbGiris.TabIndex = 0;
            this.tbGiris.Text = "Giriş";
            this.tbGiris.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(431, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxMusteri
            // 
            this.grpBoxMusteri.Controls.Add(this.lblMusteriKullaniciAdi);
            this.grpBoxMusteri.Controls.Add(this.txtMusteriKulAd);
            this.grpBoxMusteri.Controls.Add(this.lblMusteriSifre);
            this.grpBoxMusteri.Controls.Add(this.btnMusteriGiris);
            this.grpBoxMusteri.Controls.Add(this.txtMusteriSifre);
            this.grpBoxMusteri.Location = new System.Drawing.Point(583, 129);
            this.grpBoxMusteri.Name = "grpBoxMusteri";
            this.grpBoxMusteri.Size = new System.Drawing.Size(273, 150);
            this.grpBoxMusteri.TabIndex = 19;
            this.grpBoxMusteri.TabStop = false;
            this.grpBoxMusteri.Text = "Müşteri Girişi";
            // 
            // lblMusteriKullaniciAdi
            // 
            this.lblMusteriKullaniciAdi.AutoSize = true;
            this.lblMusteriKullaniciAdi.Location = new System.Drawing.Point(15, 33);
            this.lblMusteriKullaniciAdi.Name = "lblMusteriKullaniciAdi";
            this.lblMusteriKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblMusteriKullaniciAdi.TabIndex = 2;
            this.lblMusteriKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtMusteriKulAd
            // 
            this.txtMusteriKulAd.Location = new System.Drawing.Point(98, 28);
            this.txtMusteriKulAd.Name = "txtMusteriKulAd";
            this.txtMusteriKulAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriKulAd.TabIndex = 6;
            // 
            // lblMusteriSifre
            // 
            this.lblMusteriSifre.AutoSize = true;
            this.lblMusteriSifre.Location = new System.Drawing.Point(15, 62);
            this.lblMusteriSifre.Name = "lblMusteriSifre";
            this.lblMusteriSifre.Size = new System.Drawing.Size(31, 13);
            this.lblMusteriSifre.TabIndex = 3;
            this.lblMusteriSifre.Text = "Şifre:";
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.Location = new System.Drawing.Point(123, 102);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriGiris.TabIndex = 9;
            this.btnMusteriGiris.Text = "Giriş";
            this.btnMusteriGiris.UseVisualStyleBackColor = true;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(98, 62);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.PasswordChar = '*';
            this.txtMusteriSifre.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSifre.TabIndex = 7;
            // 
            // grpBoxYonetici
            // 
            this.grpBoxYonetici.Controls.Add(this.txtYoneticiAd);
            this.grpBoxYonetici.Controls.Add(this.lblYoneticiKullaniciAdi);
            this.grpBoxYonetici.Controls.Add(this.btnYoneticiGiris);
            this.grpBoxYonetici.Controls.Add(this.lblYoneticiSifre);
            this.grpBoxYonetici.Controls.Add(this.txtYoneticiSifre);
            this.grpBoxYonetici.Location = new System.Drawing.Point(172, 129);
            this.grpBoxYonetici.Name = "grpBoxYonetici";
            this.grpBoxYonetici.Size = new System.Drawing.Size(230, 150);
            this.grpBoxYonetici.TabIndex = 18;
            this.grpBoxYonetici.TabStop = false;
            this.grpBoxYonetici.Text = "Yönetici Girişi";
            // 
            // txtYoneticiAd
            // 
            this.txtYoneticiAd.Location = new System.Drawing.Point(87, 27);
            this.txtYoneticiAd.Name = "txtYoneticiAd";
            this.txtYoneticiAd.Size = new System.Drawing.Size(100, 20);
            this.txtYoneticiAd.TabIndex = 4;
            // 
            // lblYoneticiKullaniciAdi
            // 
            this.lblYoneticiKullaniciAdi.AutoSize = true;
            this.lblYoneticiKullaniciAdi.Location = new System.Drawing.Point(6, 30);
            this.lblYoneticiKullaniciAdi.Name = "lblYoneticiKullaniciAdi";
            this.lblYoneticiKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblYoneticiKullaniciAdi.TabIndex = 0;
            this.lblYoneticiKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Location = new System.Drawing.Point(112, 113);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(75, 23);
            this.btnYoneticiGiris.TabIndex = 8;
            this.btnYoneticiGiris.Text = "Giriş";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Location = new System.Drawing.Point(6, 57);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(31, 13);
            this.lblYoneticiSifre.TabIndex = 1;
            this.lblYoneticiSifre.Text = "Şifre:";
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.Location = new System.Drawing.Point(87, 57);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.PasswordChar = '*';
            this.txtYoneticiSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYoneticiSifre.TabIndex = 5;
            // 
            // tbProjeYonetimAraci
            // 
            this.tbProjeYonetimAraci.Controls.Add(this.tbGiris);
            this.tbProjeYonetimAraci.Controls.Add(this.tbMusteriIslemleri);
            this.tbProjeYonetimAraci.Controls.Add(this.tbYonetici);
            this.tbProjeYonetimAraci.Controls.Add(this.tbIsSureci);
            this.tbProjeYonetimAraci.Controls.Add(this.tbIsDetaylandirma);
            this.tbProjeYonetimAraci.Controls.Add(this.tbRapor);
            this.tbProjeYonetimAraci.Location = new System.Drawing.Point(0, 0);
            this.tbProjeYonetimAraci.Name = "tbProjeYonetimAraci";
            this.tbProjeYonetimAraci.SelectedIndex = 0;
            this.tbProjeYonetimAraci.Size = new System.Drawing.Size(1134, 434);
            this.tbProjeYonetimAraci.TabIndex = 0;
            // 
            // tbRapor
            // 
            this.tbRapor.Controls.Add(this.reportViewer1);
            this.tbRapor.Location = new System.Drawing.Point(4, 22);
            this.tbRapor.Name = "tbRapor";
            this.tbRapor.Padding = new System.Windows.Forms.Padding(3);
            this.tbRapor.Size = new System.Drawing.Size(1126, 408);
            this.tbRapor.TabIndex = 6;
            this.tbRapor.Text = "Rapor";
            this.tbRapor.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.workBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YazılımSınamaProje.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1120, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 236);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 222);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(194, 166);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 283);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 119);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // frmProjeYonetimAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 434);
            this.Controls.Add(this.tbProjeYonetimAraci);
            this.Name = "frmProjeYonetimAraci";
            this.Text = "Proje Yönetim Aracı";
            this.Load += new System.EventHandler(this.frmProjeYonetimAraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYazilimTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.tbIsDetaylandirma.ResumeLayout(false);
            this.tbIsDetaylandirma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingNavigator)).EndInit();
            this.workBindingNavigator.ResumeLayout(false);
            this.workBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).EndInit();
            this.tbIsSureci.ResumeLayout(false);
            this.tbIsSureci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingNavigator)).EndInit();
            this.processBindingNavigator.ResumeLayout(false);
            this.processBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGridView)).EndInit();
            this.tbYonetici.ResumeLayout(false);
            this.tbYonetici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView1)).EndInit();
            this.tbMusteriIslemleri.ResumeLayout(false);
            this.tbMusteriIslemleri.PerformLayout();
            this.grpBoxProjeEkle.ResumeLayout(false);
            this.grpBoxProjeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingNavigator)).EndInit();
            this.projectBindingNavigator.ResumeLayout(false);
            this.projectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.tbGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxMusteri.ResumeLayout(false);
            this.grpBoxMusteri.PerformLayout();
            this.grpBoxYonetici.ResumeLayout(false);
            this.grpBoxYonetici.PerformLayout();
            this.tbProjeYonetimAraci.ResumeLayout(false);
            this.tbRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbYazilimTestDataSet dbYazilimTestDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private dbYazilimTestDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private dbYazilimTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource processBindingSource;
        private dbYazilimTestDataSetTableAdapters.ProcessTableAdapter processTableAdapter;
        private System.Windows.Forms.BindingSource workBindingSource;
        private dbYazilimTestDataSetTableAdapters.WorkTableAdapter workTableAdapter;
        private System.Windows.Forms.TabPage tbIsDetaylandirma;
        private System.Windows.Forms.TextBox workNameIDTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox complateRateTextBox1;
        private System.Windows.Forms.TextBox analizTextBox;
        private System.Windows.Forms.TextBox tabloTextBox;
        private System.Windows.Forms.TextBox arayüzTextBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.DateTimePicker workStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker workFinishDateDateTimePicker;
        private System.Windows.Forms.DataGridView workDataGridView;
        private System.Windows.Forms.TabPage tbIsSureci;
        private System.Windows.Forms.BindingNavigator processBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton processBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox complateRateTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker1;
        private System.Windows.Forms.DateTimePicker finishDateDateTimePicker1;
        private System.Windows.Forms.DataGridView processDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.TabPage tbYonetici;
        private System.Windows.Forms.Button btnIsSureciEkle;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.DataGridView projectDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tbMusteriIslemleri;
        private System.Windows.Forms.GroupBox grpBoxProjeEkle;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker finishDateDateTimePicker;
        private System.Windows.Forms.BindingNavigator projectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton projectBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tbGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxMusteri;
        private System.Windows.Forms.Label lblMusteriKullaniciAdi;
        private System.Windows.Forms.TextBox txtMusteriKulAd;
        private System.Windows.Forms.Label lblMusteriSifre;
        private System.Windows.Forms.Button btnMusteriGiris;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.GroupBox grpBoxYonetici;
        private System.Windows.Forms.TextBox txtYoneticiAd;
        private System.Windows.Forms.Label lblYoneticiKullaniciAdi;
        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.Label lblYoneticiSifre;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.TabControl tbProjeYonetimAraci;
        private System.Windows.Forms.TabPage tbRapor;
        private System.Windows.Forms.BindingNavigator workBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton workBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnYazdir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}