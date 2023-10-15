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
    public float speed;
    public GameObject endScreen;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Pipe.speed = speed;
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
        Pipe.speed = 0;
        jumpSpeed = 0;
        Invoke("ShowMenu", 1f);
        
        //var currentScene = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(currentScene);
    }

    void ShowMenu()
    {
        endScreen.SetActive(true);
        scoreText.gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
    }

}
