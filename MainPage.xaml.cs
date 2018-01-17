using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using SQLitePCL;
using Windows.UI.Popups;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
// Tute https://www.youtube.com/watch?v=L6slHTgQcV4

namespace SwiatMrokuPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
        static public async void Show(string mytext)
        {
            var dialog = new MessageDialog(mytext, "Testmessage");
            await dialog.ShowAsync();
        }
        public MainPage()
        {
            ApplicationView.PreferredLaunchViewSize = new Size(480, 640);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(200, 100));
            MySQLiteHelper mSQH = new MySQLiteHelper();
            mSQH.makeDB();
            
            this.InitializeComponent();
            

        }
       
        
        private async void NowaKarta_Click(object sender, RoutedEventArgs e)
        {
           
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(NowaKarta), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);


        }

        private async void WczytajKarte_Click(object sender, RoutedEventArgs e)
        {
          CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(NowaKarta), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }

        private void Eksportuj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Importuj_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void About_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalCacheFolder;
            await Windows.System.Launcher.LaunchFolderAsync(storageFolder);
        }
    }
}
