using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Kyrsovaya_2_etap_formi
{
    class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public User(string str)
        {
            string[] array = str.Split(' ');
            this.login = array[0].Trim();
            this.password = array[1].Trim();
            this.role = array[2].Trim();
        }
        public void Check()
        {
            StreamReader sr = new StreamReader(@"User.txt");
            bool check = false;
            string str;
            int i = 0;
            while ((str = sr.ReadLine()) != null)
            {

                User user = new User(str);
                if ((user.login == this.login) && (user.password == this.password))
                {
                    check = true;
                    Main f2 = new Main();
                    f2.TxtBox = $"Добро пожаловать {user.role}";
                    if (user.role == "Бухгалтер")                  
                            f2.Tbpg(0);                   
                    if (user.role == "Учитель")
                            f2.Tbpg(1);
                    if (user.role == "Ученик")
                            f2.Tbpg(2);
                    if (user.role == "Родитель")
                            f2.Tbpg(3);
                    if (user.role == "Администратор")
                            f2.Tbpg(4);
                    f2.Show();
                   
                    break;
                }
                i++;

            }
            sr.Close();
            if (!check) MessageBox.Show("Неверный логин или пароль");

        }     
    }
}
