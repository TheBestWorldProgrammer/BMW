using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya_2_etap_formi
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        public static string Reg(string str)
        {
            str = str.ToUpper();
            str = str[0]+str.Remove(0, 1).ToLower();
            return str;
           
        }
        static void Main()   
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
