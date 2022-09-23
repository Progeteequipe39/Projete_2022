using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel2 : MonoBehaviour
{
   public int desfibriladorCount;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("desfibrilador"))
        {
            Destroy(collision.gameObject);
            desfibriladorCount++;
        }
    }
}
