using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class WszystajKarte : Page
    {
        SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
        private static MySQLiteHelper mSQL = new MySQLiteHelper();
        public WszystajKarte()
        {
            mSQL.makeDB();

            this.InitializeComponent();
            ZaladujKartyPostyaci();

        }
        public void ZaladujKartyPostyaci()
        {
            List<KartaPostaci> lista_KartPostaci = mSQL.getAllKP();
            lista_KartPostaci.Reverse();
            foreach(KartaPostaci q in lista_KartPostaci) {
                ListaKartPostaci.Items.Add(q.getId().ToString() + ": " + q.getImie());
            }

            
        }
        static public async void Show(string mytext)
        {
            var dialog = new MessageDialog(mytext, "Testmessage");
            await dialog.ShowAsync();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
         
            String a = comboBox.SelectedValue.ToString();
            int comma = a.IndexOf(':');
            String idstring = a;
            if (comma != -1)
            {
                idstring = a.Substring(0, comma);
            }
            KartaPostaci KP = mSQL.GetKarta(Int32.Parse(idstring));
            dane.Text = "Imie: "+ KP.getImie()+"\n";
            dane.Text += "Value : " +idstring;
        }


    }
}
