
using System;
using System.Linq;
using System.Windows;
using database;
using System.Windows.Input;
using database.Models;

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
            var data = Class1.refreshgridDB();

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
        public static explicit operator Users(DevicesEntityModel device)
        {

            return new DeviceModel
            {

                Name = device.Name,
                Model = device.Model,
                Manufacturer = device.Manufacturer,
                DescriptionDevice = device.DescriptionDevice

            };

        }
     

//        var ctx = new SchoolDBEntities()

//var student = ctx.Students.Where(s => s.Name == "John Doe").First();

//        student.Name = "Erik Blessman";

//ctx.SaveChanges(); // Will update the  student
        private void UPDATE_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            try
            {
                Users user= new Users
                {

                    username = us.Text,
                    password = pa.Text,
                    fio = fi.Text,
                    role = ro.Text

                };
                DeviceLogic.ChangeDevice(ChangeDevice);
                MessageBox.Show("Информация об устройсте успешно изменена");
                DeviceListWindow deviceList = new DeviceListWindow();
                deviceList.Show();
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
