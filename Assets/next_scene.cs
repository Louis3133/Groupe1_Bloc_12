
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassageScene : MonoBehaviour
{
    public string SceneToEdit_B0; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Vérifie si l'objet entré en collision est votre personnage
        {
            SceneManager.LoadScene(SceneToEdit_B0); // Charge la nouvelle scène
        }
    }
}
