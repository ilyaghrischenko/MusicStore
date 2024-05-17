using DataBase;
using DataBase.Models;
using StoreWPF.Windows;
using System.Windows;

namespace StoreWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginInput.Text)
               || string.IsNullOrWhiteSpace(PasswordInput.Password))
            {
                MessageBox.Show("You have not filled all fields");
                return;
            }

            var usersList = await MusicStoreHandle.GetUsersAsync();
            User user = new(LoginInput.Text, PasswordInput.Password);
            var findedUser = usersList.FirstOrDefault(x => x.ToString() == user.ToString());
            if (findedUser != null)
            {
                user = findedUser;
                MessageBox.Show("You have successfully logged in");
            }
            else
            {
                using MusicStoreContext db = new();
                db.Users.Add(user);
                await db.SaveChangesAsync();
                MessageBox.Show("You have successfully registered");
            }

            UserWindow window = new(user);
            window.Show();
            Close();
        }
    }
}