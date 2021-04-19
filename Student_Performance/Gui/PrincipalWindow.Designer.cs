
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.loadBT = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.OpenFileDialog();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.etniBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rep5BT = new System.Windows.Forms.Button();
            this.rep4BT = new System.Windows.Forms.Button();
            this.rep3BT = new System.Windows.Forms.Button();
            this.rep2BT = new System.Windows.Forms.Button();
            this.rep1BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Enabled = false;
            this.dataView.Location = new System.Drawing.Point(12, 93);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(764, 314);
            this.dataView.TabIndex = 0;
            // 
            // loadBT
            // 
            this.loadBT.Location = new System.Drawing.Point(30, 0);
            this.loadBT.Name = "loadBT";
            this.loadBT.Size = new System.Drawing.Size(88, 24);
            this.loadBT.TabIndex = 1;
            this.loadBT.Text = "Load DataSet";
            this.loadBT.UseVisualStyleBackColor = true;
            this.loadBT.Click += new System.EventHandler(this.loadBT_Click);
            // 
            // loadData
            // 
            this.loadData.FileName = "openFileDialog1";
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Enabled = false;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(6, 31);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(72, 20);
            this.femaleButton.TabIndex = 1;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.femaleButton_CheckedChanged);
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Enabled = false;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.Location = new System.Drawing.Point(6, 6);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(56, 20);
            this.maleButton.TabIndex = 0;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.maleButton_CheckedChanged);
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
            this.etniBox.Location = new System.Drawing.Point(113, 6);
            this.etniBox.Name = "etniBox";
            this.etniBox.Size = new System.Drawing.Size(128, 21);
            this.etniBox.Sorted = true;
            this.etniBox.TabIndex = 0;
            this.etniBox.Text = "Race/ Ethnicity";
            this.etniBox.SelectedIndexChanged += new System.EventHandler(this.etniBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadBT);
            this.panel1.Location = new System.Drawing.Point(307, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 24);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 86);
            this.tabControl1.TabIndex = 5;
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
            this.tabPage1.Size = new System.Drawing.Size(756, 60);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OK3
            // 
            this.OK3.Enabled = false;
            this.OK3.Location = new System.Drawing.Point(629, 38);
            this.OK3.Name = "OK3";
            this.OK3.Size = new System.Drawing.Size(37, 19);
            this.OK3.TabIndex = 15;
            this.OK3.Text = "OK";
            this.OK3.UseVisualStyleBackColor = true;
            this.OK3.Click += new System.EventHandler(this.OK3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "--";
            // 
            // maxBox
            // 
            this.maxBox.Enabled = false;
            this.maxBox.Location = new System.Drawing.Point(672, 19);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(40, 20);
            this.maxBox.TabIndex = 13;
            // 
            // minBox
            // 
            this.minBox.Enabled = false;
            this.minBox.Location = new System.Drawing.Point(583, 19);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(40, 20);
            this.minBox.TabIndex = 12;
            // 
            // writingCheck
            // 
            this.writingCheck.AutoSize = true;
            this.writingCheck.Enabled = false;
            this.writingCheck.Location = new System.Drawing.Point(691, 0);
            this.writingCheck.Name = "writingCheck";
            this.writingCheck.Size = new System.Drawing.Size(59, 17);
            this.writingCheck.TabIndex = 11;
            this.writingCheck.Text = "Writing";
            this.writingCheck.UseVisualStyleBackColor = true;
            this.writingCheck.CheckedChanged += new System.EventHandler(this.writingCheck_CheckedChanged);
            // 
            // readingCheck
            // 
            this.readingCheck.AutoSize = true;
            this.readingCheck.Enabled = false;
            this.readingCheck.Location = new System.Drawing.Point(620, 0);
            this.readingCheck.Name = "readingCheck";
            this.readingCheck.Size = new System.Drawing.Size(66, 17);
            this.readingCheck.TabIndex = 10;
            this.readingCheck.Text = "Reading";
            this.readingCheck.UseVisualStyleBackColor = true;
            this.readingCheck.CheckedChanged += new System.EventHandler(this.readingChech_CheckedChanged);
            // 
            // mathCheck
            // 
            this.mathCheck.AutoSize = true;
            this.mathCheck.Enabled = false;
            this.mathCheck.Location = new System.Drawing.Point(564, 0);
            this.mathCheck.Name = "mathCheck";
            this.mathCheck.Size = new System.Drawing.Size(50, 17);
            this.mathCheck.TabIndex = 9;
            this.mathCheck.Text = "Math";
            this.mathCheck.UseVisualStyleBackColor = true;
            this.mathCheck.CheckedChanged += new System.EventHandler(this.mathCheck_CheckedChanged);
            // 
            // OK2
            // 
            this.OK2.Enabled = false;
            this.OK2.Location = new System.Drawing.Point(494, 30);
            this.OK2.Name = "OK2";
            this.OK2.Size = new System.Drawing.Size(30, 21);
            this.OK2.TabIndex = 8;
            this.OK2.Text = "OK";
            this.OK2.UseVisualStyleBackColor = true;
            this.OK2.Click += new System.EventHandler(this.OK2_Click);
            // 
            // OK1
            // 
            this.OK1.Enabled = false;
            this.OK1.Location = new System.Drawing.Point(343, 30);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(30, 21);
            this.OK1.TabIndex = 7;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = true;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // testLB
            // 
            this.testLB.AutoSize = true;
            this.testLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLB.Location = new System.Drawing.Point(403, 34);
            this.testLB.Name = "testLB";
            this.testLB.Size = new System.Drawing.Size(85, 13);
            this.testLB.TabIndex = 6;
            this.testLB.Text = "Test Preparation";
            // 
            // lunchLB
            // 
            this.lunchLB.AutoSize = true;
            this.lunchLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchLB.Location = new System.Drawing.Point(290, 34);
            this.lunchLB.Name = "lunchLB";
            this.lunchLB.Size = new System.Drawing.Size(37, 13);
            this.lunchLB.TabIndex = 5;
            this.lunchLB.Text = "Lunch";
            // 
            // testBox
            // 
            this.testBox.Enabled = false;
            this.testBox.Location = new System.Drawing.Point(406, 4);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(118, 20);
            this.testBox.TabIndex = 4;
            this.testBox.TextChanged += new System.EventHandler(this.testBox_TextChanged);
            // 
            // lunchBox
            // 
            this.lunchBox.Enabled = false;
            this.lunchBox.Location = new System.Drawing.Point(270, 4);
            this.lunchBox.Name = "lunchBox";
            this.lunchBox.Size = new System.Drawing.Size(118, 20);
            this.lunchBox.TabIndex = 3;
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
            this.parentBox.Location = new System.Drawing.Point(113, 31);
            this.parentBox.Name = "parentBox";
            this.parentBox.Size = new System.Drawing.Size(128, 21);
            this.parentBox.TabIndex = 2;
            this.parentBox.Text = "Paren Level";
            this.parentBox.SelectedIndexChanged += new System.EventHandler(this.parentBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rep5BT);
            this.tabPage2.Controls.Add(this.rep4BT);
            this.tabPage2.Controls.Add(this.rep3BT);
            this.tabPage2.Controls.Add(this.rep2BT);
            this.tabPage2.Controls.Add(this.rep1BT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graficar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rep5BT
            // 
            this.rep5BT.Enabled = false;
            this.rep5BT.Location = new System.Drawing.Point(610, 18);
            this.rep5BT.Name = "rep5BT";
            this.rep5BT.Size = new System.Drawing.Size(75, 23);
            this.rep5BT.TabIndex = 4;
            this.rep5BT.Text = "Reporte 5";
            this.rep5BT.UseVisualStyleBackColor = true;
            this.rep5BT.Click += new System.EventHandler(this.rep5BT_Click);
            // 
            // rep4BT
            // 
            this.rep4BT.Enabled = false;
            this.rep4BT.Location = new System.Drawing.Point(476, 18);
            this.rep4BT.Name = "rep4BT";
            this.rep4BT.Size = new System.Drawing.Size(75, 23);
            this.rep4BT.TabIndex = 3;
            this.rep4BT.Text = "Reporte 4";
            this.rep4BT.UseVisualStyleBackColor = true;
            this.rep4BT.Click += new System.EventHandler(this.rep4BT_Click);
            // 
            // rep3BT
            // 
            this.rep3BT.Enabled = false;
            this.rep3BT.Location = new System.Drawing.Point(333, 18);
            this.rep3BT.Name = "rep3BT";
            this.rep3BT.Size = new System.Drawing.Size(75, 23);
            this.rep3BT.TabIndex = 2;
            this.rep3BT.Text = "Reporte 3";
            this.rep3BT.UseVisualStyleBackColor = true;
            this.rep3BT.Click += new System.EventHandler(this.rep3BT_Click);
            // 
            // rep2BT
            // 
            this.rep2BT.Enabled = false;
            this.rep2BT.Location = new System.Drawing.Point(195, 18);
            this.rep2BT.Name = "rep2BT";
            this.rep2BT.Size = new System.Drawing.Size(75, 23);
            this.rep2BT.TabIndex = 1;
            this.rep2BT.Text = "Reporte 2";
            this.rep2BT.UseVisualStyleBackColor = true;
            this.rep2BT.Click += new System.EventHandler(this.rep2BT_Click);
            // 
            // rep1BT
            // 
            this.rep1BT.Enabled = false;
            this.rep1BT.Location = new System.Drawing.Point(55, 18);
            this.rep1BT.Name = "rep1BT";
            this.rep1BT.Size = new System.Drawing.Size(75, 23);
            this.rep1BT.TabIndex = 0;
            this.rep1BT.Text = "Reporte 1";
            this.rep1BT.UseVisualStyleBackColor = true;
            this.rep1BT.Click += new System.EventHandler(this.rep1BT_Click);
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalWindow";
            this.Text = "PrincipalWindow ::PW";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button loadBT;
        private System.Windows.Forms.OpenFileDialog loadData;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox etniBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox parentBox;
        private System.Windows.Forms.Label testLB;
        private System.Windows.Forms.Label lunchLB;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.TextBox lunchBox;
        private System.Windows.Forms.Button OK2;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.CheckBox writingCheck;
        private System.Windows.Forms.CheckBox readingCheck;
        private System.Windows.Forms.CheckBox mathCheck;
        private System.Windows.Forms.Button OK3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Button rep5BT;
        private System.Windows.Forms.Button rep4BT;
        private System.Windows.Forms.Button rep3BT;
        private System.Windows.Forms.Button rep2BT;
        private System.Windows.Forms.Button rep1BT;
    }
}