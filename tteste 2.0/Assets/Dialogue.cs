using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
   public string[] speechTxt;
   public string actorName;
   bool caixa = false;

   public LayerMask playerLayer;
   public float radious;

   private DialogueControl dc;
   bool onRadious;

   private void Start()
   {
       dc = FindObjectOfType<DialogueControl>();
   }

private void FixedUpdate()
{
    Interact();
}

private void Update()
{
    if((caixa == false) && (Input.GetKeyDown(KeyCode.E) && onRadious))
    {
       dc.Speech(speechTxt);
       caixa = true;
    }
}

   public void Interact()
   {
      Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

      if(hit != null)
      {
          onRadious = true;
      }
      else{
          onRadious = false;
      }
   }

   private void OnDrawGizmosSelected()
   {
       Gizmos.DrawWireSphere(transform.position, radious);
   }
}
