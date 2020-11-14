using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaM;

namespace View
{
    public partial class Form1 : Form
    {
        private int _ticks;
        Game game;
        public Form1()
        {
            InitializeComponent();
            this.game = new Game();
            game.AddLevel("level 3", 7, 7,
           "0303 0606 0001"
           + " 1001 1000 1000 1000 1000 1000 1100"
           + " 0001 0000 0000 0000 0000 0000 0100"
           + " 0001 0000 0000 0000 0000 0000 0100"
           + " 0001 0000 0000 0000 0000 0000 0100"
           + " 0001 0000 0000 0000 0000 0000 0100"
           + " 0001 0000 0000 0000 0000 0000 0100"
           + " 0011 0010 0010 0010 0010 0010 0110");
            game.AddLevel("level 2", 7, 7,
            "0303 0300 0001"
            + " 1001 1000 1000 1000 1000 1000 1100"
            + " 0001 0000 0000 0000 0000 0000 0100"
            + " 0001 0000 0000 0000 0000 0000 0100"
            + " 0001 0000 0000 0000 0000 0000 0100"
            + " 0001 0000 0000 0000 0000 0000 0100"
            + " 0001 0000 0000 0000 0000 0000 0100"
            + " 0011 0010 0010 0010 0010 0010 0110");
            game.AddLevel("level 1", 3, 1, "0000 0001 0002 1011 1010 1110");
            this.SetDisplayLevelName();
            this.SetMoveCount();
            this.SetLevel();



        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            this.game.MoveTheseus(Moves.UP);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            this.game.MoveTheseus(Moves.RIGHT);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            this.game.MoveTheseus(Moves.DOWN);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.game.MoveTheseus(Moves.LEFT);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void SetDisplayLevelName()
        {
            this.LevelNameDisplay.Text = this.game.CurrentLevelName;
        }

        private void SetMoveCount()
        {
            this.MoveCounter.Text = this.game.MoveCount.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();
        }

        private void SetLevel()
        {
            this.comboBox1.Items.AddRange(this.game.LevelNames().ToArray());
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.game.SetLevel(comboBox1.SelectedItem.ToString());
            this.SetDisplayLevelName();
        }
    }
}
