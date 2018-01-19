using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatMrokuPC
{

    class KartaPostaci
    {
        //zmienne
        private int id;
        private String imie="q";
        private String wiek;
        private String gracz;
        private String koncept;
        private String cnota;
        private String skaza;
        private String kronika;
        private String frakcja;
        private String nazwaGrupy;

        private int inteligencja = 1;
        private int czujnosc = 1;
        private int determinacja = 1;
        private int sila = 1;
        private int zrecznosc = 1;
        private int wytrzymalosc = 1;
        private int prezentacja = 1;
        private int manipulacja = 1;
        private int opanowanie = 1;

        private int dedukcja;
        private int informatyka;
        private int medycyna;
        private int nauka;
        private int okultyzm;
        private int polityka;
        private int rzemioslo;
        private int wyksztalcenie;


        private int bijatyka;
        private int bronBiala;
        private int bronPalna;
        private int prowadzenie;
        private int przetrwanie;
        private int skradanie;
        private int wysportowanie;
        private int zlodziejstwo;

        private int ekspresja;
        private int empatia;
        private int obycie;
        private int oszustwo;
        private int preswazja;
        private int polswiate;
        private int zatraszanie;
        private int zwierzeta;

        private String at1Nazwa = "";
        private String at2Nazwa = "";
        private String at3Nazwa = "";
        private String at4Nazwa = "";
        private String at5Nazwa = "";
        private String at6Nazwa = "";
        private String at7Nazwa = "";
        private String at8Nazwa = "";
        private String at9Nazwa = "";

        private int at1Wartosc;
        private int at2Wartosc;
        private int at3Wartosc;
        private int at4Wartosc;
        private int at5Wartosc;
        private int at6Wartosc;
        private int at7Wartosc;
        private int at8Wartosc;
        private int at9Wartosc;

        private String wada1Nazwa = "";
        private String wada2Nazwa = "";
        private String wada3Nazwa = "";
        private String wada4Nazwa = "";
        private int wada1Wartosc;
        private int wada2Wartosc;
        private int wada3Wartosc;
        private int wada4Wartosc;

        private String rozmiar;
        private String szybkosc;
        private String inicjatywa;
        private String obrona;
        private String pancerz;
        private int zdrowieMax;
        private int zdrowie;
        private int silaWoliMax;
        private int silaWoli;
        private int doswiadczenie;
        private int moralnosc;

        private String bron1Nazwa;
        private String bron2Nazwa;
        private String bron3Nazwa;
        private int bron1Mod;
        private int bron2Mod;
        private int bron3Mod;

        private String wyp1Nazwa;
        private String wyp2Nazwa;
        private String wyp3Nazwa;
        private int wyp1Mod;
        private int wyp2Mod;
        private int wyp3Mod;
        //Settery i getery
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public String getImie()
        {
            return imie;
        }

        public void setImie(String imie)
        {
            this.imie = imie;
        }

        public String getWiek()
        {
            return wiek;
        }

        public void setWiek(String wiek)
        {
            this.wiek = wiek;
        }

        public String getGracz()
        {
            return gracz;
        }

        public void setGracz(String gracz)
        {
            this.gracz = gracz;
        }

        public String getKoncept()
        {
            return koncept;
        }

        public void setKoncept(String koncept)
        {
            this.koncept = koncept;
        }

        public String getCnota()
        {
            return cnota;
        }

        public void setCnota(String cnota)
        {
            this.cnota = cnota;
        }

        public String getSkaza()
        {
            return skaza;
        }

        public void setSkaza(String skaza)
        {
            this.skaza = skaza;
        }

        public String getKronika()
        {
            return kronika;
        }

        public void setKronika(String kronika)
        {
            this.kronika = kronika;
        }

        public String getFrakcja()
        {
            return frakcja;
        }

        public void setFrakcja(String frakcja)
        {
            this.frakcja = frakcja;
        }

        public String getNazwaGrupy()
        {
            return nazwaGrupy;
        }

        public void setNazwaGrupy(String nazwaGrupy)
        {
            this.nazwaGrupy = nazwaGrupy;
        }

        public int getInteligencja()
        {
            return inteligencja;
        }

        public void setInteligencja(int inteligencja)
        {
            this.inteligencja = inteligencja;
        }

        public int getCzujnosc()
        {
            return czujnosc;
        }

        public void setCzujnosc(int czujnosc)
        {
            this.czujnosc = czujnosc;
        }

        public int getDeterminacja()
        {
            return determinacja;
        }

        public void setDeterminacja(int determinacja)
        {
            this.determinacja = determinacja;
        }

        public int getSila()
        {
            return sila;
        }

        public void setSila(int sila)
        {
            this.sila = sila;
        }

        public int getZrecznosc()
        {
            return zrecznosc;
        }

        public void setZrecznosc(int zrecznosc)
        {
            this.zrecznosc = zrecznosc;
        }

        public int getWytrzymalosc()
        {
            return wytrzymalosc;
        }

        public void setWytrzymalosc(int wytrzymalosc)
        {
            this.wytrzymalosc = wytrzymalosc;
        }

        public int getPrezentacja()
        {
            return prezentacja;
        }

        public void setPrezentacja(int prezentacja)
        {
            this.prezentacja = prezentacja;
        }

        public int getManipulacja()
        {
            return manipulacja;
        }

        public void setManipulacja(int manipulacja)
        {
            this.manipulacja = manipulacja;
        }

        public int getDedukcja()
        {
            return dedukcja;
        }

        public void setDedukcja(int dedukcja)
        {
            this.dedukcja = dedukcja;
        }

        public int getInformatyka()
        {
            return informatyka;
        }

        public void setInformatyka(int informatyka)
        {
            this.informatyka = informatyka;
        }

        public int getMedycyna()
        {
            return medycyna;
        }

        public void setMedycyna(int medycyna)
        {
            this.medycyna = medycyna;
        }

        public int getNauka()
        {
            return nauka;
        }

        public void setNauka(int nauka)
        {
            this.nauka = nauka;
        }

        public int getOkultyzm()
        {
            return okultyzm;
        }

        public void setOkultyzm(int okultyzm)
        {
            this.okultyzm = okultyzm;
        }

        public int getPolityka()
        {
            return polityka;
        }

        public void setPolityka(int polityka)
        {
            this.polityka = polityka;
        }

        public int getRzemioslo()
        {
            return rzemioslo;
        }

        public void setRzemioslo(int rzemioslo)
        {
            this.rzemioslo = rzemioslo;
        }

        public int getWyksztalcenie()
        {
            return wyksztalcenie;
        }

        public void setWyksztalcenie(int wyksztalcenie)
        {
            this.wyksztalcenie = wyksztalcenie;
        }

        public int getBijatyka()
        {
            return bijatyka;
        }

        public void setBijatyka(int bijatyka)
        {
            this.bijatyka = bijatyka;
        }

        public int getBronBiala()
        {
            return bronBiala;
        }

        public void setBronBiala(int bronBiala)
        {
            this.bronBiala = bronBiala;
        }

        public int getBronPalna()
        {
            return bronPalna;
        }

        public void setBronPalna(int bronPalna)
        {
            this.bronPalna = bronPalna;
        }

        public int getProwadzenie()
        {
            return prowadzenie;
        }

        public void setProwadzenie(int prowadzenie)
        {
            this.prowadzenie = prowadzenie;
        }

        public int getPrzetrwanie()
        {
            return przetrwanie;
        }

        public void setPrzetrwanie(int przetrwanie)
        {
            this.przetrwanie = przetrwanie;
        }

        public int getSkradanie()
        {
            return skradanie;
        }

        public void setSkradanie(int skradanie)
        {
            this.skradanie = skradanie;
        }

        public int getWysportowanie()
        {
            return wysportowanie;
        }

        public void setWysportowanie(int wysportowanie)
        {
            this.wysportowanie = wysportowanie;
        }

        public int getZlodziejstwo()
        {
            return zlodziejstwo;
        }

        public void setZlodziejstwo(int zlodziejstwo)
        {
            this.zlodziejstwo = zlodziejstwo;
        }

        public int getEkspresja()
        {
            return ekspresja;
        }

        public void setEkspresja(int ekspresja)
        {
            this.ekspresja = ekspresja;
        }

        public int getEmpatia()
        {
            return empatia;
        }

        public void setEmpatia(int empatia)
        {
            this.empatia = empatia;
        }

        public int getObycie()
        {
            return obycie;
        }

        public void setObycie(int obycie)
        {
            this.obycie = obycie;
        }

        public int getOszustwo()
        {
            return oszustwo;
        }

        public void setOszustwo(int oszustwo)
        {
            this.oszustwo = oszustwo;
        }

        public int getPreswazja()
        {
            return preswazja;
        }

        public void setPreswazja(int preswazja)
        {
            this.preswazja = preswazja;
        }

        public int getPolswiate()
        {
            return polswiate;
        }

        public void setPolswiate(int polswiate)
        {
            this.polswiate = polswiate;
        }

        public int getZatraszanie()
        {
            return zatraszanie;
        }

        public void setZatraszanie(int zatraszanie)
        {
            this.zatraszanie = zatraszanie;
        }

        public int getZwierzeta()
        {
            return zwierzeta;
        }

        public void setZwierzeta(int zwierzeta)
        {
            this.zwierzeta = zwierzeta;
        }

        public String getAt1Nazwa()
        {
            return at1Nazwa;
        }

        public void setAt1Nazwa(String at1Nazwa)
        {
            this.at1Nazwa = at1Nazwa;
        }

        public String getAt2Nazwa()
        {
            return at2Nazwa;
        }

        public void setAt2Nazwa(String at2Nazwa)
        {
            this.at2Nazwa = at2Nazwa;
        }

        public String getAt3Nazwa()
        {
            return at3Nazwa;
        }

        public void setAt3Nazwa(String at3Nazwa)
        {
            this.at3Nazwa = at3Nazwa;
        }

        public String getAt4Nazwa()
        {
            return at4Nazwa;
        }

        public void setAt4Nazwa(String at4Nazwa)
        {
            this.at4Nazwa = at4Nazwa;
        }

        public String getAt5Nazwa()
        {
            return at5Nazwa;
        }

        public void setAt5Nazwa(String at5Nazwa)
        {
            this.at5Nazwa = at5Nazwa;
        }

        public String getAt6Nazwa()
        {
            return at6Nazwa;
        }

        public void setAt6Nazwa(String at6Nazwa)
        {
            this.at6Nazwa = at6Nazwa;
        }

        public String getAt7Nazwa()
        {
            return at7Nazwa;
        }

        public void setAt7Nazwa(String at7Nazwa)
        {
            this.at7Nazwa = at7Nazwa;
        }

        public String getAt8Nazwa()
        {
            return at8Nazwa;
        }

        public void setAt8Nazwa(String at8Nazwa)
        {
            this.at8Nazwa = at8Nazwa;
        }

        public String getAt9Nazwa()
        {
            return at9Nazwa;
        }

        public void setAt9Nazwa(String at9Nazwa)
        {
            this.at9Nazwa = at9Nazwa;
        }

        public int getAt1Wartosc()
        {
            return at1Wartosc;
        }

        public void setAt1Wartosc(int at1Wartosc)
        {
            this.at1Wartosc = at1Wartosc;
        }

        public int getAt2Wartosc()
        {
            return at2Wartosc;
        }

        public void setAt2Wartosc(int at2Wartosc)
        {
            this.at2Wartosc = at2Wartosc;
        }

        public int getAt3Wartosc()
        {
            return at3Wartosc;
        }

        public void setAt3Wartosc(int at3Wartosc)
        {
            this.at3Wartosc = at3Wartosc;
        }

        public int getAt4Wartosc()
        {
            return at4Wartosc;
        }

        public void setAt4Wartosc(int at4Wartosc)
        {
            this.at4Wartosc = at4Wartosc;
        }

        public int getAt5Wartosc()
        {
            return at5Wartosc;
        }

        public void setAt5Wartosc(int at5Wartosc)
        {
            this.at5Wartosc = at5Wartosc;
        }

        public int getAt6Wartosc()
        {
            return at6Wartosc;
        }

        public void setAt6Wartosc(int at6Wartosc)
        {
            this.at6Wartosc = at6Wartosc;
        }

        public int getAt7Wartosc()
        {
            return at7Wartosc;
        }

        public void setAt7Wartosc(int at7Wartosc)
        {
            this.at7Wartosc = at7Wartosc;
        }

        public int getAt8Wartosc()
        {
            return at8Wartosc;
        }

        public void setAt8Wartosc(int at8Wartosc)
        {
            this.at8Wartosc = at8Wartosc;
        }

        public int getAt9Wartosc()
        {
            return at9Wartosc;
        }

        public void setAt9Wartosc(int at9Wartosc)
        {
            this.at9Wartosc = at9Wartosc;
        }

        public String getWada1Nazwa()
        {
            return wada1Nazwa;
        }

        public void setWada1Nazwa(String wada1Nazwa)
        {
            this.wada1Nazwa = wada1Nazwa;
        }

        public String getWada2Nazwa()
        {
            return wada2Nazwa;
        }

        public void setWada2Nazwa(String wada2Nazwa)
        {
            this.wada2Nazwa = wada2Nazwa;
        }

        public String getWada3Nazwa()
        {
            return wada3Nazwa;
        }

        public void setWada3Nazwa(String wada3Nazwa)
        {
            this.wada3Nazwa = wada3Nazwa;
        }

        public String getWada4Nazwa()
        {
            return wada4Nazwa;
        }

        public void setWada4Nazwa(String wada4Nazwa)
        {
            this.wada4Nazwa = wada4Nazwa;
        }

        public int getWada1Wartosc()
        {
            return wada1Wartosc;
        }

        public void setWada1Wartosc(int wada1Wartosc)
        {
            this.wada1Wartosc = wada1Wartosc;
        }

        public int getWada2Wartosc()
        {
            return wada2Wartosc;
        }

        public void setWada2Wartosc(int wada2Wartosc)
        {
            this.wada2Wartosc = wada2Wartosc;
        }

        public int getWada3Wartosc()
        {
            return wada3Wartosc;
        }

        public void setWada3Wartosc(int wada3Wartosc)
        {
            this.wada3Wartosc = wada3Wartosc;
        }

        public int getWada4Wartosc()
        {
            return wada4Wartosc;
        }

        public void setWada4Wartosc(int wada4Wartosc)
        {
            this.wada4Wartosc = wada4Wartosc;
        }

        public String getRozmiar()
        {
            return rozmiar;
        }

        public void setRozmiar(String rozmiar)
        {
            this.rozmiar = rozmiar;
        }

        public String getSzybkosc()
        {
            return szybkosc;
        }

        public void setSzybkosc(String szybkosc)
        {
            this.szybkosc = szybkosc;
        }

        public String getInicjatywa()
        {
            return inicjatywa;
        }

        public void setInicjatywa(String inicjatywa)
        {
            this.inicjatywa = inicjatywa;
        }

        public String getObrona()
        {
            return obrona;
        }

        public void setObrona(String obrona)
        {
            this.obrona = obrona;
        }

        public String getPancerz()
        {
            return pancerz;
        }

        public void setPancerz(String pancerz)
        {
            this.pancerz = pancerz;
        }

        public int getZdrowieMax()
        {
            return zdrowieMax;
        }

        public void setZdrowieMax(int zdrowieMax)
        {
            this.zdrowieMax = zdrowieMax;
        }

        public int getZdrowie()
        {
            return zdrowie;
        }

        public void setZdrowie(int zdrowie)
        {
            this.zdrowie = zdrowie;
        }

        public int getSilaWoliMax()
        {
            return silaWoliMax;
        }

        public void setSilaWoliMax(int silaWoliMax)
        {
            this.silaWoliMax = silaWoliMax;
        }

        public int getSilaWoli()
        {
            return silaWoli;
        }

        public void setSilaWoli(int silaWoli)
        {
            this.silaWoli = silaWoli;
        }

        public int getDoswiadczenie()
        {
            return doswiadczenie;
        }

        public void setDoswiadczenie(int doswiadczenie)
        {
            this.doswiadczenie = doswiadczenie;
        }

        public int getMoralnosc()
        {
            return moralnosc;
        }

        public void setMoralnosc(int moralnosc)
        {
            this.moralnosc = moralnosc;
        }

        public String getBron1Nazwa()
        {
            return bron1Nazwa;
        }

        public void setBron1Nazwa(String bron1Nazwa)
        {
            this.bron1Nazwa = bron1Nazwa;
        }

        public String getBron2Nazwa()
        {
            return bron2Nazwa;
        }

        public void setBron2Nazwa(String bron2Nazwa)
        {
            this.bron2Nazwa = bron2Nazwa;
        }

        public String getBron3Nazwa()
        {
            return bron3Nazwa;
        }

        public void setBron3Nazwa(String bron3Nazwa)
        {
            this.bron3Nazwa = bron3Nazwa;
        }

        public int getBron1Mod()
        {
            return bron1Mod;
        }

        public void setBron1Mod(int bron1Mod)
        {
            this.bron1Mod = bron1Mod;
        }

        public int getBron2Mod()
        {
            return bron2Mod;
        }

        public void setBron2Mod(int bron2Mod)
        {
            this.bron2Mod = bron2Mod;
        }

        public int getBron3Mod()
        {
            return bron3Mod;
        }

        public void setBron3Mod(int bron3Mod)
        {
            this.bron3Mod = bron3Mod;
        }

        public String getWyp1Nazwa()
        {
            return wyp1Nazwa;
        }

        public void setWyp1Nazwa(String wyp1Nazwa)
        {
            this.wyp1Nazwa = wyp1Nazwa;
        }

        public String getWyp2Nazwa()
        {
            return wyp2Nazwa;
        }

        public void setWyp2Nazwa(String wyp2Nazwa)
        {
            this.wyp2Nazwa = wyp2Nazwa;
        }

        public String getWyp3Nazwa()
        {
            return wyp3Nazwa;
        }

        public void setWyp3Nazwa(String wyp3Nazwa)
        {
            this.wyp3Nazwa = wyp3Nazwa;
        }

        public int getWyp1Mod()
        {
            return wyp1Mod;
        }

        public void setWyp1Mod(int wyp1Mod)
        {
            this.wyp1Mod = wyp1Mod;
        }

        public int getWyp2Mod()
        {
            return wyp2Mod;
        }

        public void setWyp2Mod(int wyp2Mod)
        {
            this.wyp2Mod = wyp2Mod;
        }

        public int getWyp3Mod()
        {
            return wyp3Mod;
        }

        public void setWyp3Mod(int wyp3Mod)
        {
            this.wyp3Mod = wyp3Mod;
        }
        
        public int getOpanowanie()
        {
            return opanowanie;
        }

        public void setOpanowanie(int opanowanie)
        {
            this.opanowanie = opanowanie;
        }
        //Funkcje
        public String toString()
        {
            return " imie: " + imie;
        }

        public List<object> zwrocListe()
        {
            List<object> lista = new List<object>();
            lista.Add(id);
            lista.Add(imie);
            lista.Add(wiek);
            lista.Add(gracz);
            lista.Add(koncept);
            lista.Add(cnota);
            lista.Add(skaza);
            lista.Add(kronika);
            lista.Add(frakcja);
            lista.Add(nazwaGrupy);
            lista.Add(inteligencja);
            lista.Add(czujnosc);
            lista.Add(determinacja);
            lista.Add(sila);
            lista.Add(zrecznosc);
            lista.Add(wytrzymalosc);
            lista.Add(prezentacja);
            lista.Add(manipulacja);
            lista.Add(opanowanie);
            lista.Add(dedukcja);
            lista.Add(informatyka);
            lista.Add(medycyna);
            lista.Add(nauka);
            lista.Add(okultyzm);
            lista.Add(polityka);
            lista.Add(rzemioslo);
            lista.Add(wyksztalcenie);
            lista.Add(bijatyka);
            lista.Add(bronBiala);
            lista.Add(bronPalna);
            lista.Add(prowadzenie);
            lista.Add(przetrwanie);
            lista.Add(skradanie);
            lista.Add(wysportowanie);
            lista.Add(zlodziejstwo);
            lista.Add(ekspresja);
            lista.Add(empatia);
            lista.Add(obycie);
            lista.Add(oszustwo);
            lista.Add(preswazja);
            lista.Add(polswiate);
            lista.Add(zatraszanie);
            lista.Add(zwierzeta);
            lista.Add(at1Nazwa);
            lista.Add(at2Nazwa);
            lista.Add(at3Nazwa);
            lista.Add(at4Nazwa);
            lista.Add(at5Nazwa);
            lista.Add(at6Nazwa);
            lista.Add(at7Nazwa);
            lista.Add(at8Nazwa);
            lista.Add(at9Nazwa);
            lista.Add(at1Wartosc);
            lista.Add(at2Wartosc);
            lista.Add(at3Wartosc);
            lista.Add(at4Wartosc);
            lista.Add(at5Wartosc);
            lista.Add(at6Wartosc);
            lista.Add(at7Wartosc);
            lista.Add(at8Wartosc);
            lista.Add(at9Wartosc);
            lista.Add(wada1Nazwa);
            lista.Add(wada2Nazwa);
            lista.Add(wada3Nazwa);
            lista.Add(wada4Nazwa);
            lista.Add(wada1Wartosc);
            lista.Add(wada2Wartosc);
            lista.Add(wada3Wartosc);
            lista.Add(wada4Wartosc);
            lista.Add(rozmiar);
            lista.Add(szybkosc);
            lista.Add(inicjatywa);
            lista.Add(obrona);
            lista.Add(pancerz);
            lista.Add(zdrowieMax);
            lista.Add(silaWoliMax);
            lista.Add(zdrowie);
            lista.Add(silaWoli);
            lista.Add(doswiadczenie);
            lista.Add(moralnosc);
            lista.Add(bron1Nazwa);
            lista.Add(bron2Nazwa);
            lista.Add(bron3Nazwa);
            lista.Add(bron1Mod);
            lista.Add(bron2Mod);
            lista.Add(bron3Mod);
            lista.Add(wyp1Nazwa);
            lista.Add(wyp2Nazwa);
            lista.Add(wyp3Nazwa);
            lista.Add(wyp1Mod);
            lista.Add(wyp2Mod);
            lista.Add(wyp3Mod);



            return lista;
        }
    }
}
