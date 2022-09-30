using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Speed;
    public float JumpForce;

    public bool NoChao;

    private Rigidbody2D rig;

    Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
           anim.SetBool("run",true);
           transform.eulerAngles = new Vector2 (0f, 0f);
        }

          if(inputAxis < 0)
        {
            anim.SetBool("run",true);
           transform.eulerAngles = new Vector2 (0f, 180f);
        }

        if(inputAxis == 0)
        {
            anim.SetBool("run",false);
            anim.SetBool("jump",false);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && NoChao)
        {

            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            NoChao = false;
            anim.SetBool("jump",true);
            anim.SetBool("run",false);
          
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            NoChao = true;
            anim.SetBool("jump",false);
        }
    }
}
