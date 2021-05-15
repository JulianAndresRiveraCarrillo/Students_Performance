﻿using System;
using System.Windows.Forms;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class FilterWindow : UserControl
    {
        private DataManager manager = new DataManager();
        private string file;

        public FilterWindow()
        {
            InitializeComponent();
        }

        public void setFile(string path)
        {
            file = path;
        }

        public void buttonEnable()
        {
            maleButton.Enabled = true;
            femaleButton.Enabled = true;
            etniBox.Enabled = true;
            parentBox.Enabled = true;
            lunchBox.Enabled = true;
            testBox.Enabled = true;
            mathCheck.Enabled = true;
            readingCheck.Enabled = true;
            writingCheck.Enabled = true;
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

        private void lunchBox_TextChanged(object sender, EventArgs e)
        {
            lunchBox.AutoCompleteCustomSource = loadLunchData();
            lunchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            lunchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OK1.Enabled = true;
        }

        private AutoCompleteStringCollection loadLunchData()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.Add("standard");
            data.Add("free/reduced");

            return data;
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            manager.filterByLunch(file, lunchBox.Text);
        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {
            testBox.AutoCompleteCustomSource = loadTestData();
            testBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            testBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OK2.Enabled = true;
        }

        private AutoCompleteStringCollection loadTestData()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.Add("none");
            data.Add("completed");

            return data;
        }

        private void OK2_Click(object sender, EventArgs e)
        {
            manager.filterByTest(file, testBox.Text);
        }

        private void mathCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mathCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                readingCheck.Checked = false;
                writingCheck.Checked = false;
            }
        }

        private void readingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (readingCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                mathCheck.Checked = false;
                writingCheck.Checked = false;
            }
        }

        private void writingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (writingCheck.Checked == true)
            {
                OK3.Enabled = true;
                minBox.Enabled = true;
                maxBox.Enabled = true;

                mathCheck.Checked = false;
                readingCheck.Checked = false;
            }
        }

        private void OK3_Click(object sender, EventArgs e)
        {
            if (mathCheck.Checked == true)
            {
                manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 5);
            }
            else if (readingCheck.Checked == true)
            {
                manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 6);
            }
            else
            {
                manager.filterByScore(file, long.Parse(minBox.Text), long.Parse(maxBox.Text), 7);
            }
        }


    }
}
