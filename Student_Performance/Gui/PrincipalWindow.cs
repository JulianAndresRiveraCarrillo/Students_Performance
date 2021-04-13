using System;
using System.Windows.Forms;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class PrincipalWindow : Form
    {
        private DataManager manager = new DataManager();

        public PrincipalWindow()
        {
            InitializeComponent();
        }

        private void loadBT_Click(object sender, EventArgs e)
        {
            loadData.ShowDialog();
            string path = loadData.FileName;
            manager.createTable(path);

            if(manager.Table != null)
            {
                dataView.DataSource = manager.Table;
            }
        }
    }
}
