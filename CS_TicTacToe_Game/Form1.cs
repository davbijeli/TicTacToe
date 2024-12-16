using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TicTacToe_Game
{
    public partial class FrmMain : Form
    {
        Boolean checker;
        int result = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void Disable()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void Score()
        {
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.ForeColor = Color.Red; 
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player X!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }

            if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;

                MessageBox.Show("The winner is Player O!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(result + 1);
                Disable();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Disable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            Score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            Score();
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            Score();
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            Score();
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            Score();
            button4.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            Score();
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            Score();
            button7.Enabled = false;
        }
    }
}
