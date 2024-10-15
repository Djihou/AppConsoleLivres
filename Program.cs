using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        //Création de trois instances de la classe Roman
        Roman rom1 = new("Une âme pour deux", "Kouam", 10, "drame");
        Roman rom2 = new("Remading Fab", "Kouam", 15, "trailer");
        Roman rom3 = new("love Angel", "Hertz", 16, "Romance");
        //Affichage
       /* rom1.AfficherDetails();
        rom2.AfficherDetails();
        rom3.AfficherDetails();*/

        // Création des trois instances de la classe Revue
        Revue revue1 = new("À bâbord", "Louise Nachet", 63, 100, 2024);
        Revue revue2 = new("XYZ", "Christiane Lahaie", 100, 157, 2024);
        Revue revue3 = new("3 prétendant un mari", "Dubois", 800, 03, 2000);
        //Affichage
       /* revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();*/

       //Création de la liste générique de type livre
        List <Livre> livres = new List<Livre>();

        //Ajout des objets crées de la classe Revue et Roman dans la liste
        livres.Add(rom1);
        livres.Add(rom2);
        livres.Add(rom3);
        livres.Add (revue1);
        livres.Add (revue2);
        livres.Add (revue3);

        //Parcours de la liste pour affichage des details de ses éléments
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }
    }
}