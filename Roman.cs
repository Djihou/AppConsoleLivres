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
            Console.WriteLine($"Le livre intitulé {Titre} a pour auteur {Auteur} et contient {NombrePages} pages.Son genre est {Genre}");
        }
    }
}
