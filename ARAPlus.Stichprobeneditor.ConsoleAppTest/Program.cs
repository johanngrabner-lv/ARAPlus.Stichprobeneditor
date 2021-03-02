using ARAPlus.Stichprobeneditor.BusinessLogic;
using ARAPlus.Stichprobeneditor.Models;
using ARAPlus.Stichprobeneditor.Repository.Contract;
using ARAPlus.Stichprobeneditor.Repository.Impl.MSSQLServer;
using System;

namespace ARAPlus.Stichprobeneditor.ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IRepo myRepo = new RepoMSSQL();
            //myRepo = new RepoWebApi();
            Artikel artikel = new Artikel();
            artikel.Absatzmenge = 20;
            artikel.ArtikelNummer = "absdsad";
            artikel.Bezeichnung = "Test von Hans";

          //  myRepo.AddArtikel(artikel);

            Artikel a1 = myRepo.GetArtikel(1);
            var alleArtikel = myRepo.GetArtikel();

            IStatistischeAuswahl logic = new AuswahlVariante();
            var stat = logic.GetAuswahl();




        }
    }
}
