using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pipe : MonoBehaviour
{
    public static float speed;
    public float screenStartX;
    public float screenEndX;

    private void Start()
    {
        screenStartX = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0.5f)).x - 1;
        screenEndX = Camera.main.ViewportToWorldPoint(new Vector3(1f, 0.5f)).x + 1;
    }
    
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < screenStartX)
        {
            var height = Random.Range(-2, 4);

            transform.position = new Vector3(screenEndX,height);
        }
    }
    
}
