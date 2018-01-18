using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using SQLitePCL;
using System.Diagnostics;
using Windows.UI.Popups;

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
            //Show("DbCreat");
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
            Show(insertString);

            dbConnect.Prepare(insertString).Step();
            //TODO dodanie kart i parsowanie

        }
        public void deleteKP(int id)
        {
            //TODO usuwanie karty po ID
            
        }
        public List<KartaPostaci> getAllKP()
        {
            List<KartaPostaci> lista = new List<KartaPostaci>();

            return lista;
        }
        public int getHowManyInBase()
        {
            SQLitePCL.SQLiteConnection dbConnect = new SQLiteConnection("Karty.db");
            dbConnect.Prepare("SELECT COUNT(*) FROM table_KP");

            return 1;
        }
    }
}
