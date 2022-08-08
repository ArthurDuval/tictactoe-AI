using System;
using System.Windows.Forms;

namespace AI_Tictactoe
{
    public partial class Form1 : Form
    {
        private int difficulty = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void start()
        {
            Random r1 = new Random();
            int coin = r1.Next(0, 2);
            if (coin == 0)
            {
                lblGameInfo.Text = "You start !";
            }
            else
            {
                int x = r1.Next(0, 3);
                int y = r1.Next(0, 3);
                if (difficulty == 3)
                {
                    x = 2 - 2 * r1.Next(0, 2);
                    y = 2 - 2 * r1.Next(0, 2);
                }
                dgvBoard.Rows[y].Cells[x].Value = "X";
                lblGameInfo.Text = "Your turn !";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBoard.Rows.Add();
            dgvBoard.Rows.Add();
            foreach (DataGridViewRow row in dgvBoard.Rows)
            {
                row.Height = 50;
            }
            foreach (DataGridViewColumn column in dgvBoard.Columns)
            {
                column.Width = 50;
            }
            start();
        }

        private void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgvBoard.Rows[i].Cells[j].Value = null;
                }
            }
            start();
        }

        private bool horizontal_check()
        {
            for (int i = 0; i < 3; i++)
            {
                if (dgvBoard.Rows[i].Cells[0].Value != null)
                {
                    if (dgvBoard.Rows[i].Cells[0].Value == dgvBoard.Rows[i].Cells[1].Value && dgvBoard.Rows[i].Cells[1].Value == dgvBoard.Rows[i].Cells[2].Value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool vertical_check()
        {
            for (int i = 0; i < 3; i++)
            {
                if (dgvBoard.Rows[0].Cells[i].Value != null)
                {
                    if (dgvBoard.Rows[0].Cells[i].Value == dgvBoard.Rows[1].Cells[i].Value && dgvBoard.Rows[1].Cells[i].Value == dgvBoard.Rows[2].Cells[i].Value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool diagonal_check()
        {
            if (dgvBoard.Rows[1].Cells[1].Value != null)
            {
                if (dgvBoard.Rows[0].Cells[0].Value == dgvBoard.Rows[1].Cells[1].Value && dgvBoard.Rows[1].Cells[1].Value == dgvBoard.Rows[2].Cells[2].Value || dgvBoard.Rows[0].Cells[2].Value == dgvBoard.Rows[1].Cells[1].Value && dgvBoard.Rows[1].Cells[1].Value == dgvBoard.Rows[2].Cells[0].Value)
                {
                    return true;
                }
            }
            return false;
        }

        private bool win()
        {
            if (horizontal_check() || vertical_check() || diagonal_check())
            {
                return true;
            }
            return false;
        }

        private bool board_full()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dgvBoard.Rows[i].Cells[j].Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool possible_win()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(dgvBoard.Rows[i].Cells[j].Value == null)
                    {
                        dgvBoard.Rows[i].Cells[j].Value = "X";
                        if (win())
                        {
                            return true;
                        }
                        else
                        {
                            dgvBoard.Rows[i].Cells[j].Value = null;
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dgvBoard.Rows[i].Cells[j].Value == null)
                    {
                        dgvBoard.Rows[i].Cells[j].Value = "O";
                        if (win())
                        {
                            dgvBoard.Rows[i].Cells[j].Value = "X";
                            return true;
                        }
                        else
                        {
                            dgvBoard.Rows[i].Cells[j].Value = null;
                        }
                    }
                }
            }
            return false;
        }

        private bool corners_full()
        {
            if (dgvBoard.Rows[0].Cells[0].Value == null || dgvBoard.Rows[0].Cells[2].Value == null || dgvBoard.Rows[2].Cells[0].Value == null || dgvBoard.Rows[2].Cells[2].Value == null)
            {
                return false;
            }
            return true;
        }

        private void dgvBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Random r2 = new Random();
            if (!win())
            {
                int x = dgvBoard.CurrentCell.ColumnIndex;
                int y = dgvBoard.CurrentCell.RowIndex;
                bool player = true;
                if (dgvBoard.CurrentCell.Value == null)
                {
                    dgvBoard.CurrentCell.Value = "O";
                    if (win())
                    {
                        goto End;
                    }
                    player = false;
                    bool bloque = false;
                    if(difficulty != 1)
                    {
                        bloque = possible_win();
                        if (bloque && win())
                        {
                            goto End;
                        }
                    }
                    if (!bloque)
                    {
                        bool no_other_choice = true;
                        if (difficulty == 3)
                        {
                            if (dgvBoard.Rows[1].Cells[1].Value == null)
                            {
                                dgvBoard.Rows[1].Cells[1].Value = "X";
                                no_other_choice = false;
                            }
                            else if(!corners_full())
                            {
                                x = 2 - 2 * r2.Next(0, 2);
                                y = 2 - 2 * r2.Next(0, 2);
                                dgvBoard.Rows[y].Cells[x].Value = "X";
                                no_other_choice=false;
                            }
                        }
                        if(no_other_choice)
                        {
                            int max = 0;
                            do
                            {
                                x = r2.Next(0, 3);
                                y = r2.Next(0, 3);
                            } while (dgvBoard.Rows[y].Cells[x].Value != null && !board_full());
                            if (max < 9)
                            {
                                dgvBoard.Rows[y].Cells[x].Value = "X";
                                player = false;
                                win();
                            }
                        }
                    }
                End:
                    if (win())
                    {
                        if (player)
                        {
                            lblGameInfo.Text = "You";
                        }
                        else
                        {
                            lblGameInfo.Text = "I";
                        }
                        lblGameInfo.Text += " win";
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            label1.Text = "<---";
            label2.Text = null;
            label3.Text = null;
            reset();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            label1.Text = null;
            label2.Text = "<---";
            label3.Text = null;
            reset();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            label1.Text = null;
            label2.Text = null;
            label3.Text = "<---";
            reset();
        }
    }
}
