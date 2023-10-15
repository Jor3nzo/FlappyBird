using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bird : MonoBehaviour
{
    public int score;
    public float jumpSpeed;
    Rigidbody2D rb;
    public float rotateScale;
    public TMP_Text scoreText;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }


        transform.eulerAngles = new Vector3(0,0, rb.velocity.y * rotateScale);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
    }

}
