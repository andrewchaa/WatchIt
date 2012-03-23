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
using Growl.Connector;

namespace Vigilant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var growlConnector = new GrowlConnector();
            var application = new Growl.Connector.Application("Hello, growl!");
            var notificationType = new NotificationType("sample", "Test");
            growlConnector.Register(application, new [] {notificationType});

            var notification = new Notification(application.Name, notificationType.Name, "1", "Test", "Hello there!");
            growlConnector.Notify(notification);
        }

    }
}
