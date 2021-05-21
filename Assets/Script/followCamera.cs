using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform trans_camera;
    Vector3 newpos;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newpos =new Vector3(trans_camera.position.x, trans_camera.position.y-offset, trans_camera.position.z);
        this.transform.position = newpos;
    }
}
