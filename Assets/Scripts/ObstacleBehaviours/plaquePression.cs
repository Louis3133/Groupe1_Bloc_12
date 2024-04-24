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
    // Cette fonction est appel�e lorsque quelque chose entre en collision avec le collider de la plaque de pression
    private void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si l'objet qui entre en collision est le joueur 
        if (other.gameObject.CompareTag("Player"))
        {
            // R�cup�re tous les objets ayant le tag sp�cifi� pour la porte
            //GameObject[] pieges = GameObject.FindGameObjectsWithTag(trapTag);

            // Parcourt tous les objets trouv�s
            foreach (GameObject piege in pieges)
            {
                Debug.Log(piege);
                // D�truit chaque piege
                Destroy(piege);
            }
        }
    }
}