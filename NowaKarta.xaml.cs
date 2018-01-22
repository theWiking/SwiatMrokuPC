using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
        KartaPostaci KPMain = new KartaPostaci();
        static public async void Show(string mytext)
        {
            var dialog = new MessageDialog(mytext, "Testmessage");
            await dialog.ShowAsync();
        }
        public NowaKarta()
        {
           // ApplicationView.PreferredLaunchViewSize = new Size(1000, 640);
            //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1000, 1000));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
        }

        private void Waliduj_Click(object sender, RoutedEventArgs e)
        {
            KartaPostaci KP = new KartaPostaci();
            //Dane
            KP.setImie(imie.Text);
            KP.setWiek(wiek.Text);
            KP.setGracz(gracz.Text);
            KP.setKoncept(koncept.Text);
            KP.setCnota(cnota.Text);
            KP.setSkaza(skaza.Text);
            KP.setKronika(kronika.Text);
            KP.setFrakcja(frakcja.Text);
            KP.setNazwaGrupy(nazwaGrupy.Text);
            //Atrybuty
            KP.setInteligencja(Int32.Parse(inteligencja.Text.ToString()));
            KP.setCzujnosc(Int32.Parse(czujnosc.Text.ToString()));
            KP.setDeterminacja(Int32.Parse(determinacja.Text.ToString()));
            KP.setSila(Int32.Parse(sila.Text.ToString()));
            KP.setZrecznosc(Int32.Parse(zrecznosc.Text.ToString()));
            KP.setWytrzymalosc(Int32.Parse(wytrzymalosc.Text.ToString()));
            KP.setPrezentacja(Int32.Parse(prezencja.Text.ToString()));
            KP.setManipulacja(Int32.Parse(manipulacja.Text.ToString()));
            KP.setOpanowanie(Int32.Parse(opanowanie.Text.ToString()));
            //Umiejetnosci

            KP.setDedukcja(Int32.Parse(dedukcja.Text.ToString()));
            KP.setInformatyka(Int32.Parse(informatyka.Text.ToString()));
            KP.setMedycyna(Int32.Parse(medycyna.Text.ToString()));
            KP.setNauka(Int32.Parse(nauka.Text.ToString()));

            KP.setOkultyzm(Int32.Parse(okultyzm.Text.ToString()));
            KP.setPolityka(Int32.Parse(polityka.Text.ToString()));
            KP.setRzemioslo(Int32.Parse(rzemioslo.Text.ToString()));
            KP.setWyksztalcenie(Int32.Parse(wyksztalcenie.Text.ToString()));

            KP.setBijatyka(Int32.Parse(bijatyka.Text.ToString()));
            KP.setBronBiala(Int32.Parse(bronBiala.Text.ToString()));
            KP.setBronPalna(Int32.Parse(bronpalna.Text.ToString()));
            KP.setProwadzenie(Int32.Parse(prowadzenie.Text.ToString()));
            KP.setPrzetrwanie(Int32.Parse(przetrwanie.Text.ToString()));
            KP.setSkradanie(Int32.Parse(skradanie.Text.ToString()));
            KP.setWysportowanie(Int32.Parse(wysprotowanie.Text.ToString()));
            KP.setZlodziejstwo(Int32.Parse(zlodziejstwo.Text.ToString()));

            KP.setEkspresja(Int32.Parse(ekspresja.Text.ToString()));
            KP.setEmpatia(Int32.Parse(empatia.Text.ToString()));
            KP.setObycie(Int32.Parse(obycie.Text.ToString()));
            KP.setOszustwo(Int32.Parse(oszustwo.Text.ToString()));
            KP.setPreswazja(Int32.Parse(perswazja.Text.ToString()));
            KP.setPolswiate(Int32.Parse(polswiatek.Text.ToString()));
            KP.setZatraszanie(Int32.Parse(zastraszanie.Text.ToString()));
            KP.setZwierzeta(Int32.Parse(zwierzeta.Text.ToString()));

            KP.setAt1Nazwa(nazwaAtutu1.Text);
            KP.setAt2Nazwa(nazwaAtutu2.Text);
            KP.setAt3Nazwa(nazwaAtutu3.Text);
            KP.setAt4Nazwa(nazwaAtutu4.Text);
            KP.setAt5Nazwa(nazwaAtutu5.Text);
            KP.setAt6Nazwa(nazwaAtutu6.Text);
            KP.setAt7Nazwa(nazwaAtutu7.Text);

            KP.setAt1Wartosc(Int32.Parse(at1.Text.ToString()));
            KP.setAt2Wartosc(Int32.Parse(at2.Text.ToString()));
            KP.setAt3Wartosc(Int32.Parse(at3.Text.ToString()));
            KP.setAt4Wartosc(Int32.Parse(at4.Text.ToString()));
            KP.setAt5Wartosc(Int32.Parse(at5.Text.ToString()));
            KP.setAt6Wartosc(Int32.Parse(at6.Text.ToString()));
            KP.setAt7Wartosc(Int32.Parse(at7.Text.ToString()));

            KP.setWada1Nazwa(wada1.Text);
            KP.setWada2Nazwa(wada2.Text);
            KP.setWada3Nazwa(wada3.Text);

            KP.setRozmiar(rozmiar.Text);
            KP.setSzybkosc(szybkosc.Text);
            KP.setInicjatywa(inicjatywa.Text);
            KP.setObrona(obrona.Text);
            KP.setPancerz(pancerz.Text);

            KP.setSilaWoli(Int32.Parse(silaWoli.Text.ToString()==""?"0": silaWoli.Text.ToString()));
            KP.setZdrowie(Int32.Parse(zdrowie.Text.ToString() == "" ? "0" : zdrowie.Text.ToString()));
            KP.setMoralnosc(Int32.Parse(moralnosc.Text.ToString() == "" ? "0" : moralnosc.Text.ToString()));
            KP.setDoswiadczenie(Int32.Parse(doswiadczenie.Text.ToString() == "" ? "0" : doswiadczenie.Text.ToString()));

            KP.setBron1Nazwa(nazwaBroni1.Text);
            KP.setBron2Nazwa(nazwaBroni2.Text);
            KP.setBron3Nazwa(nazwaBroni3.Text);

            KP.setBron1Mod(Int32.Parse(bron1.Text.ToString()));
            KP.setBron2Mod(Int32.Parse(bron2.Text.ToString()));
            KP.setBron3Mod(Int32.Parse(bron3.Text.ToString()));

            KP.setWyp1Nazwa(nazwaWyp1.Text);
            KP.setWyp2Nazwa(nazwaWyp2.Text);
            KP.setWyp3Nazwa(nazwaWyp3.Text);

            KP.setWyp1Mod(Int32.Parse(wyp1.Text.ToString()));
            KP.setWyp2Mod(Int32.Parse(wyp2.Text.ToString()));
            KP.setWyp3Mod(Int32.Parse(wyp3.Text.ToString()));
            KP.setDedukcja(Int32.Parse(dedukcja.Text.ToString()));


            if (KP.czyAtrybutyDobrzeWypelnione())
            {
                if (KP.czyUmiejetnosci())
                {
                    dodajButton.IsEnabled=true;
                    KPMain = KP;
                }
                else
                {
                    Show("Zle wypełnione umiejętności "
                        + (KP.getDedukcja()+KP.getInformatyka()+KP.getMedycyna()+KP.getNauka()+KP.getOkultyzm()+KP.getPolityka() +KP.getRzemioslo()+KP.getWyksztalcenie()).ToString()
                        + " " + (KP.getBijatyka()+KP.getBronBiala()+KP.getBronPalna()+KP.getProwadzenie()+KP.getPrzetrwanie()+KP.getSkradanie()+KP.getWysportowanie()+KP.getZlodziejstwo()).ToString()
                        + " " + (KP.getEkspresja()+KP.getEmpatia()+KP.getObycie()+KP.getOszustwo()+KP.getPreswazja()+KP.getPolswiate()+KP.getZatraszanie()+KP.getZwierzeta()).ToString());
                }
            }
            else
            {

              //  Show("żle wyełnione atrybuty " +(KP.getInteligencja()+KP.getCzujnosc()+KP.getDeterminacja()-3).ToString()+" "+(KP.getZrecznosc()+KP.getSila()+KP.getWytrzymalosc()-3).ToString()+" "+(KP.getPrezentacja()+KP.getManipulacja()+KP.getOpanowanie()-3).ToString());
            }
            //Show(imie.Text);
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            MySQLiteHelper mSQL = new MySQLiteHelper();
            mSQL.makeDB();
            mSQL.addNewKP(KPMain);
            Show("dodano");
            Window.Current.Close();
        }
    }
}
