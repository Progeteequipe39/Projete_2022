using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Speed;
    public float JumpForce;

    public bool isJumping;

    private Rigidbody2D rig;
   

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      Move(); 
      Jump(); 
    }
    
    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        float inputAxis = Input.GetAxis("Horizontal");

        if(inputAxis > 0)
        {
           transform.eulerAngles = new Vector2 (0f, 0f);
        }

          if(inputAxis < 0)
        {
           transform.eulerAngles = new Vector2 (0f, 180f);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && !isJumping)
        {

            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
          
        }
    }
}
