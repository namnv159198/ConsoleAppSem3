using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using sample1.Models;
using sample1.Services;
using SQLitePCL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace sample1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoSQLite : Page
    {
        private  SQLiteService _sqLiteService = new SQLiteService();
        public DemoSQLite()
        {
            this.InitializeComponent();
            _sqLiteService.createTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.MainPages));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student std = new Student()
            {
                RollNumber =  TxtId.Text,
                Name =  TxtName.Text,
                Status = TxtStatus.Text
            };
            _sqLiteService.createMember(std);
            TxtId.Text = "";
            TxtName.Text = "";
            TxtStatus.Text = " ";
        }
    }
}
