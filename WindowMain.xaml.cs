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
using Guids;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        public Users CurrentUser { get; set; }

        private void MainWin_Loaded(object sender, RoutedEventArgs e)
        {
            WindowStart winStart = new WindowStart();

            if (winStart.ShowDialog() == true)
            {
                if (!winStart.Result)
                {
                    this.Close();
                }

                this.CurrentUser = winStart.user;
            }
            else
            {
                this.Close();
            }


        }

        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new MainPage());
        }
    }
}
