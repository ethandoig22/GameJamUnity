using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutItem : MonoBehaviour
{
    public GameObject cutChick;
    public GameObject cutBeef;
    public GameObject cutPork;
    public GameObject Chick;
    public GameObject Beef;
    public GameObject Pork;
    public Vector2 beefSpawn;
    public Vector2 porkSpawn;
    public Vector2 chickSpawn;
    public AudioSource knifeCutting;

    public void Start()
    {
        beefSpawn = Beef.transform.position;
        porkSpawn = Pork.transform.position;
        chickSpawn = Chick.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Pork)
        {
            cutPork.transform.position = Pork.transform.position;
            Pork.transform.position = porkSpawn;
            knifeCutting.Play();
        }

        if (collision.gameObject == Chick)
        {
            cutChick.transform.position = Chick.transform.position;
            Chick.transform.position = chickSpawn;
            knifeCutting.Play();
        }

        if (collision.gameObject == Beef)
        {
            cutBeef.transform.position = Beef.transform.position;
            Beef.transform.position = beefSpawn;
            knifeCutting.Play();
        }
    }
}
