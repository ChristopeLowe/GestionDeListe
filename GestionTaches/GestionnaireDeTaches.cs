using System;

namespace GestionTaches;

public class GestionnaireDeTaches
{
    private List<Taches> taches= new List<Taches>();

    public void AjouterTaches( string _description)
    {
        Taches nouvellesTaches = new Taches(_description);
        taches.Add(nouvellesTaches);
        Console.WriteLine($" Taches '{_description}' Ajoutez.");
    }

    public void SupprimerTaches(int index)
    {
        if(index>=0 && index<taches.Count)
        {
            Console.WriteLine($"Taches {taches[index].Description} Supprimez.");
            taches.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Index Invalide...!");
        }
    }

    public void MarqueCommeFaite(int index)
    {
        if (index>=0 && index<taches.Count)
        {
            taches[index].MarqueCommeFaite();
            Console.WriteLine($"Taches {taches[index].Description} Marquez comme Faite.");
        }
        else
        {
            Console.WriteLine("Index Ungiltig..!");
        }
    }

    public void AfficherTaches()
    {
        if(taches.Count==0)
        {
            Console.WriteLine("Aucune Tache dans la Liste !");
        }
        else
        {
           // for(int i=0; i<taches.Count;i++)
           // {
           //     Console.WriteLine($"{i}. {taches[i]}");
           // }
           int index = 0;
           foreach(var tache in taches)
           {
                Console.WriteLine($"{index}. {tache}" );
                index++;
           }
        }
    }

}
