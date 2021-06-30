using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{
    public Renderer texture;
    public Material newmaterial, currentmaterial;


    private void Start()
    {
        currentmaterial = texture.material;
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
}
