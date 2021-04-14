
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterControl1 = new Student_Performance.Gui.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 65);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(611, 291);
            this.dataView.TabIndex = 0;
            // 
            // loadBT
            // 
            this.loadBT.Location = new System.Drawing.Point(270, 3);
            this.loadBT.Name = "loadBT";
            this.loadBT.Size = new System.Drawing.Size(88, 30);
            this.loadBT.TabIndex = 1;
            this.loadBT.Text = "Load DataSet";
            this.loadBT.UseVisualStyleBackColor = true;
            this.loadBT.Click += new System.EventHandler(this.loadBT_Click);
            // 
            // loadData
            // 
            this.loadData.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 36);
            this.panel1.TabIndex = 2;
            // 
            // filterControl1
            // 
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(635, 59);
            this.filterControl1.TabIndex = 3;
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 398);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.Name = "PrincipalWindow";
            this.Text = "PrincipalWindo";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button loadBT;
        private System.Windows.Forms.OpenFileDialog loadData;
        private System.Windows.Forms.Panel panel1;
        private FilterControl filterControl1;
    }
}