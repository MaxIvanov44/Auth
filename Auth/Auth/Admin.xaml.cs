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
            AuthDBEntities db = new AuthDBEntities();
            var data = from r in db.Users select r;
            dgr.ItemsSource = data.ToList();
        }
        private void dgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                AuthDBEntities db = new AuthDBEntities();
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
            //AuthDBEntities db = new AuthDBEntities();

            //Users usr = new Users();
            //{
            //    usr.user_id = Convert.ToInt32(abc);
            //};
            //db.Users.Attach(usr);
            //db.Users.Remove(usr);
            //db.SaveChanges();

            AuthDBEntities db = new AuthDBEntities();
            Users users = db.Users
                .Where(o =>o.user_id == abc)
                .FirstOrDefault();
            //Order order = context.Orders
            //    .Where(o => o.OrderId == 8)
            //    .FirstOrDefault();

            db.Users.Remove(users);
            db.SaveChanges();

        }
    }
}
