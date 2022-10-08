using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PC : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
         if(other.gameObject.name.Equals("PCerro"))
        {
            ScoreTextScript.coinAmount += 1;
            Destroy (other.gameObject);
        }
    }
}