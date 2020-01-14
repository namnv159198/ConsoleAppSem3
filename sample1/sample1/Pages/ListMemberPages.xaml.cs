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
    public sealed partial class ListMemberPages : Page
    {
        private SQLiteService _sqLiteService  = new SQLiteService();
        public ListMemberPages()
        {
            this.InitializeComponent();
            getListStudent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.MainPages));
        }

        public void getListStudent()
        {
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "SELECT * FROM Students";
            var statment = sqLiteConnection.Prepare(SqlQuery);
            while (statment.Step() == SQLiteResult.ROW)
            {

                Student students = new Student()
                {
                    Name = (string)statment[1]
                };
                ListViewStudent.Items.Add(students.Name);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListViewStudent.Items.Clear();
            List<Student> std = new List<Student>();
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "SELECT * FROM Students where Status = 1";
            var statment = sqLiteConnection.Prepare(SqlQuery);

            while ( SQLiteResult.ROW == statment.Step())
            {
                Student students = new Student()
                {
                    Name = (string)statment[1]
                };
                
                ListViewStudent.Items.Add(students.Name);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListViewStudent.Items.Clear();
            SQLiteConnection sqLiteConnection = new SQLiteConnection("SQLiteStudent.db");
            String SqlQuery = "SELECT * FROM Students where Status = 0";
            var statment = sqLiteConnection.Prepare(SqlQuery);
            while (statment.Step() == SQLiteResult.ROW)
            {

                Student students = new Student()
                {
                    Name = (string)statment[1]
                };
                ListViewStudent.Items.Add(students.Name);
            }
        }
    }
}
