using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaquePression : MonoBehaviour
{
    public string trapTag = "piegeDesactivable";
    [SerializeField] GameObject[] pieges;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Cette fonction est appelée lorsque quelque chose entre en collision avec le collider de la plaque de pression
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet qui entre en collision est le joueur 
        if (other.gameObject.CompareTag("Player"))
        {
            // Récupère tous les objets ayant le tag spécifié pour la porte
            //GameObject[] pieges = GameObject.FindGameObjectsWithTag(trapTag);

            // Parcourt tous les objets trouvés
            foreach (GameObject piege in pieges)
            {
                Debug.Log(piege);
                // Détruit chaque piege
                Destroy(piege);
            }
        }
    }
}