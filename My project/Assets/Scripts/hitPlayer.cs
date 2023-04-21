using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
    public PlayerManager PM;
    public GameObject Player;

    public void Start()
    {
        Player = GameObject.Find("Player");
        PM = Player.GetComponent<PlayerManager>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("player"))
        {
            
            PM.EnemyHit();
            Destroy(gameObject);
        }
    }
}
