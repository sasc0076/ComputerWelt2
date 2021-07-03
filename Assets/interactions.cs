using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{
    public Renderer texture;
    public Material newmaterial, currentmaterial;
    Transform beforepos;
    GameObject Player;
    private void Start()
    {
        currentmaterial = texture.material;
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void SelectTexture(bool active)
    {
        if (active)
        {
            texture.material = newmaterial;
        }
      
        if (!active)
        {
            texture.material = currentmaterial;
        }

    }

    public void BoxAppear(GameObject box)
    {
        box.SetActive(true);
    }

    public void BoxDisappear(GameObject box)
    {
        box.SetActive(false);

    }


    public void TeleportPlayer(Transform spawnpoint)
    {
        beforepos = Player.transform;
        Player.transform.position = spawnpoint.position;

    }

    public void TeleportBack()
    {
        Player.transform.position = beforepos.position;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
