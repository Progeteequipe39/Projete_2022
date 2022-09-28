using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarFase : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
         if(other.gameObject.name.Equals("codigo"))
        {
            ScoreTextScript.coinAmount += 1;
            Destroy (other.gameObject);
        }
    }
}


   


