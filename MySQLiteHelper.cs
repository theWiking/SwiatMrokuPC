using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using SQLitePCL;
using System.Diagnostics;
using Windows.UI.Popups;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;

namespace SwiatMrokuPC
{
    class MySQLiteHelper
    {
        static public async void Show(string mytext)
        {
            var dialog = new MessageDialog(mytext, "Testmessage");
            await dialog.ShowAsync();
        }
        private static String[] columns = {"id", "imie", "wiek","gracz","koncept","cnota","skaza","kronika","frakcja","nazwaGrupy",
            "inteligencja","czujnosc","determinacja","sila","zrecznosc","wytrzymalosc","prezentacja","manipulacja","opanowanie",
            "dedukcja","informatyka","medycyna","nauka","okultyzm","polityka","rzemioslo","wyksztalcenie",
            "bijatyka","bronBiala","bronPalna","prowadzenie","przetrwanie","skradanie","wysportowanie","zlodziejstwo",
            "ekspresja","empatia","obycie","oszustwo","preswazja","polswiate","zatraszanie","zwierzeta",
            "at1Nazwa","at2Nazwa","at3Nazwa","at4Nazwa","at5Nazwa","at6Nazwa","at7Nazwa","at8Nazwa","at9Nazwa",
            "at1Wartosc","at2Wartosc","at3Wartosc","at4Wartosc","at5Wartosc","at6Wartosc","at7Wartosc","at8Wartosc","at9Wartosc",
            "wada1Nazwa","wada2Nazwa","wada3Nazwa","wada4Nazwa","wada1Wartosc","wada2Wartosc","wada3Wartosc","wada4Wartosc",
            "rozmiar","szybkosc","inicjatywa","obrona","pancerz","zdrowieMax","silaWoliMax","zdrowie","silaWoli","doswiadczenie","moralnosc",
            "bron1Nazwa","bron2Nazwa","bron3Nazwa","bron1Mod","bron2Mod","bron3Mod",
            "wyp1Nazwa","wyp2Nazwa","wyp3Nazwa","wyp1Mod","wyp2Mod","wyp3Mod"};
        private static String TABLE_KARTY_POSTACI= "table_KP";
        // Database Version
        private static int DATABASE_VERSION = 1;
        // Database Name
        private static String DATABASE_NAME = "KartyPostaci";
        String CREATE_KP_TABLE = "CREATE TABLE IF NOT EXISTS table_KP ( " +
             "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
             "imie TEXT, wiek TEXT, gracz TEXT,koncept TEXT,cnota TEXT,skaza TEXT,kronika TEXT,frakcja TEXT,nazwaGrupy TEXT," +
             "inteligencja INTEGER,czujnosc INTEGER,determinacja INTEGER,sila INTEGER,zrecznosc INTEGER,wytrzymalosc INTEGER,prezentacja INTEGER,manipulacja INTEGER,opanowanie INTEGER," +
             "dedukcja INTEGER,informatyka INTEGER,medycyna INTEGER,nauka INTEGER,okultyzm INTEGER,polityka INTEGER,rzemioslo INTEGER,wyksztalcenie INTEGER," +
             "bijatyka INTEGER,bronBiala INTEGER,bronPalna INTEGER,prowadzenie INTEGER,przetrwanie INTEGER,skradanie INTEGER,wysportowanie INTEGER,zlodziejstwo INTEGER," +
             "ekspresja INTEGER,empatia INTEGER,obycie INTEGER,oszustwo INTEGER,preswazja INTEGER,polswiate INTEGER,zatraszanie INTEGER,zwierzeta INTEGER," +
             "at1Nazwa TEXT,at2Nazwa TEXT,at3Nazwa TEXT,at4Nazwa TEXT,at5Nazwa TEXT,at6Nazwa TEXT,at7Nazwa TEXT,at8Nazwa TEXT,at9Nazwa TEXT," +
             "at1Wartosc INTEGER,at2Wartosc INTEGER,at3Wartosc INTEGER,at4Wartosc INTEGER,at5Wartosc INTEGER,at6Wartosc INTEGER,at7Wartosc INTEGER,at8Wartosc INTEGER,at9Wartosc INTEGER," +
             "wada1Nazwa TEXT,wada2Nazwa TEXT,wada3Nazwa TEXT,wada4Nazwa TEXT,wada1Wartosc ,wada2Wartosc,wada3Wartosc,wada4Wartosc," +
             "rozmiar TEXT,szybkosc TEXT,inicjatywa TEXT,obrona TEXT,pancerz TEXT,zdrowieMax INTEGER ,silaWoliMax INTEGER ,zdrowie INTEGER,silaWoli INTEGER,doswiadczenie INTEGER,moralnosc INTEGER," +
             "bron1Nazwa TEXT,bron2Nazwa TEXT,bron3Nazwa TEXT,bron1Mod INTEGER,bron2Mod INTEGER,bron3Mod INTEGER," +
             "wyp1Nazwa TEXT,wyp2Nazwa TEXT,wyp3Nazwa TEXT,wyp1Mod INTEGER,wyp2Mod INTEGER,wyp3Mod INTEGER );";
       public String getCreat_KP_TALE()
        {
            return CREATE_KP_TABLE;
        }
        public void makeDB()
        {
            SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            MySQLiteHelper mySQLiteHelper = new MySQLiteHelper();
            ISQLiteStatement iSQLiteStatement = dbConnect.Prepare(mySQLiteHelper.getCreat_KP_TALE());
            iSQLiteStatement.Step();
            
        }
        public void addNewKP(KartaPostaci KP)
        {
            SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            MySQLiteHelper mySQLiteHelper = new MySQLiteHelper();
            ISQLiteStatement iSQLiteStatement = dbConnect.Prepare(mySQLiteHelper.getCreat_KP_TALE());
            iSQLiteStatement.Step();

            String insertString = "INSERT INTO " + TABLE_KARTY_POSTACI + " (";
            for(int i = 1; i < columns.Length; i++)
            {
                insertString += columns[i] +( i+1!=columns.Length?",":") VALUES (");
            }
            List<object> lista=KP.zwrocListe(); 
            for(int i = 1; i < lista.Count; i++)
            {
                insertString +="'"+ String.Concat(lista[i])+"'" + (i+1!=lista.Count?",":");");
            }
            //Show(insertString);

            dbConnect.Prepare(insertString).Step();
          

        }
        public void deleteKP(int id)
        {
            //TO-DO usuwanie karty po ID
            SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            String usunKP = "";
            ISQLiteStatement iSQLiteStatement = dbConnect.Prepare(usunKP);
            iSQLiteStatement.Step();
        }
        public List<KartaPostaci> getAllKP()
        {
            List<KartaPostaci> lista = new List<KartaPostaci>();
            SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            String sqlQuery = "SELECT id FROM " + TABLE_KARTY_POSTACI;
            ISQLiteStatement cursor = dbConnect.Prepare(sqlQuery);
            List<int> countID = new List<int>();
            int i=0;
            while (cursor.Step() == SQLiteResult.ROW)
            {
                countID.Add(Int32.Parse(cursor[columns[0]].ToString()));
                i++;
            }
            foreach(var kp in countID) {
                lista.Add(GetKarta(kp));
            }
            Show(i.ToString());
            return lista;
        }
        public KartaPostaci GetKarta(int id)
        {
            KartaPostaci KP = new KartaPostaci();
            
            String sqlQuery = @"SELECT * FROM " + TABLE_KARTY_POSTACI + " WHERE id=" + id;

            SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");

            ISQLiteStatement cursor = dbConnect.Prepare(sqlQuery);
            while (cursor.Step() == SQLiteResult.ROW)
            {
                string test =". "+ (cursor[columns[0]] ).ToString();
               
                KP.setId(Int32.Parse(cursor[columns[0]].ToString()));
                // Log.i("testy","Ilosc "+cursor.getCount());
                // Log.i("testy", cursor.getString(1)+"");
               // Show(getHowManyInBase().ToString());

                KP.setImie(cursor[columns[1]] as string);
                KP.setWiek(cursor[columns[2]] as string);
                KP.setGracz(cursor[columns[3]] as string);
                KP.setKoncept(cursor[columns[4]]as string);
                KP.setCnota(cursor[columns[5]] as string);
                KP.setSkaza(cursor[columns[6]] as string);
                KP.setKronika(cursor[columns[7]] as string);
                KP.setFrakcja(cursor[columns[8]] as string);
                KP.setNazwaGrupy(cursor[columns[9]] as string);

                KP.setInteligencja(Int32.Parse(cursor[columns[10]].ToString()));
                KP.setCzujnosc(Int32.Parse(cursor[columns[11]].ToString()));
                KP.setDeterminacja(Int32.Parse(cursor[columns[12]].ToString()));
                KP.setSila(Int32.Parse(cursor[columns[13]].ToString()));
                KP.setZrecznosc(Int32.Parse(cursor[columns[14]].ToString()));
                KP.setWytrzymalosc(Int32.Parse(cursor[columns[15]].ToString()));
                KP.setPreswazja(Int32.Parse(cursor[columns[16]].ToString()));
                KP.setManipulacja(Int32.Parse(cursor[columns[17]].ToString()));
                KP.setOpanowanie(Int32.Parse(cursor[columns[18]].ToString()));

                KP.setDedukcja(Int32.Parse(cursor[columns[19]].ToString()));
                KP.setInformatyka(Int32.Parse(cursor[columns[20]].ToString()));
                KP.setMedycyna(Int32.Parse(cursor[columns[22]].ToString()));
                KP.setNauka(Int32.Parse(cursor[columns[22]].ToString()));
                KP.setOkultyzm(Int32.Parse(cursor[columns[23]].ToString()));
                KP.setPolityka(Int32.Parse(cursor[columns[24]].ToString()));
                KP.setRzemioslo(Int32.Parse(cursor[columns[25]].ToString()));
                KP.setWyksztalcenie(Int32.Parse(cursor[columns[26]].ToString()));

                KP.setBijatyka(Int32.Parse(cursor[columns[27]].ToString()));
                KP.setBronBiala(Int32.Parse(cursor[columns[28]].ToString()));
                KP.setBronPalna(Int32.Parse(cursor[columns[29]].ToString()));
                KP.setProwadzenie(Int32.Parse(cursor[columns[30]].ToString()));
                KP.setPrzetrwanie(Int32.Parse(cursor[columns[31]].ToString()));
                KP.setSkradanie(Int32.Parse(cursor[columns[32]].ToString()));
                KP.setWysportowanie(Int32.Parse(cursor[columns[33]].ToString()));
                KP.setZlodziejstwo(Int32.Parse(cursor[columns[34]].ToString()));

                KP.setEkspresja(Int32.Parse(cursor[columns[35]].ToString()));
                KP.setEmpatia(Int32.Parse(cursor[columns[36]].ToString()));
                KP.setObycie(Int32.Parse(cursor[columns[37]].ToString()));
                KP.setOszustwo(Int32.Parse(cursor[columns[38]].ToString()));
                KP.setPreswazja(Int32.Parse(cursor[columns[39]].ToString()));
                KP.setPolswiate(Int32.Parse(cursor[columns[40]].ToString()));
                KP.setZatraszanie(Int32.Parse(cursor[columns[41]].ToString()));
                KP.setZwierzeta(Int32.Parse(cursor[columns[42]].ToString()));



                KP.setAt1Wartosc(Int32.Parse(cursor[columns[52]].ToString()));
                KP.setAt2Wartosc(Int32.Parse(cursor[columns[53]].ToString()));
                KP.setAt3Wartosc(Int32.Parse(cursor[columns[54]].ToString()));
                KP.setAt4Wartosc(Int32.Parse(cursor[columns[55]].ToString()));
                KP.setAt5Wartosc(Int32.Parse(cursor[columns[56]].ToString()));
                KP.setAt6Wartosc(Int32.Parse(cursor[columns[57]].ToString()));
                KP.setAt7Wartosc(Int32.Parse(cursor[columns[58]].ToString()));
                KP.setAt8Wartosc(Int32.Parse(cursor[columns[59]].ToString()));
                KP.setAt9Wartosc(Int32.Parse(cursor[columns[60]].ToString()));


                KP.setWada1Nazwa(cursor[columns[61]] as string);
                KP.setWada2Nazwa(cursor[columns[62]] as string);
                KP.setWada3Nazwa(cursor[columns[63]] as string);
                KP.setWada4Nazwa(cursor[columns[64]] as string);
                KP.setWada1Wartosc(Int32.Parse(cursor[columns[65]].ToString()));
                KP.setWada2Wartosc(Int32.Parse(cursor[columns[66]].ToString()));
                KP.setWada3Wartosc(Int32.Parse(cursor[columns[67]].ToString()));
                KP.setWada4Wartosc(Int32.Parse(cursor[columns[68]].ToString()));

                KP.setRozmiar(cursor[columns[69]] as string);
                KP.setSzybkosc(cursor[columns[70]] as string);
                KP.setInicjatywa(cursor[columns[71]] as string);
                KP.setObrona(cursor[columns[72]] as string);
                KP.setPancerz(cursor[columns[73]] as string);
                KP.setZdrowieMax(Int32.Parse(cursor[columns[74]].ToString()));
                KP.setSilaWoliMax(Int32.Parse(cursor[columns[75]].ToString()));
                KP.setZdrowie(Int32.Parse(cursor[columns[76]].ToString()));
                KP.setSilaWoli(Int32.Parse(cursor[columns[77]].ToString()));
                KP.setDoswiadczenie(Int32.Parse(cursor[columns[78]].ToString()));
                KP.setMoralnosc(Int32.Parse(cursor[columns[79]].ToString()));
                KP.setBron1Nazwa(cursor[columns[80]] as string);
                KP.setBron2Nazwa(cursor[columns[81]] as string);
                KP.setBron3Nazwa(cursor[columns[82]] as string);
                KP.setBron1Mod(Int32.Parse(cursor[columns[83]].ToString()));
                KP.setBron2Mod(Int32.Parse(cursor[columns[84]].ToString()));
                KP.setBron3Mod(Int32.Parse(cursor[columns[85]].ToString()));
                KP.setWyp1Nazwa(cursor[columns[86]] as string);
                KP.setWyp2Nazwa(cursor[columns[87]] as string);
                KP.setWyp3Nazwa(cursor[columns[88]] as string);
                KP.setWyp1Mod(Int32.Parse(cursor[columns[89]].ToString()));
                KP.setWyp2Mod(Int32.Parse(cursor[columns[90]].ToString()));


                KP.setWyp3Mod(Int32.Parse(cursor[columns[91]].ToString()));
              
              
            }
            
            return KP;
        }
       /* public int getHowManyInBase()
        {
            SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            ISQLiteStatement cursor= dbConnect.Prepare("SELECT COUNT(id) FROM ("+TABLE_KARTY_POSTACI+");");
            int wynik=0;
            while (cursor.Step() == SQLiteResult.ROW)
            {
                 wynik = Int32.Parse(cursor[0] as string);
            }
            return wynik;
        }*/
    }
}
