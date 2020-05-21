using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Check
    {
        public string name { get; set; }
        public string email { get; set; }

        public Check(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public void CheckEmail()
        {
            try
            {
                if (name == @"[а-яА-Я]|[a-zA-Z]" && name != "")
                    if (email != "" && email.Contains("@") && email.Contains("."))
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }


        }
    }
}
