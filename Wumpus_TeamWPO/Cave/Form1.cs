using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cave
{
    public partial class Form1 : Form
    {
        // instance variables
        private Cave myCave;

        public Form1()
        {
            InitializeComponent();
            btnNeighbors.Enabled = false;
            btnDoors.Enabled = false;
            btnDrawCave.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCave = new Cave("TestCave.txt");
            btnConstructor.Text = "Cave Created!";
            btnConstructor.Enabled = false;
            btnNeighbors.Enabled = true;
            btnDoors.Enabled = true;
            btnDrawCave.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNeighbors_Click(object sender, EventArgs e)
        {
            int[] neighbors = myCave.getNeighbors(1);
            String str = "";
            for(int i = 0; i < neighbors.Length - 1; i++)
            {
                str += neighbors[i] + ", ";
            }
            str += neighbors[neighbors.Length - 1];
            lblNeighbors.Text = str;
        }

        private void btnDoors_Click(object sender, EventArgs e)
        {
            int[] doors = myCave.getDoors(1);
            String str = "";
            for (int i = 0; i < doors.Length - 1; i++)
            {
                str += doors[i] + ", ";
            }
            str += doors[doors.Length - 1];
            lblDoors.Text = str;
        }

        private void btnDrawCave_Click(object sender, EventArgs e)
        {
            myCave.drawCave();

        }
    }
}
