using System;
using System.Data;
using System.Windows.Forms;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class PrincipalWindow : Form
    {
        private DataManager  manager = new DataManager();
        public static string file;

        public String File
        {
            get => file;
        }

        public PrincipalWindow()
        {
            InitializeComponent();
            
        }

        private void loadBT_Click(object sender, EventArgs e)
        {
            loadData.ShowDialog();
            string path = loadData.FileName;
            file = path;
            manager.createTable(path);

            if (manager.Table != null)
            {
                dataView.DataSource = manager.Table;
                filterControl.buttonEnable();
                graphicControl.buttonEnable();
            }
            
            filterControl.setFile(file);
            graphicControl.setFile(file);

            loadBT.Enabled = false;
            refreshBT.Enabled = true;
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
           // manager.refreshTable();
        }
    }
}
