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
    public partial class Truc_Xanh : Form
    {
        public Truc_Xanh()
        {
            InitializeComponent();
        }



        List<string> listIma = new List<string>();
        public void create(int x)
        {
            groupBox1.Controls.Clear();
            int locationX = 8;
            int locationY = 14;
            Size newsize = new Size(312, 238);
            for (int i = 0; i < x; i++)
            {
                if (i >= 2)
                {
                    newsize = new Size(newsize.Width + 75 - 1, newsize.Height + 75 - 1);

                }
                for (int j = 0; j < x; j++)
                {
                    Button bt = new Button();
                    bt.Location = new Point(locationX + 75 * i - i, locationY + 75 * j - j);
                    bt.Text = "";
                    bt.Tag = "";
                    bt.BackgroundImageLayout = ImageLayout.Stretch;
                    bt.Size = new Size(75, 75);
                    bt.Click += Bt_Click;
                    bt.BackgroundImage = Image.FromFile("panda.png");
                    groupBox1.Controls.Add(bt);
                }
            }
            MaximumSize = newsize;
            Size = newsize;
            MinimumSize = newsize;
            for (int i = 0; i < x * x; i++)
            {
                if (groupBox1.Controls[i].Tag.ToString() == "")
                {
                    Thread.Sleep(5);
                    int vt = new Random().Next(0, listIma.Count);
                    string filename = listIma[vt];
                    groupBox1.Controls[i].Tag = filename;
                    while (true)
                    {
                        int position = new Random().Next(i + 1, x * x);
                        if (groupBox1.Controls[position].Tag.ToString() == "")
                        {
                            groupBox1.Controls[position].Tag = filename;
                            break;
                            listIma.RemoveAt(vt);
                        }
                    }
                }
            }
        }

        List<Button> btChose = new List<Button>();
        private void Bt_Click(object sender, EventArgs e)
        {
            if (btChose.Count < 2)
            {
                Button bt = (Button)sender;
                btChose.Add(bt);
                bt.BackgroundImage = Image.FromFile(bt.Tag.ToString());
                bt.Enabled = false;
                int kt = 0;
                foreach (Button b in groupBox1.Controls)
                    if (b.Enabled == true)
                    {
                        kt = 1;
                        break;
                    }
                if (kt == 0)
                {
                    MessageBox.Show("Xin chúc mừng. Bạn đã chiến thắng!!");
                    btReset.Enabled = false;
                    btStart.Enabled = true;
                    tbNumber.Enabled = true;
                }
            }
            else
            {
                if (btChose[0].Tag.ToString() != btChose[1].Tag.ToString())
                {
                    foreach (Button b in btChose)
                    {
                        b.BackgroundImage = Image.FromFile("panda.png");
                        b.Enabled = true;
                    }
                }
                btChose.Clear();
                Button bt = (Button)sender;
                btChose.Add(bt);
                bt.Enabled = false;
                bt.BackgroundImage = Image.FromFile(bt.Tag.ToString());

            }

        }



        private void Truc_Xanh_Load(object sender, EventArgs e)
        {
            btReset.Enabled = false;
            for (int i = 0; i < 10; i ++)
            {
                listIma.Add(i + ".png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            int number = int.Parse(tbNumber.Text);

            if (number %2 != 0)
            {
                MessageBox.Show("Vui lòng nhập 1 số chẳn");
                return;
            }
            if (number < 2)
            {
                MessageBox.Show("Số lượng phải ít nhất 2");
                return;
            }
            if (number > 10)
            {
                MessageBox.Show("Số lượng nhiều nhất chỉ được 10");
                return;
            }
            create(number);
            tbNumber.Enabled = false;
            btStart.Enabled = false;
            btReset.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            int number = int.Parse(tbNumber.Text);

            if (number %2 != 0)
            {
                MessageBox.Show("Vui lòng nhập 1 số chẳn");
                return;
            }
            if (number < 2)
            {
                MessageBox.Show("Số lượng phải ít nhất 2");
                return;
            }
            if (number > 10)
            {
                MessageBox.Show("Số lượng nhiều nhất chỉ được 10");
                return;
            }
            create(number);
            tbNumber.Enabled = false;
            btStart.Enabled = false;
            btReset.Enabled = true;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            tbNumber.Enabled = true;
            btStart.Enabled = true;
            btReset.Enabled = false;
            listIma.Clear();
            btChose.Clear();
            for (int i = 0; i < 10; i++)
            {
                listIma.Add(i + ".png");
            }
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            lbX.Text = "x " + tbNumber.Text;
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
