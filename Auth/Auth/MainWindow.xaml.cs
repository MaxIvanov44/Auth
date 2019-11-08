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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            AuthDBEntities db = new AuthDBEntities();
           
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();

            reg.ShowDialog();
        }
    }
}
