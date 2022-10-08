using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private bool somOn;
    [SerializeField] Image AudioOn;
    [SerializeField] Image AudioOff;

    // Start is called before the first frame update
    void Start()
    {
        OnOff();
    }

   public void volumeDoJogo()
   {
    somOn =! somOn;
    if(somOn==false)
    {
        AudioListener.volume = 1;
    }
    else
    {
        AudioListener.volume = 0;
    }
    OnOff();
   }

   private void OnOff()
   {
    if(somOn == true)
    {
        AudioOn.enabled = true;
        AudioOff.enabled = false;
    }
    else
    {
        AudioOn.enabled = false;
        AudioOff.enabled = true;
    }
   }
}
