using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Student());
            //Application.Run(new Admin());
            //Application.Run(new Org("org2022121201", "青年志愿者协会"));
            //Application.Run(new ActivityApplicationDetails("2022121802", "1234"));
            //Application.Run(new VerifyActivity());
        }
    }
}
