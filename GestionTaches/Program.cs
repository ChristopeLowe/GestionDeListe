
using GestionTaches;
class Program()
{
    

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Es ist Wahr, dass wir ihre Hilfe brauchen !");
        Console.WriteLine("Wie ist Ihre Name bitte ?");
        string Vorname = Console.ReadLine();
        Console.WriteLine($"{Vorname} Danke für Ihr Verständnis und Hilfe !");

        GestionnaireDeTaches gestionnaire = new GestionnaireDeTaches();  // Objet erstellen

        while (true)
        {
            Console.WriteLine("\n Menü");
            Console.WriteLine("1. Ajouter une Tache");
            Console.WriteLine("2. Supprimer une Tache");
            Console.WriteLine("3. Marquer Comme deja Faite");
            Console.WriteLine("4. Afficher toutes les Taches");
            Console.WriteLine("5. Quitter la Liste");
            Console.WriteLine("Wählen Sie eine Option aus : ");

            string wahl = Console.ReadLine();
            switch (wahl)
            {
                case "1":
                    Console.WriteLine("Entrez la description de la Tache :");
                    string description = Console.ReadLine();
                    gestionnaire.AjouterTaches(description);
                    break;

                case "2":
                    gestionnaire.AfficherTaches();
                    Console.WriteLine("Entrez l'index de la tache a supprimer :");
                    if (int.TryParse(Console.ReadLine(), out int indexSuppression))
                    {
                        gestionnaire.SupprimerTaches(indexSuppression);
                    }
                    else
                    {
                        Console.WriteLine("Entree est invalide !");
                    }
                    break;
                case "3":
                    gestionnaire.AfficherTaches();
                    Console.WriteLine("Entrez l'index a marquer comme deja fait :");
                    if(int.TryParse(Console.ReadLine(),out int indexMarquage))
                    {
                        gestionnaire.MarqueCommeFaite(indexMarquage);
                    }
                    else
                    {
                        Console.WriteLine("Entree est invalide !");
                    }
                    break;
                case "4":
                    gestionnaire.AfficherTaches();
                    break;
                case "5":
                    Console.WriteLine($" Aufwiedersehen {Vorname}");
                    break;
                default:
                    Console.WriteLine("Choix invalide ! Veuillez Reessayer Merci !");
                    break;
                    

            }

        }
        
        
    }

}