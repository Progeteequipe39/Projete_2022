using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetavelCodigo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("codigo"))
        {
            ScoreTextScript.coinAmount += 1;
            Destroy (collision.gameObject);
        }
    }
}
