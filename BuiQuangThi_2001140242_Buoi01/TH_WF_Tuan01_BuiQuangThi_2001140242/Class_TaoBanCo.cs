using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TH_WF_Tuan01_BuiQuangThi_2001140242
{
    public class Class_TaoBanCo
    {

        // Tạo Hàm Dựng Panel.
        #region Properties;
            private Panel pn_ChessBoard;

            public Panel Pn_ChessBoard
            {
                get {return pn_ChessBoard ;}
                set { pn_ChessBoard = value ;}
            }
        #endregion


        #region Initialize;
            public Class_TaoBanCo(Panel pn_ChessBoard)
            {
                this.Pn_ChessBoard = pn_ChessBoard;
            }
        #endregion
        // Kết thúc hàm dựng panel.



        // Tạo Hàm Dựng ProgressBar.
        #region Properties;
            private ProgressBar prsbar_Cot;
            private ProgressBar prsbar_Dong;

            public ProgressBar Prsbar_Cot
            {
                get { return prsbar_Cot; }
                set { prsbar_Cot = value; }
            }

            public ProgressBar Prsbar_Dong
            {
                get { return prsbar_Dong; }
                set { prsbar_Dong = value; }
            }

        #endregion


        #region Initialize;
            public Class_TaoBanCo(ProgressBar prsbar_Dong, ProgressBar prsbar_Cot)
            {
                this.Prsbar_Dong = prsbar_Dong;
                this.Prsbar_Cot = prsbar_Cot;
            }
        #endregion
        // Kết thúc hàm dựng ProgressBar.


        #region Methods;
            public void TaoBanCo(Control crl, int n)
            {
                crl.Controls.Clear();
                int top = 10;
                int left = 10;

                Prsbar_Dong.Maximum = Prsbar_Cot.Maximum = n;
                Prsbar_Cot.Value = 0;

                Button oldButton = new Button() { Location = new Point(0, 0) };   //Lưu vị trí của Button.(tái sử dụng lại).
                for (int i = 0; i < n; i++)
                {
                    Prsbar_Dong.Value = 0;
                    for (int j = 0; j < n; j++)
                    {
                        Button b = new Button()
                        {
                            Width = Cons.chess_width,
                            Height = Cons.chess_height,
                            Location = new Point(oldButton.Location.X + Cons.chess_width, oldButton.Location.Y)
                        };

                        b.Top = top;
                        b.Left = left;
                        left += Cons.chess_width;
                        Pn_ChessBoard.Controls.Add(b);

                        oldButton = b;// gán vị trí mới cho Button old.

                        Prsbar_Dong.Value++;
                        if (j == n - 1)
                        {
                            top += Cons.chess_height;
                            left = 10;
                        }
                        Thread.Sleep(30);
                        Pn_ChessBoard.Refresh();
                    }
                    Prsbar_Cot.Value++;

                    oldButton.Location = new Point(0, oldButton.Location.Y + Cons.chess_width);
                    oldButton.Width = 0;
                    oldButton.Height = 0;
                }
            }
        #endregion





        
    }
}
