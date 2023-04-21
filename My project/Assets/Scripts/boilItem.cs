using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boilItem : MonoBehaviour
{
    public GameObject chickBroth;
    public GameObject beefBroth;
    public GameObject vegeBroth;
    public GameObject chickCube;
    public GameObject beefCube;
    public GameObject vegeCube;
    public Vector2 beefCubeSpawn;
    public Vector2 vegeCubeSpawn;
    public Vector2 chickCubeSpawn;
    public AudioSource waterBoiling;

    public void Start()
    {
        beefCubeSpawn = beefCube.transform.position;
        vegeCubeSpawn = vegeCube.transform.position;
        chickCubeSpawn = chickCube.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == vegeCube)
        {
            vegeBroth.transform.position = vegeCube.transform.position;
            vegeCube.transform.position = vegeCubeSpawn;
            waterBoiling.Play();
        }

        if (collision.gameObject == chickCube)
        {
            chickBroth.transform.position = chickCube.transform.position;
            chickCube.transform.position = chickCubeSpawn;
            waterBoiling.Play();
        }

        if (collision.gameObject == beefCube)
        {
            beefBroth.transform.position = beefCube.transform.position;
            beefCube.transform.position = beefCubeSpawn;
            waterBoiling.Play();
        }
    }
}
