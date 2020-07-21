using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBalls;

namespace StupidBall
{
    public partial class FormGameStupidBalls : Form
    {
        int n = 10;
        List <SimpleMoveBall> balls = new List<SimpleMoveBall>();

        public FormGameStupidBalls()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                SimpleMoveBall ball = new SimpleMoveBall(this);
                ball.Draw();
                balls.Add(ball);
            }

            timerCountLostBalls.Enabled = true;
        }

        private void buttonCatchBall_Click(object sender, EventArgs e)
        {
           /*
            if (ball.onScreen())
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
           */
        }

        private void timerCountLostBalls_Tick(object sender, EventArgs e)
        {
            int countLostBalls = 0;
            foreach (var ball in balls)
            {
                if (!ball.onScreen()) countLostBalls++;
            }
            labelCountLostBalls.Text = Convert.ToString(countLostBalls);
        }
    }
}
