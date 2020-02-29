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
    public partial class Map : Form
    {
        private int SIZE = 50;

        public Map()
        {
            InitializeComponent();
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 2);

            int xMargin = 50;
            int yMargin = 10;
            for(int row = 0; row < 6; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    // draw top half
                    int offset = SIZE / 2;
                    int beginTopX = xMargin + offset + 3 * col * SIZE;
                    int endTopX = beginTopX + SIZE;
                    int topY = yMargin + 2 * row * SIZE;
                    e.Graphics.DrawLine(myPen, beginTopX, topY, endTopX, topY);

                    // draw down left
                    int downLeftX = beginTopX - SIZE / 2;
                    int downLeftY = topY + SIZE;
                    e.Graphics.DrawLine(myPen, beginTopX, topY, downLeftX, downLeftY);

                    // draw down right
                    int downRightX = endTopX + SIZE / 2;
                    int downRightY = downLeftY;                    
                    e.Graphics.DrawLine(myPen, endTopX, topY, downRightX, downRightY);

                    // draw bottom half
                    // offset = 0;
                    int beginBottomX = xMargin + (2 + col * 3) * SIZE;
                    int endBottomX = beginBottomX + SIZE;
                    int bottomY = topY + SIZE;
                    e.Graphics.DrawLine(myPen, beginBottomX, bottomY, endBottomX, bottomY);
                }
            }
        }
    }
}
