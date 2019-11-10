using Auth.Models;
using System;
using System.Linq;
using System.Windows;

using System.Windows.Input;

namespace Auth
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        static int abc = 0;
        public Admin()
        {
            InitializeComponent();
            refreshgrid();
            idlbl.Content = abc;
        }
        void refreshgrid()
        {
            Model1 db = new Model1();
            var data = from r in db.Users select r;

            dgr.ItemsSource = data.ToList();
        }
        private void dgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                if (dgr.SelectedCells.Count() != 0)
                {
                    Users users = new Users();
                    var abc = dgr.SelectedIndex+1;
                    idlbl.Content = abc;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void DELETE_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageResult = MessageBox.Show("Вы уверены, что хотите удалить это устройство?", "Удаление устройства", MessageBoxButton.YesNo);
            if (messageResult == MessageBoxResult.Yes)
            {
                int abc = Convert.ToInt32(idtxt.Text);
                Model1 db = new Model1();
                Users users = db.Users
                    .Where(o => o.user_id == abc)
                    .FirstOrDefault();

                db.Users.Remove(users);
                db.SaveChanges();
                refreshgrid();
            } 
            if (messageResult == MessageBoxResult.No)
            {
                MessageBox.Show("Nope!");
                refreshgrid();
            }
        }
    }
}
