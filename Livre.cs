using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur{ get; set; }
        public int NombrePages { get; set; }


        public Livre (string titre, string auteur, int nombrePage)
        {  Titre = titre; 
            Auteur = auteur; 
            NombrePages = nombrePage;
        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Le livre intitulé {Titre} a pour auteur {Auteur} et contient {NombrePages} pages");

        }
    }
}
