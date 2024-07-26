using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            List<Food> listItemData = new List<Food>()
            {
                new Food(){Name = "Bún chả",Price = 30000},
                new Food(){Name = "Bánh mì pate",Price = 20000},
                new Food(){Name = "Xôi",Price = 15000},
                new Food(){Name = "Phở",Price = 35000},
                new Food(){Name = "Bún đậu mắm tôm",Price = 35000},

            };
            comboBox1.DataSource = listItemData;
            comboBox1.DisplayMember = "Name";
            // add binding
            AddBinding();
        }
        String text = "";

        private void Click_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(text, "Ket qua tra ve", MessageBoxButtons.OKCancel,MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show("click ok");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("click cancel");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = valTest.Text;
        }
        void AddBinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            MessageBox.Show($"Giá trị {comboBox.SelectedItem.ToString()}, index là: {comboBox.SelectedIndex.ToString()}");
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on exit", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on edit", "caption", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on view", "caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on view", "caption", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notifyClick_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(3000,"Thong báo của tuanflute", textBox1.Text, ToolTipIcon.Info);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }

    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
