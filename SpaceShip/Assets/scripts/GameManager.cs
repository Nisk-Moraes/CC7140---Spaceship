using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0; 
    public GUISkin layout;

    public float enemySpeedMultiplier = 1.0f; 

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Fase1")
            {
                PlayerScore1 = 0;
            }
            else
            {
                // Carrega a pontuação salva
                PlayerScore1 = PlayerPrefs.GetInt("PlayerScore", 0);
            }
    }



    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 200 - 12, 40, 100, 100), "Score: " + PlayerScore1);
    }
}
