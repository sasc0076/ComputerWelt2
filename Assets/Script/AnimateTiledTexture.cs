using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTiledTexture : MonoBehaviour
{
    public int columns;
    public int rows;
    public float framesPerSecond = 10f;
    public bool reset;

    //the current frame to display
    private int index = 0;

    void Start()
    {
        StartCoroutine(updateTiling());

    }

    private IEnumerator updateTiling()
    {
        while (true)
        {
            //move to the next index
            index++;
            if (index >= rows * columns || reset)
                index = 0;
            /*   if (reset)
               {
                   index = 0;
                   reset = !reset;
               } */

    
            //split into x and y indexes
            Vector2 offset = new Vector2((float)index / columns - (index / columns), //x index
                                          (index / columns) / (float)rows);          //y index

            GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);

            yield return new WaitForSeconds(1f / framesPerSecond);


            //set the tile size of the texture (in UV units), based on the rows and columns
            Vector2 size = new Vector2(1f / columns, 1f / rows);
            GetComponent<Renderer>().sharedMaterial.SetTextureScale("_MainTex", size);
        }

    }
}
