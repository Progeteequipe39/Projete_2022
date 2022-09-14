using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel4 : MonoBehaviour
{
   public int motorCount;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("motor"))
        {
            Destroy(collision.gameObject);
            motorCount++;
        }
    }
}
