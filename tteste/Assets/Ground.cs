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
    void onCollisionEnter2D(Collision2D collisor)
    {
       if(collisor.gameObject.layer == 14)
       {
        Igor.isJumping = false;
       } 
    }

    void onCollisionExit2D(Collision2D collisor)
    {
       if(collisor.gameObject.layer == 14)
       {
        Igor.isJumping = true;
       } 
    }

}
