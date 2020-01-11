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
using Sem3_UWP.Models;
using Sem3_UWP.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Sem3_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MySongPage : Page
    {
        //private Song currentSong;
        private GetMySongService _getMySongService = new GetMySongService();
        //private TokenSaveFileService _tokenSaveFileService = new TokenSaveFileService();
        private Song currentSong;
        private TokenSaveFileService _tokenSaveFileService = new TokenSaveFileService();
        private bool _isPlaying = false;
        private bool _SongNext = true;
        private bool _SongPrevious = false;
        public MySongPage()
        {
            this.InitializeComponent();
        }
        private async void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)

        {
            //var checkToken = await this._tokenSaveFileService.GetToken();

            Songs.ItemsSource = await this._getMySongService.LoadMySong();

        }
    }
}
