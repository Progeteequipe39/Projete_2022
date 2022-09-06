using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    Player Igor;
    // Start is called before the first frame update
    void Start()
    {
        Igor = gameObject.transform.parent.gameObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 8)
        {
            Igor.isJumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D collisor)
    {
       if(collisor.gameObject.layer == 8)
        {
            Igor.isJumping = true;
        }
    }
}
