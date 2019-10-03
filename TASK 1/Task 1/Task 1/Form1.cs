using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class frm1 : Form
    {
        Map mapHolder = new Map();
        string[,] map = new string[20, 20];
        int mapX = 20;
        int mapY = 20;
        
        public frm1()
        {
            InitializeComponent();
            mapHolder.Owner = this;
            Draw(20, 20);
            mapHolder.PopulateMap();
            mapHolder.DisplayMap();
        }

        public void Draw(int mapX, int mapY) //populate visual representation
        {
            int width = mapX;
            int height = mapY;
            for (int xx = 0; xx < width; xx++)
            {
                for (int yy = 0; yy < height; yy++)
                {
                    lblMap.Text += " . ";
                }
                lblMap.Text += "\n";
            }
        }

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void map_lbl_Click(object sender, EventArgs e)
        {
        }

        private void stats_txt_TextChanged(object sender, EventArgs e)
        {
            rtbUnitInfo.Text = mapHolder.ToString();
        }

        private void round_lbl_Click(object sender, EventArgs e)
        {
            GameEngine gameEngine = new GameEngine();
            lblRound.Text = "Round: " + gameEngine.finishedRounds;
        }
    }
}
