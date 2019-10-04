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
        GameEngine engine;
        Timer timer;
        Condition condition = Condition.PAUSED;


        public frm1()
        {
            InitializeComponent();

            ///

            engine = new GameEngine(); //new game engine object
            lblMap.Text = engine.DisplayMap(); //initialize map through the game enigne constructor (sets up map)
            rtbUnitInfo.Text = engine.Information();
            lblRound.Text = "Round:  " + engine.Round;

            ///

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += RunningGame; //runs through every time the timer ticks, runs loop of the game
        }

        private void RunningGame(object sender, EventArgs e)
        {
            engine.GameLoop();
            UpdateInterface();

            if (engine.GameOver) //checks targets left. if 0 , then game ends and displays winner text
            {
                timer.Stop();
                lblMap.Text = engine.Winning + " IS VICTORIOUS\n" + lblMap.Text;
                condition = Condition.ENDED;
                btnStart.Text = "RESTART";
            }


        }

        private void UpdateInterface() //set unit display and update the round
        {
            lblMap.Text = engine.DisplayMap();
            rtbUnitInfo.Text = engine.Information();
            lblRound.Text = "ROUND: " + engine.Round;
        }

        /// 

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (condition == Condition.RUNNING)
            {
                timer.Stop();
                condition = Condition.PAUSED;
                btnStart.Text = "START";
            }
            else
            {
                if (condition == Condition.ENDED) //resets all before running 
                {
                    engine.Reset();
                }
                timer.Start(); //runs game again
                condition = Condition.RUNNING;
                btnStart.Text = "PAUSE";
            }
        }
    }
    public enum Condition
    {
        RUNNING, PAUSED, ENDED
    }
}