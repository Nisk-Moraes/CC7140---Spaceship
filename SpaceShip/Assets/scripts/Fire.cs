using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto colidido é um inimigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroi o inimigo
            Destroy(collision.gameObject);

            // Destroi o projetil
            Destroy(gameObject);
            GameManager.PlayerScore1 += 10;
        }
        if(GameManager.PlayerScore1 > 50)
        {
            SceneManager.LoadScene("vitoria");
        }
       
    }
}