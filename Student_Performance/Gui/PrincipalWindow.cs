using System;
using System.Windows.Forms;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class PrincipalWindow : Form
    {
        private DataManager manager = new DataManager();
        private string file;

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
            }
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            manager.filterBySex(file, "male");
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            manager.filterBySex(file, "female");
        }

        private void etniBox_SelectedIndexChanged(object sender, EventArgs e) => manager.filterByRace(file, etniBox.Text);

        private void parentBox_SelectedIndexChanged(object sender, EventArgs e) => manager.filterByPLevel(file, parentBox.Text);
    }
}
