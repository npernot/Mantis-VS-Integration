using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MantisConnectAPI;
namespace MantisVSIntegration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MantisConnectPortTypeClient svcClient;
        public MainWindow()
        {
            InitializeComponent();
            System.ServiceModel.Channels.Binding binding = new System.ServiceModel.BasicHttpBinding();
            System.ServiceModel.EndpointAddress addr = new System.ServiceModel.EndpointAddress("http://support.fwa.eu" + "/api/soap/mantisconnect.php");
            svcClient = new MantisConnectPortTypeClient(binding, addr);
            
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            string result = svcClient.mc_version();
            var projects = svcClient.mc_projects_get_user_accessible("nicolas.pernot", "Alphamax321%");
            MessageBox.Show(string.Format("Mantis version : {0}", result));
            foreach (var item in projects)
            {
                MessageBox.Show(item.name);
            }
        }


    }
}
