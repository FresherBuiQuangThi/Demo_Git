using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TH_WF_Tuan01_BuiQuangThi_2001140242.DanhSachChucnang
{
    class Tao_List
    {
        public Tao_List(String[] arr, Control Control, int doc)
        {
            Control.Controls.Clear();
            if (doc == 1)
            {
                int topPosition = 10;
                int leftPosition = 10;
                foreach (string a in arr)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Left = leftPosition;
                    checkBox.Top = topPosition;
                    topPosition += 30;
                    if (topPosition > Control.Height)
                    {
                        leftPosition += 120;
                        topPosition = 10;
                    }
                    checkBox.Text = a;
                    Control.Controls.Add(checkBox);
                }
            }
            else
            {
                int leftPosition = 10;
                int topPosition = 10;
                foreach (string a in arr)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(leftPosition,topPosition );
                    leftPosition += 120;
                    if (leftPosition > Control.Width)
                    {
                        leftPosition = 10;
                        topPosition += 30;
                    }
                    checkBox.Text = a;
                    Control.Controls.Add(checkBox);
                }
            }
        }
    }
}
