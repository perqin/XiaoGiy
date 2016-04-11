using System;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XiaoGiy.Views {
    public sealed partial class MainPage : Page {
        public MainPage() {
            InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(360, 360));
        }

        private void ChatButton_Click(object sender, RoutedEventArgs e) {
            if (NicknameTextBox.Text == "") {
                //TODO: Alert
            } else {
                App.MeVM.Me.Nickname = NicknameTextBox.Text;
                App.MeVM.Me.Id = Guid.NewGuid().ToString();
                var rootFrame = Window.Current.Content as Frame;
                if (rootFrame != null) {
                    rootFrame.Navigate(typeof(ChatPage));
                }
            }
        }
    }
}
