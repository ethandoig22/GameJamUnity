using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 2f;
    public float stamBarNum;
    public float healthBarNum;
    public float Stamina = 200f;
    public float Health = 200f;
    public Rigidbody2D rb;
    public RectTransform Healthrt;
    public RectTransform Stamrt;
    public AudioSource wingFlap;
    public AudioSource Collided;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void EnemyHit()
    {
        Debug.Log("Hit");
        Health -= 80;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Collided.Play();
    }
    void Update()
    {
        if (Health <= 0)
        {
            SceneManager.LoadScene("Losing Screen");
        }
        stamBarNum = Stamina * 3;
        Stamrt.sizeDelta = new Vector2(stamBarNum, 100);
        if(Stamina < 200)
        {
            Stamina += 40 * Time.deltaTime;
        }

        healthBarNum = Health * 3;
        Healthrt.sizeDelta = new Vector2(healthBarNum, 100);
        if (Health < 200)
        {
            Health += 2 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.W) && Stamina >= 40)
        {
            rb.AddForce(Vector2.up * jumpForce * 2);
            Stamina -= 40;
            wingFlap.Play();
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * moveSpeed);
        }

        

            if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.A))
       {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 180, transform.rotation.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
        }




    }

    





}
