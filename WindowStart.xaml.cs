using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Repository;
using Guids;
using System.Linq;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WindowStart : Window
    {
        public bool Result { get; set; }

        public Users user { get; set; }
        public WindowStart()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           using(RepositoryContext db = new RepositoryContext())
            {
                 user = db.Users.Where(el => el.Login == login.Text & el.Pass == pass.Password).FirstOrDefault();

                if (user == null)
                {
                    login.Background = Brushes.Red;
                    pass.Background = Brushes.Red;
                    return;
                }

                this.Result = true;
                this.DialogResult = true;
            }

        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            login.Background = Brushes.MidnightBlue;
        }

        private void pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            pass.Background = Brushes.MidnightBlue;
        }

    }
}
