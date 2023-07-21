using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    

    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
            Location = new Point(12, 12);

            BackColor = MyPara.sideBarColor;
            SideTitle.BackColor = MyPara.sideTitleColor;
            SideTitle.ForeColor = Color.White;

            SetColor();
            SideItem1.BackColor = MyPara.sideItemColor;
            SideItem1.ForeColor = Color.White;
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            
        }

        public Label GetItem1()
        {
            return SideItem1;
        }

        public Label GetItem2()
        {
            return SideItem2;
        }

        public Label GetItem3()
        {
            return SideItem3;
        }

        public Label GetItem4()
        {
            return SideItem4;
        }
        public Label GetItem5()
        {
            return SideItem5;
        }

        public void SetItem1(String text)
        {
            SideItem1.Text = text;
        }

        public void SetItem2(String text)
        {
            SideItem2.Text = text;
        }

        public void SetItem3(String text)
        {
            SideItem3.Text = text;
        }

        public void SetItem4(String text)
        {
            SideItem4.Text = text;
        }

        public void SetItem5(String text)
        {
            SideItem5.Text = text;
        }

        public void HideItem1()
        {
            SideItem1.Hide();
        }

        public void HideItem2()
        {
            SideItem2.Hide();
        }

        public void HideItem3()
        {
            SideItem3.Hide();
        }

        public void HideItem4()
        {
            SideItem4.Hide();
        }

        public void HideItem5()
        {
            SideItem5.Hide();
        }

        private void SetColor()
        {
            SideItem1.BackColor = MyPara.sideBarColor;
            SideItem2.BackColor = MyPara.sideBarColor;
            SideItem3.BackColor = MyPara.sideBarColor;
            SideItem4.BackColor = MyPara.sideBarColor;
            SideItem5.BackColor = MyPara.sideBarColor;

            SideItem1.ForeColor = MyPara.sideItemTextColor;
            SideItem2.ForeColor = MyPara.sideItemTextColor;
            SideItem3.ForeColor = MyPara.sideItemTextColor;
            SideItem4.ForeColor = MyPara.sideItemTextColor;
            SideItem5.ForeColor = MyPara.sideItemTextColor;
        }

        private void SideItem1_Click(object sender, EventArgs e)
        {
            SetColor();
            SideItem1.BackColor = MyPara.sideItemColor;
            SideItem1.ForeColor = Color.White;
        }

        private void SideItem2_Click(object sender, EventArgs e)
        {
            SetColor();
            SideItem2.BackColor = MyPara.sideItemColor;
            SideItem2.ForeColor = Color.White;
            
        }

        private void SideItem3_Click(object sender, EventArgs e)
        {
            SetColor();
            SideItem3.BackColor = MyPara.sideItemColor;
            SideItem3.ForeColor = Color.White;
        }

        private void SideItem4_Click(object sender, EventArgs e)
        {
            SetColor();
            SideItem4.BackColor = MyPara.sideItemColor;
            SideItem4.ForeColor = Color.White;
        }

        private void SideItem5_Click(object sender, EventArgs e)
        {
            SetColor();
            SideItem5.BackColor = MyPara.sideItemColor;
            SideItem5.ForeColor = Color.White;
        }
    }
}
