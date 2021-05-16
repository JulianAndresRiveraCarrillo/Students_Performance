
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBT = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphicControl = new Student_Performance.Gui.GraphicWindow();
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
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBT
            // 
            this.loadBT.Location = new System.Drawing.Point(32, 21);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 3, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBT);
            this.panel2.Location = new System.Drawing.Point(459, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 65);
            this.panel2.TabIndex = 2;
            // 
            // refreshBT
            // 
            this.refreshBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBT.Enabled = false;
            this.refreshBT.Image = ((System.Drawing.Image)(resources.GetObject("refreshBT.Image")));
            this.refreshBT.Location = new System.Drawing.Point(49, 3);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(60, 62);
            this.refreshBT.TabIndex = 1;
            this.refreshBT.UseVisualStyleBackColor = true;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 93);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(760, 314);
            this.dataView.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphicControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graficar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphicControl
            // 
            this.graphicControl.Location = new System.Drawing.Point(0, 0);
            this.graphicControl.Name = "graphicControl";
            this.graphicControl.Size = new System.Drawing.Size(756, 60);
            this.graphicControl.TabIndex = 0;
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
            this.parentBox.Text = "Paren Level";
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
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 86);
            this.tabControl1.TabIndex = 5;
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
            this.Text = "PrincipalWindow ::PW";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
    }
}