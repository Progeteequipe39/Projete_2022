using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel4 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("motor"))
        {
            ScoreTextScript.coinAmount += 1;
            Destroy (collision.gameObject);
        }
    }
}
