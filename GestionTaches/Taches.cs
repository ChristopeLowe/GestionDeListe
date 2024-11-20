using System;
/*Créez un programme pour gérer une liste de tâches. Définissez une classe 
Tâche avec une propriété Description et une méthode MarquerCommeFaite. 
Permettez à l’utilisateur d’ajouter, de supprimer, et de marquer des tâches comme faites.*/

namespace GestionTaches;

public class Taches
{
    public string Description { get; set; }
    public bool EstFait { get; private set; }

    public Taches (string _description)
    {
        Description = _description;
        EstFait = false;
    }

    public void MarqueCommeFaite()
    {
        EstFait = true;
    }

    public override string ToString()
    {
        string statut = EstFait ? "✓" : "✗";
        return $"[{statut}] {Description}";
    }

    
}
