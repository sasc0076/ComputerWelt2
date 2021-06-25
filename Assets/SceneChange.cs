using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   // public string WeltName;
    // Start is called before the first frame update
public void ChangeScene(string weltName)
    {
        SceneManager.LoadScene(weltName);
    }
}
