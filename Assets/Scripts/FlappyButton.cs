using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyButton : MonoBehaviour
{
    public string nextSceenName;


    void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;
    }

    void OnMouseUp()
    {
        transform.position += Vector3.up * 0.1f;
        if(nextSceenName != "")
        {
            SceneManager.LoadScene(nextSceenName);
           
        }
    }





   
}
