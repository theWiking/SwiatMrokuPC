using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Xml;

using Windows.Data.Xml.Dom;
using System.Diagnostics;

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

        KartaPostaci KPMAIN = new KartaPostaci();
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
            foreach (KartaPostaci q in lista_KartPostaci)
            {
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
            KPMAIN = KP;
            dane.Text = "Imie:\t\t" + KP.getImie() + "\nWiek:\t\t" + KP.getWiek() + "\nGracz:\t\t" + KP.getGracz() + "\nKoncept:\t\t" + KP.getKoncept() + "\nCnota:\t\t" +
                KP.getCnota() + "\nSkaza:\t\t" + KP.getSkaza() + "\nKronika:\t\t" + KP.getKronika() + "\nFrakcja:\t\t" + KP.getFrakcja() + "\nNazwa Grupy:\t\t" + KP.getNazwaGrupy();
            Atrybuty.Text = "Inteligencja:\t" + KP.getInteligencja() + "\tSila\t\t" + KP.getSila() + "\tPrecyzja\t\t" + KP.getPrezentacja() + "\n" +
                "Czujność\t\t" + KP.getCzujnosc() + "\tZrecznośc\t" + KP.getZrecznosc() + "\tManipulacja\t" + KP.getManipulacja() + "\n" +
                "Determinacja\t" + KP.getDeterminacja() + "\tWytrzymalosc\t" + KP.getWytrzymalosc() + "\tOpanowanie\t" + KP.getOpanowanie();
            Atrybuty.Text += "\n\n\n";
            Atrybuty.Text += "Umysłowe\t\tFizyczne\t\t\tSpoleczne\n" +
                "Dedukcja:\t" + KP.getDedukcja() + "\tBijatyka\t\t" + KP.getBijatyka() + "\tEkspresja\t" + KP.getEkspresja() + "\n" +
                "Informatyka\t" + KP.getInformatyka() + "\tBroń Biała\t" + KP.getBronBiala() + "\tEmpatia\t\t" + KP.getEmpatia() + "\n" +
                "Medycyna\t" + KP.getMedycyna() + "\tBroń Palna\t" + KP.getBronPalna() + "\tObycie\t\t" + KP.getObycie() + "\n" +
                "Nauka\t\t" + KP.getNauka() + "\tProwadzenie\t" + KP.getProwadzenie() + "\tOszustwko\t" + KP.getOszustwo() + "\n" +
                "Oklutyzm\t" + KP.getOkultyzm() + "\tPrzetrwanie\t" + KP.getPrzetrwanie() + "\tPerswazja\t" + KP.getPreswazja() + "\n" +
                "Polityka\t\t" + KP.getPolityka() + "\tSkradanie się\t" + KP.getSkradanie() + "\tPółświatek\t" + KP.getPolswiate() + "\n" +
                "Rzemiosło\t" + KP.getRzemioslo() + "\tWysportowanie\t" + KP.getWysportowanie() + "\tZastraszanie\t" + KP.getZatraszanie() + "\n" +
                "Wykształcenie\t" + KP.getWyksztalcenie() + "\tZłodziejstwo\t" + KP.getZlodziejstwo() + "\tZwierzęta\t" + KP.getZwierzeta();
            Ekwpiunek.Text = "";
            Ekwpiunek.Text += KP.getBron1Nazwa() + (KP.getBron1Nazwa() == "" ? "" : "\t\t" + KP.getBron1Mod().ToString() + "\n");
            Ekwpiunek.Text += KP.getBron2Nazwa() + (KP.getBron2Nazwa() == "" ? "" : "\t\t" + KP.getBron2Mod().ToString() + "\n");
            Ekwpiunek.Text += KP.getBron3Nazwa() + (KP.getBron3Nazwa() == "" ? "" : "\t\t" + KP.getBron3Mod().ToString() + "\n");
            Ekwpiunek.Text += KP.getWyp1Nazwa() + (KP.getWyp1Nazwa() == "" ? "" : "\t\t" + KP.getWyp1Mod().ToString() + "\n");
            Ekwpiunek.Text += KP.getWyp2Nazwa() + (KP.getWyp2Nazwa() == "" ? "" : "\t\t" + KP.getWyp2Mod().ToString() + "\n");
            Ekwpiunek.Text += KP.getWyp3Nazwa() + (KP.getWyp3Nazwa() == "" ? "" : "\t\t" + KP.getWyp3Mod().ToString() + "\n");
            dane.Text += "\nRozmiar\t" + KP.getRozmiar() + "\nSzybkosc\t" + KP.getSzybkosc() + "\nInicjatywa\t" + KP.getInicjatywa() + "\nObrona\t" + KP.getObrona() +
                "\nPancerz\t" + KP.getPancerz() + "\nMoralność\t" + KP.getMoralnosc().ToString() + "\nDoświadczenia\t" + KP.getDoswiadczenie().ToString() + "\nZdrowie max: \t" + KP.getZdrowie().ToString() +
                "\nSiła Woli\t\t" + KP.getSilaWoli().ToString();
            Atuty.Text = "";
            Atuty.Text += KP.getAt1Nazwa() + "\t\t" + (KP.getAt1Nazwa() == "" ? "" : KP.getAt1Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt2Nazwa() + "\t\t" + (KP.getAt2Nazwa() == "" ? "" : KP.getAt2Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt3Nazwa() + "\t\t" + (KP.getAt3Nazwa() == "" ? "" : KP.getAt3Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt4Nazwa() + "\t\t" + (KP.getAt4Nazwa() == "" ? "" : KP.getAt4Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt5Nazwa() + "\t\t" + (KP.getAt5Nazwa() == "" ? "" : KP.getAt5Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt6Nazwa() + "\t\t" + (KP.getAt6Nazwa() == "" ? "" : KP.getAt6Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt7Nazwa() + "\t\t" + (KP.getAt7Nazwa() == "" ? "" : KP.getAt7Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt8Nazwa() + "\t\t" + (KP.getAt8Nazwa() == "" ? "" : KP.getAt8Wartosc().ToString() + "\n");
            Atuty.Text += KP.getAt9Nazwa() + "\t\t" + (KP.getAt9Nazwa() == "" ? "" : KP.getAt9Wartosc().ToString() + "\n");
            Atuty.Text += "\n\n";
            Atuty.Text += KP.getWada1Nazwa() + "\n" + KP.getWada2Nazwa() + "\n" + KP.getWada3Nazwa();

        }

        private async void eksportuj_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument dom = new XmlDocument();
            XmlElement x;
            XmlComment dec = dom.CreateComment("This is data of " + KPMAIN.getId() + ":" + KPMAIN.getImie());
            dom.AppendChild(dec);
            String[] kolumny=mSQL.getKolumny();
            x = dom.CreateElement("Karty");
            dom.AppendChild(x);
         
            XmlElement x1 = dom.CreateElement("Karta");
          
           
          
            List<object> lista = KPMAIN.zwrocListe();
            for(int i=0; i < kolumny.Length; i++)
            {
                XmlElement w = dom.CreateElement(kolumny[i]);
                w.InnerText = lista[i].ToString();
                x1.AppendChild(w);
            }

           
           

            x.AppendChild(x1);

            

            StorageFolder sf = await ApplicationData.Current.LocalFolder.CreateFolderAsync("EMP", CreationCollisionOption.OpenIfExists);
            StorageFile st = await sf.CreateFileAsync("Karta" + KPMAIN.getId() + KPMAIN.getImie() + ".xml", CreationCollisionOption.ReplaceExisting);

           // var filee = await sf.GetFileAsync("Karta" + KPMAIN.getId() + KPMAIN.getImie() + ".xml");
           // //var readFile = await Windows.Storage.FileIO.ReadLinesAsync(filee);
          //  String dane = "";
           


            await dom.SaveToFileAsync(st);
          
            await Windows.System.Launcher.LaunchFolderAsync(sf);

            String test =dom.GetXml();
            //Show(test);
            /*foreach (var line in readFile)
            {
                dane += line;
            }
            Show(dane);*/
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();
            savePicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".xml" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = "Karta" + KPMAIN.getId() + KPMAIN.getImie() + ".xml";

            Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {

                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(file);
                // write to file

                await Windows.Storage.FileIO.WriteTextAsync(file,test);
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    //this.textBlock.Text = "File " + file.Name + " was saved.";
                }
                else
                {
                    //this.textBlock.Text = "File " + file.Name + " couldn't be saved.";
                }
            }
            else
            {
                //this.textBlock.Text = "Operation cancelled.";
            }
        }
    }
}
