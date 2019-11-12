using System;
using System.Collections.Generic;
using System.Data;
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
using Auth.Models;

namespace Auth.Master
{
    /// <summary>
    /// Логика взаимодействия для MasterForm.xaml
    /// </summary>
    public partial class MasterForm : Window
    {
        public MasterForm()
        {
            InitializeComponent();
            refresh();
         
        }
      

        public void refresh()
        {
            Model1 db = new Model1();

            //var data = from r in db.Users select r;


      //      "SELECT o.id_orders,D.name, M.first_name, U.fio, o.date_order " +
      //"FROM Orders O, Device D, Master M, Users U " +
      //"WHERE m.id_master = o.id_master AND d.id_device = o.id_device AND u.user_id = o.id_users"
           // var data = db.Users
               var data = from order in db.Orders
                           join client in db.Users on order.id_users equals client.user_id
                           join device in db.Device on order.id_device equals device.id_device
                           join master in db.Master on order.id_master equals master.id_master
                           select new
                           {
                               Id = order.id_orders,
                           NameClient = client.fio,
                           DeviceName = device.name,
                           MasterFirstName = master.first_name,
                           OrderDate = order.date_order
                         
                           };
                
     
            dgr.ItemsSource = data.ToList();
            // dt = new DataTable();

            // dt.Columns.Add("ID");
            // dt.Columns.Add("Users");
            // dt.Columns.Add("Device");
            // dt.Columns.Add("Master");
            // Model1 db = new Model1();
            // var z = db.Orders;
            //foreach (var i in z )
            // {
            //     dt.Rows.Add(i.id_orders, i.id_users , i.id_device , i.id_master);
            // }

            // dgr.ItemsSource = dt.DefaultView;

            //Model1 model = new Model1();
            //var data = from d in model.Orders select d;
            //dgr.ItemsSource = data.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeviceAdd dv = new DeviceAdd();
            this.Hide();
            dv.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                
            Order ord = new Order();
            this.Hide();
            ord.Show();
        }
    }
}
