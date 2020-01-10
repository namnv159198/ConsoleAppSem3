using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Sem3_UWP.Models;
using Sem3_UWP.Services;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Sem3_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPages : Page
    {
        private MemberService _service = new MemberService();
        public RegisterPages()
        {
            this.InitializeComponent();
            
             
        }

        private async void Create_Member(object sender, RoutedEventArgs e)
        {
            var member = new Member()
            {
                firstName = TxtFirstName.Text,
                lastName = TxtLastName.Text,
                password = TxtPassword.Password,
                address = TxtAddress.Text,
                phone = TxtPhone.Text,
                avatar = TxtAvatar.Text,
                gender = Convert.ToInt32(TxtGender.Text),
                email = TxtEmail.Text,
                birthday = TxtBirthday.Text
            };
            var errors = member.CheckValue();
            if (errors.Count > 0)
            {
               
            }

            Member Member = await this._service.RegisterMember(member);

            if (Member.status == 400)
            {
                
                Debug.WriteLine("Status : " +Member.status);
                Debug.WriteLine("Create Failes ");
                StatusCreateFailes.Text = "Create Failes";
            }

            if (Member.status == 1)
            {
                this.TxtFirstName.Text = "";
                this.TxtLastName.Text = "";
                this.TxtAddress.Text = "";
                this.TxtBirthday.Text = "";
                this.TxtGender.Text = "";
                this.TxtPhone.Text = "";
                this.TxtAvatar.Text = "";
                this.TxtPassword.Password = "";
                this.TxtEmail.Text = ""; ;
                StatusCreateSuccess.Text = "Create Success . Your User ID :" + Member.id;

            }
               

        }

        private void Reset_Register(object sender, RoutedEventArgs e)
        {
            this.TxtFirstName.Text = "";
            this.TxtLastName.Text = "";
            this.TxtAddress.Text = "";
            this.TxtBirthday.Text = "";
            this.TxtGender.Text = "";
            this.TxtPhone.Text = "";
            this.TxtAvatar.Text = "";
            this.TxtPassword.Password = "";
            this.TxtEmail.Text = "";
        }

        private void Login_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Login));
        }
    }
}
