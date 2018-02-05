using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_WF_Tuan01_BuiQuangThi_2001140242
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk","Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
       
        
        private void List_Load(object sender, EventArgs e)
        {
            rdo_Doc.Checked = true;
            DanhSachChucnang.Tao_List tao = new DanhSachChucnang.Tao_List(foods, panel_List, 1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] foods2 = new string[foods.Length + 1];
            for (int i = 0; i < foods.Length; i++)
            {
                foods2[i] = foods[i];
            }
            foods2[foods2.Length - 1] = textBox1.Text;
            foods = new string[foods2.Length];
            for (int i = 0; i < foods2.Length; i++)
            {
                foods[i] = foods2[i];
            }

            DanhSachChucnang.Tao_List tao = new DanhSachChucnang.Tao_List(foods, panel_List, 1);
        }

        private void panel_List_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdo_Ngang_CheckedChanged_1(object sender, EventArgs e)
        {          
            DanhSachChucnang.Tao_List tao = new DanhSachChucnang.Tao_List(foods, panel_List, 0);
        }

        private void bdo_Doc_CheckedChanged(object sender, EventArgs e)
        {
            DanhSachChucnang.Tao_List tao = new DanhSachChucnang.Tao_List(foods, panel_List, 1);
        }
    }
}
