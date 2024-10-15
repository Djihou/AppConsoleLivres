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
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Nombre de Page : {NombrePages}, Numero : {Numero}, Année : {Annee} ");
        }
    }
}
