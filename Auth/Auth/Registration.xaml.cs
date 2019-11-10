using Auth.Models;
using Logic;
using System;
using System.Text.RegularExpressions;
using System.Windows;
namespace Auth
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Model1 db = new Model1();

                //if (password.Text.Trim() == password_confirm.Text.Trim())
                //{
                //    if (regex.IsMatch(password.Text))
                //    {
                Users us = new Users
                {
                    fio = fio.Text,
                    password = Pass_Check.Check(password.Text),
                    username = username.Text,
                    role = rolechk.Text
                };

                db.Users.Add(us);
                db.SaveChanges();
                MessageBox.Show("Ура");
                Close();
            //}
            //        else
            //{
            //    MessageBox.Show("Выполнены не все требования к паролю!");
            //}


        

}
            catch(Exception ex)
            {
             
                MessageBox.Show(ex.Message);

            }

        }

        private void radmaster_Checked(object sender, RoutedEventArgs e)
{
    fio.Visibility = Visibility.Hidden;
    username.Visibility = Visibility.Hidden;
}

private void radclient_Checked(object sender, RoutedEventArgs e)
{
    fio.Visibility = Visibility.Visible;
    username.Visibility = Visibility.Visible;
}
    }
}
