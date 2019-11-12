using Auth.Models;
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
using System.Windows.Shapes;

namespace Auth
{
    /// <summary>
    /// Логика взаимодействия для DeviceAdd.xaml
    /// </summary>
    public partial class DeviceAdd : Window
    {
        public DeviceAdd()
        {
            InitializeComponent();
          
         
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Model1 db = new Model1();
            
            Device dev = new Device
            {
             
            description_problem = des.Text,
                name = name.Text,
                model = model.Text
            };

            db.Device.Add(dev);
            db.SaveChanges();
            MessageBox.Show("Ура!");

            Close();
         
        }
    }
}
