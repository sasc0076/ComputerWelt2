using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class screensaverScript : MonoBehaviour
{
    // Start is called before the first frame update
   public float timesince;
    interactions interact;
    public Transform screensaver;
    public GameObject particles;
    public GameObject screen_collider;

    private void Update()
    {
        timesince = timesince + Time.deltaTime;
        print(timesince);

        if(timesince > 120)
        {
            interact.TeleportPlayer(screensaver);
            particles.SetActive(true);
            screen_collider.SetActive(true);
        }
    }

    public void ActivityReset()
    {
        timesince = 0f;
    }    
}
