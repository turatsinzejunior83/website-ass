using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form j;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            

            if(e.Node.Name== "Calculator")
            {
                Form2 j = new Form2();
                panel1.Controls.Clear();
                j = new Form2();
                j.TopLevel = false;
                this.panel1.Controls.Add(j);
                j.Dock = DockStyle.Fill;
                j.Show();



            }


           else  if (e.Node.Name == "Node1")
            {
                Form3 f = new Form3();
                panel1.Controls.Clear();
                f = new Form3();
                f.TopLevel = false;
                this.panel1.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();



            }

            else if (e.Node.Name == "Node3")
            {
                Form5 f = new Form5();
                panel1.Controls.Clear();
                f = new Form5();
                f.TopLevel = false;
                this.panel1.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();



            }
            else if (e.Node.Name == "Node4")
            {
                Form4 f = new Form4();
                panel1.Controls.Clear();
                f = new Form4();
                f.TopLevel = false;
                this.panel1.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();



            }



















           
        }
    }
}
