using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int count = 0;
        int players = 0;
        bool in_game = true;
        

        


    public Form1()
        {
            InitializeComponent();
            //Button[] buttons;
            //buttons = new Button[9] { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            //butt = Controls.OfType<Button>().ToList();
            butt = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
        }

        List<Button> butt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            players = 1;
            text.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            panel_game.Visible = true;
            Player1.Visible = false;
            Player2.Visible = false;
            Start.Visible = false;
            text.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (players == 2 && in_game)
            {
                
                if (turn)
                    b.Text = "O";
                else
                    b.Text = "X";


                turn = !turn;
                b.Enabled = false;

                winnercheck();
            }
            if (players == 1 && in_game)
            {
                b.Text = "X";
                butt.Remove(b);
                b.Enabled = false;
                winnercheck();
                turn = !turn;
                Button x = random_select();
                Thread.Sleep(1000);
                x.Text = "O";
                winnercheck();
                butt.Remove(x);
                turn = !turn;
            }
        }

        private Button random_select()
        {
            
            int index = RandomNumber(0, butt.Count());
            return butt[index];
        }


        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        private void winnercheck()
        {
            count += 1;
            bool there_is_a_winner = false;

            // This is the winner check for horizontal

            if ((A2.Text != "") && (A1.Text == A2.Text) && (A2.Text == A3.Text))
                there_is_a_winner = true;
            if ((B2.Text != "") && (B1.Text == B2.Text) && (B2.Text == B3.Text))
                there_is_a_winner = true;
            if ((C2.Text != "") && (C1.Text == C2.Text) && (C2.Text == C3.Text))
                there_is_a_winner = true;

            // This is the winner check for vertical

            if ((B1.Text != "") && (A1.Text == B1.Text) && (B1.Text == C1.Text))
                there_is_a_winner = true;
            if ((B2.Text != "") && (A2.Text == B2.Text) && (B2.Text == C2.Text))
                there_is_a_winner = true;
            if ((B3.Text != "") && (A3.Text == B3.Text) && (B3.Text == C3.Text))
                there_is_a_winner = true;

            if ((B2.Text != "") && (A1.Text == B2.Text) && (B2.Text == C3.Text))
                there_is_a_winner = true;
            if ((B2.Text != "") && (C1.Text == B2.Text) && (B2.Text == A3.Text))
                there_is_a_winner = true;

            if(there_is_a_winner)
            {
                disablebutton();
                string winner = "";
                if(turn)
                {
                    winner = "X";
                }
                else
                {
                    winner = "O";
                }
                MessageBox.Show(winner + " Wins!!!");
                in_game = false;
                System.Windows.Forms.Application.Exit();


            }
            if (count == 9)
            {
                MessageBox.Show("DRAW!!!");
                in_game = false;
                System.Windows.Forms.Application.Exit();
            }
                
            
        }
        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    base.Enabled = false;
                }
            }
            catch { }
            
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            players = 2;
            text.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void character_click(object sender, EventArgs e)
        {
            Button x = (Button)sender;

            Console.WriteLine(x.Name);
        }
    }
}











