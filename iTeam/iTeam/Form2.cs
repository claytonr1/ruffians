using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTeam
{
    public partial class Form2 : Form
    {
        //attempting to implement control drag and drop
        //very much a work in progress
        //do not use for school demo, need to research this a bit more

        // movement for label now works

        private Point mousedownlocation;
        private Label target;
        public Form2()
        {
            InitializeComponent();
            this.panel1.DragDrop += panel1_DragDrop;
            this.panel1.DragOver += panel1_DragOver;
        }

        void panel1_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("Drag over works");
        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            MessageBox.Show("This part worked");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mousedownlocation = e.Location;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label1.Left = e.X + label1.Left - mousedownlocation.X;
                label1.Top = e.Y + label1.Top - mousedownlocation.Y;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                target = (Label)sender;
                panel1.Controls.Add(target);
                target.Dock = DockStyle.Top;
                //panel1.Refresh();
            }
        }


    }
}
