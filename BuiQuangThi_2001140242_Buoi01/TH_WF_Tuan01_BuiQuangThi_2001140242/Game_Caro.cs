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

namespace TH_WF_Tuan01_BuiQuangThi_2001140242
{
    public partial class Game_Caro : Form
    {
        public Game_Caro()
        {
            InitializeComponent();
        }

        int r =0; int c = 0;
        int[,] arr;
        int Temp;
        void TaoBanCo(Control crl, int n)
        {

            Matrix = new List<List<Button>>();

            int Temp = 0;
            crl.Controls.Clear();
            int top = 10;
            int left = 10;

            prsbar_Dong.Maximum = prsbar_Cot.Maximum = n;
            prsbar_Cot.Value = 0;


            Button oldButton = new Button() { Location = new Point(0, 0) };   //Lưu vị trí của Button.(tái sử dụng lại).

            for (int i = 0; i < n; i++)
            {
                Matrix.Add(new List<Button>());

                prsbar_Dong.Value = 0;
                for (int j = 0; j < n; j++)
                {
                    Button b = new Button()
                    {
                        Width = Cons.chess_width,
                        Height = Cons.chess_height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        Tag = i.ToString()
                    };

                    b.Top = top;
                    b.Left = left;
                    left += Cons.chess_width;
                                        
                    if (j == n - 1)
                    {
                        top += Cons.chess_height;
                        left = 10;
                    }
                    

                    oldButton = b;// gán vị trí mới cho Button old.     
                    Matrix[i].Add(b);

                    pn_BanCo.Controls.Add(b);

                    prsbar_Dong.Value++;
                    
                    Thread.Sleep(0);
                    pn_BanCo.Refresh();

                    b.Click += new EventHandler(btn_XuLySuKien_Click);

                }
                prsbar_Cot.Value++;

                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.chess_width);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btn_Tao_Click_1(object sender, EventArgs e)
        {
            TaoBanCo(pn_BanCo, int.Parse(cmb_SoO.Text));
            pn_BanCo.AutoScroll = true;
            pn_BanCo.AutoSize = true;
        }







        private void btn_XuLySuKien_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (Temp % 2 == 0)
            {
                //a.Image = Image.FromFile("icono.png");
                a.Text = "X";
                a.Font = new Font(a.Font, a.Font.Style ^ FontStyle.Bold);
                a.BackColor = Color.Red;
            }
            else
            {
                //a.Image = Image.FromFile("iconx.png");
                a.Text = "O";
                a.Font = new Font(a.Font, a.Font.Style ^ FontStyle.Bold);
                a.BackColor = Color.DarkBlue;

            }
            Temp += 1;
            a.Enabled = false;

            if (IsEndGame(a))
            {
                EndGame();
            }

        }

        private void EndGame()
        {
            MessageBox.Show("End Game!!!");
        }

        private bool IsEndGame(Button btn)
        {
            return IsEndGame_Ngang(btn) || IsEndGame_Doc(btn) || IsEndGame_CheoChinh(btn) || IsEndGame_CheoPhu(btn);
        }


        private Point LayToaDoButton(Button btn)
        {          
            int vertical = Convert.ToInt32(btn.Tag);
            int horizoltal = Matrix[vertical].IndexOf(btn);
                
            Point point = new Point(horizoltal,vertical );
            return point;
            
        }



        private bool IsEndGame_Ngang(Button btn)
        {
            Point point = LayToaDoButton(btn);

            int countLeft = 0;

            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countLeft++;
                }
                else
                    break;          
            }

            int countRight = 0;
            for (int i = point.X + 1; i < cmb_SoO.SelectedIndex; i++)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight >= 5;
        }

        private bool IsEndGame_Doc(Button btn)
        {

            Point point = LayToaDoButton(btn);

            int countTop = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBotton = 0;

            for (int i = point.Y + 1; i < cmb_SoO.SelectedIndex; i++)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countBotton++;
                }
                else
                    break;
            }
            return countTop + countBotton >= 5;
        }

        private bool IsEndGame_CheoChinh(Button btn)
        {
            Point point = LayToaDoButton(btn);

            int countTop = 0;

            for (int i = 0; i <= point.X; i++)
            {

                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y - i][point.X - i].Text == btn.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBotton = 0;

            for (int i = 1; i <= cmb_SoO.SelectedIndex - point.X; i++)
            {
                if (point.Y + i > cmb_SoO.SelectedIndex || point.X + i >= cmb_SoO.SelectedIndex)
                {
                    break;
                }

                if (Matrix[point.Y + i][point.X + i].Text == btn.Text)
                {
                    countBotton++;
                }

                else
                    break;
            }
            return countTop + countBotton >= 5;
        }

        private bool IsEndGame_CheoPhu(Button btn)
        {
            Point point = LayToaDoButton(btn);

            int countTop = 0;

            for (int i = 0; i <= point.X; i++)
            {

                if (point.X + i > cmb_SoO.SelectedIndex || point.Y - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y - i][point.X + i].Text == btn.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBotton = 0;

            for (int i = 1; i <= cmb_SoO.SelectedIndex - point.X; i++)
            {
                if (point.Y + i > cmb_SoO.SelectedIndex || point.X - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y + i][point.X - i].Text == btn.Text)
                {
                    countBotton++;
                }

                else
                    break;
            }
            return countTop + countBotton >= 5;
        }




        private List<List<Button>> Matrix;



    }
}
