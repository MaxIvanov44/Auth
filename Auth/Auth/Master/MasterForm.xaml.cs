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
        private DataTable dt;

        public void refresh()
        {
            Model1 db = new Model1();

            //var data = from r in db.Users select r;


      //      "SELECT o.id_orders,D.name, M.first_name, U.fio, o.date_order " +
      //"FROM Orders O, Device D, Master M, Users U " +
      //"WHERE m.id_master = o.id_master AND d.id_device = o.id_device AND u.user_id = o.id_users"
            var data = db.Users
               
                
      .SqlQuery("SELECT * from Orders");
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

    }
}
