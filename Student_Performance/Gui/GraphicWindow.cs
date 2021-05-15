using System;
using System.Windows.Forms;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class GraphicWindow : UserControl
    {
        private DataManager manager = new DataManager();
        private string file;

        public GraphicWindow()
        {
            InitializeComponent();
        }

        public void setFile(string path)
        {
            file = path;
        }

        public void buttonEnable()
        {
            rep1BT.Enabled = true;
            rep2BT.Enabled = true;
            rep3BT.Enabled = true;
            rep4BT.Enabled = true;
            rep5BT.Enabled = true;
        }
        private void rep1BT_Click(object sender, EventArgs e)
        {
            Report rep = new Report(file, 0, 1);
            rep.Show();
        }

        private void rep2BT_Click(object sender, EventArgs e)
        {
            Report rep = new Report(file, 1, 2);
            rep.Show();
        }

        private void rep3BT_Click(object sender, EventArgs e)
        {
            Report rep = new Report(file, 2, 3);
            rep.Show();
        }

        private void rep4BT_Click(object sender, EventArgs e)
        {
            Report rep = new Report(file, 3, 4);
            rep.Show();
        }

        private void rep5BT_Click(object sender, EventArgs e)
        {
            Report rep = new Report(file, 4, 5);
            rep.Show();
        }
    }
}
