﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SwiatMrokuPC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class NowaKarta : Page
    {
        KartaPostaci KP = new KartaPostaci();
        public NowaKarta()
        {
           // ApplicationView.PreferredLaunchViewSize = new Size(1000, 640);
            //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1000, 1000));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
        }

        private void Waliduj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            MySQLiteHelper mSQL = new MySQLiteHelper();
            mSQL.makeDB();
            mSQL.addNewKP(KP);

        }
    }
}
