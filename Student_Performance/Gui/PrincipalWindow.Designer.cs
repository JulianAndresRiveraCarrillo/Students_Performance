
namespace Student_Performance.Gui
{
    partial class PrincipalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWindow));
            this.loadBT = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OK3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.writingCheck = new System.Windows.Forms.CheckBox();
            this.readingCheck = new System.Windows.Forms.CheckBox();
            this.mathCheck = new System.Windows.Forms.CheckBox();
            this.OK2 = new System.Windows.Forms.Button();
            this.OK1 = new System.Windows.Forms.Button();
            this.testLB = new System.Windows.Forms.Label();
            this.lunchLB = new System.Windows.Forms.Label();
            this.testBox = new System.Windows.Forms.TextBox();
            this.lunchBox = new System.Windows.Forms.TextBox();
            this.parentBox = new System.Windows.Forms.ComboBox();
            this.etniBox = new System.Windows.Forms.ComboBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_arbol_propio = new System.Windows.Forms.Button();
            this.btn_arbol_libreria = new System.Windows.Forms.Button();
            this.comboBoxVariable1 = new System.Windows.Forms.ComboBox();
            this.comboBoxVariable2 = new System.Windows.Forms.ComboBox();
            this.comboBoxVariable3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.graphicControl = new Student_Performance.Gui.GraphicWindow();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBT
            // 
            this.loadBT.Image = ((System.Drawing.Image)(resources.GetObject("loadBT.Image")));
            this.loadBT.Location = new System.Drawing.Point(3, 4);
            this.loadBT.Name = "loadBT";
            this.loadBT.Size = new System.Drawing.Size(58, 59);
            this.loadBT.TabIndex = 1;
            this.loadBT.UseVisualStyleBackColor = true;
            this.loadBT.Click += new System.EventHandler(this.loadBT_Click);
            // 
            // loadData
            // 
            this.loadData.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 71);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadBT);
            this.panel1.Location = new System.Drawing.Point(155, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 65);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cargar Datos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBT);
            this.panel2.Location = new System.Drawing.Point(611, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 65);
            this.panel2.TabIndex = 2;
            // 
            // refreshBT
            // 
            this.refreshBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBT.Enabled = false;
            this.refreshBT.Image = ((System.Drawing.Image)(resources.GetObject("refreshBT.Image")));
            this.refreshBT.Location = new System.Drawing.Point(3, 2);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(60, 62);
            this.refreshBT.TabIndex = 1;
            this.refreshBT.UseVisualStyleBackColor = true;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(459, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 65);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limpiar Filtros:";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 125);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(760, 282);
            this.dataView.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphicControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graficar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OK3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.maxBox);
            this.tabPage1.Controls.Add(this.minBox);
            this.tabPage1.Controls.Add(this.writingCheck);
            this.tabPage1.Controls.Add(this.readingCheck);
            this.tabPage1.Controls.Add(this.mathCheck);
            this.tabPage1.Controls.Add(this.OK2);
            this.tabPage1.Controls.Add(this.OK1);
            this.tabPage1.Controls.Add(this.testLB);
            this.tabPage1.Controls.Add(this.lunchLB);
            this.tabPage1.Controls.Add(this.testBox);
            this.tabPage1.Controls.Add(this.lunchBox);
            this.tabPage1.Controls.Add(this.parentBox);
            this.tabPage1.Controls.Add(this.etniBox);
            this.tabPage1.Controls.Add(this.femaleButton);
            this.tabPage1.Controls.Add(this.maleButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OK3
            // 
            this.OK3.Enabled = false;
            this.OK3.Location = new System.Drawing.Point(629, 40);
            this.OK3.Name = "OK3";
            this.OK3.Size = new System.Drawing.Size(37, 19);
            this.OK3.TabIndex = 66;
            this.OK3.Text = "OK";
            this.OK3.UseVisualStyleBackColor = true;
            this.OK3.Click += new System.EventHandler(this.OK3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "--";
            // 
            // maxBox
            // 
            this.maxBox.Enabled = false;
            this.maxBox.Location = new System.Drawing.Point(672, 21);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(40, 20);
            this.maxBox.TabIndex = 64;
            // 
            // minBox
            // 
            this.minBox.Enabled = false;
            this.minBox.Location = new System.Drawing.Point(583, 21);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(40, 20);
            this.minBox.TabIndex = 63;
            // 
            // writingCheck
            // 
            this.writingCheck.AutoSize = true;
            this.writingCheck.Enabled = false;
            this.writingCheck.Location = new System.Drawing.Point(691, 2);
            this.writingCheck.Name = "writingCheck";
            this.writingCheck.Size = new System.Drawing.Size(59, 17);
            this.writingCheck.TabIndex = 62;
            this.writingCheck.Text = "Writing";
            this.writingCheck.UseVisualStyleBackColor = true;
            this.writingCheck.CheckedChanged += new System.EventHandler(this.writingCheck_CheckedChanged);
            // 
            // readingCheck
            // 
            this.readingCheck.AutoSize = true;
            this.readingCheck.Enabled = false;
            this.readingCheck.Location = new System.Drawing.Point(620, 2);
            this.readingCheck.Name = "readingCheck";
            this.readingCheck.Size = new System.Drawing.Size(66, 17);
            this.readingCheck.TabIndex = 61;
            this.readingCheck.Text = "Reading";
            this.readingCheck.UseVisualStyleBackColor = true;
            this.readingCheck.CheckedChanged += new System.EventHandler(this.readingCheck_CheckedChanged);
            // 
            // mathCheck
            // 
            this.mathCheck.AutoSize = true;
            this.mathCheck.Enabled = false;
            this.mathCheck.Location = new System.Drawing.Point(564, 2);
            this.mathCheck.Name = "mathCheck";
            this.mathCheck.Size = new System.Drawing.Size(50, 17);
            this.mathCheck.TabIndex = 60;
            this.mathCheck.Text = "Math";
            this.mathCheck.UseVisualStyleBackColor = true;
            this.mathCheck.CheckedChanged += new System.EventHandler(this.mathCheck_CheckedChanged);
            // 
            // OK2
            // 
            this.OK2.Enabled = false;
            this.OK2.Location = new System.Drawing.Point(494, 32);
            this.OK2.Name = "OK2";
            this.OK2.Size = new System.Drawing.Size(30, 21);
            this.OK2.TabIndex = 59;
            this.OK2.Text = "OK";
            this.OK2.UseVisualStyleBackColor = true;
            this.OK2.Click += new System.EventHandler(this.OK2_Click);
            // 
            // OK1
            // 
            this.OK1.Enabled = false;
            this.OK1.Location = new System.Drawing.Point(343, 32);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(30, 21);
            this.OK1.TabIndex = 58;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = true;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // testLB
            // 
            this.testLB.AutoSize = true;
            this.testLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLB.Location = new System.Drawing.Point(403, 36);
            this.testLB.Name = "testLB";
            this.testLB.Size = new System.Drawing.Size(85, 13);
            this.testLB.TabIndex = 57;
            this.testLB.Text = "Test Preparation";
            // 
            // lunchLB
            // 
            this.lunchLB.AutoSize = true;
            this.lunchLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchLB.Location = new System.Drawing.Point(290, 36);
            this.lunchLB.Name = "lunchLB";
            this.lunchLB.Size = new System.Drawing.Size(37, 13);
            this.lunchLB.TabIndex = 56;
            this.lunchLB.Text = "Lunch";
            // 
            // testBox
            // 
            this.testBox.Enabled = false;
            this.testBox.Location = new System.Drawing.Point(406, 6);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(118, 20);
            this.testBox.TabIndex = 55;
            this.testBox.TextChanged += new System.EventHandler(this.testBox_TextChanged);
            // 
            // lunchBox
            // 
            this.lunchBox.Enabled = false;
            this.lunchBox.Location = new System.Drawing.Point(270, 6);
            this.lunchBox.Name = "lunchBox";
            this.lunchBox.Size = new System.Drawing.Size(118, 20);
            this.lunchBox.TabIndex = 54;
            this.lunchBox.TextChanged += new System.EventHandler(this.lunchBox_TextChanged);
            // 
            // parentBox
            // 
            this.parentBox.Enabled = false;
            this.parentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBox.FormattingEnabled = true;
            this.parentBox.Items.AddRange(new object[] {
            "some college",
            "associate\'s degree",
            "high school",
            "some high school",
            "bachelor\'s degree"});
            this.parentBox.Location = new System.Drawing.Point(113, 33);
            this.parentBox.Name = "parentBox";
            this.parentBox.Size = new System.Drawing.Size(128, 21);
            this.parentBox.TabIndex = 53;
            this.parentBox.Text = "Parent Level";
            this.parentBox.SelectedIndexChanged += new System.EventHandler(this.parentBox_SelectedIndexChanged);
            // 
            // etniBox
            // 
            this.etniBox.Enabled = false;
            this.etniBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etniBox.FormattingEnabled = true;
            this.etniBox.Items.AddRange(new object[] {
            "group A",
            "group B",
            "group C",
            "group D",
            "group E"});
            this.etniBox.Location = new System.Drawing.Point(113, 8);
            this.etniBox.Name = "etniBox";
            this.etniBox.Size = new System.Drawing.Size(128, 21);
            this.etniBox.Sorted = true;
            this.etniBox.TabIndex = 51;
            this.etniBox.Text = "Race/ Ethnicity";
            this.etniBox.SelectedIndexChanged += new System.EventHandler(this.etniBox_SelectedIndexChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Enabled = false;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(6, 33);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(72, 20);
            this.femaleButton.TabIndex = 52;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.femaleButton_CheckedChanged);
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Checked = true;
            this.maleButton.Enabled = false;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.Location = new System.Drawing.Point(6, 8);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(56, 20);
            this.maleButton.TabIndex = 50;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.maleButton_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 118);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBoxVariable3);
            this.tabPage3.Controls.Add(this.comboBoxVariable2);
            this.tabPage3.Controls.Add(this.comboBoxVariable1);
            this.tabPage3.Controls.Add(this.btn_arbol_libreria);
            this.tabPage3.Controls.Add(this.btn_arbol_propio);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 92);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arboles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Implementación propia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Librería Accord.NET";
            // 
            // btn_arbol_propio
            // 
            this.btn_arbol_propio.Location = new System.Drawing.Point(588, 46);
            this.btn_arbol_propio.Name = "btn_arbol_propio";
            this.btn_arbol_propio.Size = new System.Drawing.Size(110, 23);
            this.btn_arbol_propio.TabIndex = 4;
            this.btn_arbol_propio.Text = "Generar Árbol";
            this.btn_arbol_propio.UseVisualStyleBackColor = true;
            this.btn_arbol_propio.Click += new System.EventHandler(this.btn_arbol_propio_Click);
            // 
            // btn_arbol_libreria
            // 
            this.btn_arbol_libreria.Location = new System.Drawing.Point(460, 45);
            this.btn_arbol_libreria.Name = "btn_arbol_libreria";
            this.btn_arbol_libreria.Size = new System.Drawing.Size(102, 23);
            this.btn_arbol_libreria.TabIndex = 5;
            this.btn_arbol_libreria.Text = "Generar Árbol";
            this.btn_arbol_libreria.UseVisualStyleBackColor = true;
            this.btn_arbol_libreria.Click += new System.EventHandler(this.btn_arbol_libreria_Click);
            // 
            // comboBoxVariable1
            // 
            this.comboBoxVariable1.FormattingEnabled = true;
            this.comboBoxVariable1.Items.AddRange(new object[] {
            "grupo A",
            "grupo B",
            "grupo C",
            "grupo D",
            "grupo E"});
            this.comboBoxVariable1.Location = new System.Drawing.Point(8, 63);
            this.comboBoxVariable1.Name = "comboBoxVariable1";
            this.comboBoxVariable1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariable1.TabIndex = 6;
            // 
            // comboBoxVariable2
            // 
            this.comboBoxVariable2.FormattingEnabled = true;
            this.comboBoxVariable2.Items.AddRange(new object[] {
            "standard",
            "free/reduced"});
            this.comboBoxVariable2.Location = new System.Drawing.Point(139, 62);
            this.comboBoxVariable2.Name = "comboBoxVariable2";
            this.comboBoxVariable2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariable2.TabIndex = 7;
            // 
            // comboBoxVariable3
            // 
            this.comboBoxVariable3.FormattingEnabled = true;
            this.comboBoxVariable3.Items.AddRange(new object[] {
            "completed",
            "none"});
            this.comboBoxVariable3.Location = new System.Drawing.Point(271, 62);
            this.comboBoxVariable3.Name = "comboBoxVariable3";
            this.comboBoxVariable3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariable3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "race/ethnicity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lunch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "test preparation course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Variables de entrada.";
            // 
            // graphicControl
            // 
            this.graphicControl.Location = new System.Drawing.Point(0, 0);
            this.graphicControl.Name = "graphicControl";
            this.graphicControl.Size = new System.Drawing.Size(756, 60);
            this.graphicControl.TabIndex = 0;
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 496);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalWindow";
            this.Text = "StudentPerformance ::SP";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadBT;
        private System.Windows.Forms.OpenFileDialog loadData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refreshBT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private GraphicWindow graphicControl;
        private System.Windows.Forms.Button OK3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.CheckBox writingCheck;
        private System.Windows.Forms.CheckBox readingCheck;
        private System.Windows.Forms.CheckBox mathCheck;
        private System.Windows.Forms.Button OK2;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Label testLB;
        private System.Windows.Forms.Label lunchLB;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.TextBox lunchBox;
        private System.Windows.Forms.ComboBox parentBox;
        private System.Windows.Forms.ComboBox etniBox;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_arbol_propio;
        private System.Windows.Forms.Button btn_arbol_libreria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVariable3;
        private System.Windows.Forms.ComboBox comboBoxVariable2;
        private System.Windows.Forms.ComboBox comboBoxVariable1;
    }
}