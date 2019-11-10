
using System;
using System.Windows;
using Auth.Master;
using Auth.Models;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Model1 db = new Model1();
           
            try
            {
                foreach (var users in db.Users)
                {
                    if (users.password == password.Text && users.username == username.Text)
                    {
                        switch (users.role)
                        {
                            case "Admin":
                                Admin adm = new Admin();
                                this.Hide();
                                adm.Show();
                                break;
                            case "Client":
                                MessageBox.Show(users.role);
                                break;
                            case "Master":
                                MessageBox.Show(users.role);
                               
                                break;
                        }
                    }
                    else
                    {

                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);

            }

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
