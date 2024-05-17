using DataBase;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace StoreWPF.Windows
{
    public partial class UserWindow : Window
    {
        private User _user;

        public UserWindow()
        {
            InitializeComponent();
        }
        public UserWindow(User user)
        {
            InitializeComponent();
            _user = user;
            ListInitialize();
        }

        private async Task ListInitialize()
        {
            AlbumsList.ItemsSource = await MusicStoreHandle.GetAlbumsAsync();
        }

        private async void AlbumsList_Selected(object sender, RoutedEventArgs e)
        => BuyButton.IsEnabled = true;
        private async void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            using MusicStoreContext db = new();
            var album = AlbumsList.SelectedItem as Album;
            db.UserAlbums.Add(new(db.Users.ToList().First(x => x.ToString() == _user.ToString()), db.Albums.Include("Group").Include("Genre").Include("Discount").ToList().First(x => x.ToString() == album.ToString())));
            await db.SaveChangesAsync();
            MessageBox.Show("Successful purchase");
        }
        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
