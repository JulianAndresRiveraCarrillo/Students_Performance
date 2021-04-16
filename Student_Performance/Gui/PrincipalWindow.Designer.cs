
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.parentBox = new System.Windows.Forms.ComboBox();
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
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(3, 32);
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
            this.etniBox.FormattingEnabled = true;
            this.etniBox.Items.AddRange(new object[] {
            "group A",
            "group B",
            "group C",
            "group D",
            "group E"});
            this.etniBox.Location = new System.Drawing.Point(93, 7);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graficar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui se incluirá la funcion para reportes graficos";
            // 
            // parentBox
            // 
            this.parentBox.FormattingEnabled = true;
            this.parentBox.Items.AddRange(new object[] {
            "some college",
            "associate\'s degree",
            "high school",
            "some high school",
            "bachelor\'s degree"});
            this.parentBox.Location = new System.Drawing.Point(93, 30);
            this.parentBox.Name = "parentBox";
            this.parentBox.Size = new System.Drawing.Size(128, 21);
            this.parentBox.TabIndex = 2;
            this.parentBox.Text = "Paren Level";
            this.parentBox.SelectedIndexChanged += new System.EventHandler(this.parentBox_SelectedIndexChanged);
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataView);
            this.Name = "PrincipalWindow";
            this.Text = "PrincipalWindow ::PW";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox parentBox;
    }
}