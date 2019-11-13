
using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using Auth.Master;
using database;
using database.Models;

namespace Auth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += NOW;
            timer.Tick += All;
        }
        int count = 0;
        DispatcherTimer timer = new DispatcherTimer();

        int cou = 0;
       
        void NOW(object sender, object e)
        {
            lbl.Content = cou;
            cou++;
        }
        void All(object sender, object e)
        {
            try
            {
                if (cou == 0)
                {
                    if (count < 2)
                    {
                        Model1 db = new Model1();
                        if (authchk.CHK(username.Text, password.Text) == true)
                        {
                            MessageBox.Show("YAY");
                            count = 0;
                        }
                        else if (authchk.CHK(username.Text, password.Text) == false)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Block");
                       
                        timer.Start();
                    }
                }
                else if (cou > 10000)
                {
                    timer.Stop();
                    btn.IsEnabled = true;
                    cou = 0;
                    count = 0;
                }
                else
                {
                    btn.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            All(sender, e);
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();

            try
            {
                foreach (var masters in db.Master)
                {
                    if (masters.password == password_Copy.Text && masters.username == username_Copy.Text)
                    {
                        MasterForm mfrm = new MasterForm();
                        this.Hide();
                        mfrm.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);

            }
        }

            private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();

            reg.ShowDialog();
        }
    }
}
