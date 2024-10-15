using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

        public Revue (string titre, string auteur, int nombrePages,int numero, int annee): base (titre, auteur, nombrePages)
        { 
            Numero = numero;
            Annee = annee;
        }

        public override void AfficherDetails()
        {
        Console.WriteLine($"Le livre intitulé {Titre} a pour auteur {Auteur} et contient {NombrePages} pages.Son identifiant est le {Numero} de l'année {Annee} ");
        }
    }
}
