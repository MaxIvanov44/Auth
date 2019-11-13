
using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

namespace Auth.Master
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
            refresh();
            refr();

        }
        void refresh()
        {
            Model1 db = new Model1();
            var data = from Order in db.Orders
                       join Client in db.Users on Order.id_users equals Client.user_id
                       join Master in db.Master on Order.id_master equals Master.id_master
                       join Device in db.Device on Order.id_device equals Device.id_device
                       select new
                       {
                           Id = Order.id_orders,
                           NameClient = Client.fio,
                           DeviceName = Device.name,
                           MasterFirstName = Master.first_name,
                           OrderDate = Order.date_order

                       };

            dgr.ItemsSource = data.ToList();
        }


        public List <Users> user { get; set; }
        void refr()
        {
            Model1 db = new Model1();

            var data = db.Users.ToList();
            user = data;
            DataContext = user;
            comboname.DisplayMemberPath = "fio";
            comboname.SelectedValuePath = "user_id";



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
