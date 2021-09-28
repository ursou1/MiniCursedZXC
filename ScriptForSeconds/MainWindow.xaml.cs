using System;
using System.Collections.Generic;
using System.IO;
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

namespace ScriptForSeconds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //ur_soulEntities db = new ur_soulEntities();


            //var rows = File.ReadAllLines(@"C:\Users\user\Desktop\1135_\ДЭ\Сессия 1\clientservice_a_import.csv");
            //var clients = db.Client.ToList();
            //var services = db.Service.ToList();
            //for (int i = 1; i < rows.Length; i++)
            //{
            //    var cols = rows[i].Split(new char[] {';'});
            //    var client = clients.FirstOrDefault(c => c.LastName == cols[0]);
            //    var service = services.FirstOrDefault(c => c.Title == cols[2]);
            //    var time = DateTime.Parse(cols[1]);
            //    ClientService clientService = new ClientService
            //    {
            //        Client = client,
            //        Service = service,
            //        StartTime = time
            //    };
            //    db.ClientService.Add(clientService);
            //}
            //db.SaveChanges();


            //{
            //    var cols = rows[i].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
            //    var time = cols[1].Trim().Split();
            //    int second = int.Parse(time[0]);
            //    if(time[1] == "1")
            //        second *= 60;
            //    else if (time[1] == "час.")
            //        second *= 3600;
            //    Service service = new Service
            //    {
            //        Cost = decimal.Parse(cols[2]),
            //        Title = cols[0],
            //        Discount = double.Parse(cols[3]),
            //        DurationInSeconds = second
            //    };

            //    db.Service.Add(service);
            //}
            //db.SaveChanges();

        }

    }
}
