using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, int nombrePages, string genre):base(titre, auteur, nombrePages)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Nombre de Pages : {NombrePages}, Genre : {Genre}");
        }
    }
}
