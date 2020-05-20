using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P4_Lab12
{
    /// <summary>
    /// Logika interakcji dla klasy Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public bool log=false;
        public User[] users = { new User() { Login = "master", Password = "chybaty" }, new User() { Login = "cienias", Password = "cienias" }, new User() { Login = "ala", Password = "makota" } };
        public MainWindow MyParent { get; set; }
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var val = new Validation();
            for (int i= 0;i<3;i++)
            {
                if (log == false)
                {
                    val.Login = users[i].Login;
                    val.Password = users[i].Password;
                    log = val.CheckLogin(textbox1.Text,Passwordbox1.SecurePassword);
                }
                
            }
            if(log==true)
            {
                this.Close();
                MyParent.superbutton.Content = "wyloguj";
            }
            else
            {
                MessageBox.Show("Złe logowanie");
            }
        }
    }
}
