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
    public partial class HintLabel : UserControl
    {
        private bool hint = true;
        public HintLabel()
        {
            InitializeComponent();
        }

        private void HintLabel_Load(object sender, EventArgs e)
        {

        }

        public void SetText(String text)
        {
            HintText.Text = text;
        }

        public void HideIcon()
        {
            HintIcon.Hide();
            hint = false;
        }

        public void ShowIcon()
        {
            HintIcon.Show();
            hint = true;
        }

        public bool Hint()
        {
            return hint;
        }
    }
}
