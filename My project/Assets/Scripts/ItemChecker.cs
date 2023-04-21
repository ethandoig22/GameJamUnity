using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemChecker : MonoBehaviour
{
    public float meatNum;
    public float brothNum;
    public float extraNum;

    public GameObject correctMeat;
    public GameObject correctBroth;
    public GameObject correctExtra;

    public GameObject meat1;
    public GameObject meat2;
    public GameObject meat3;
    public GameObject broth1;
    public GameObject broth2;
    public GameObject broth3;
    public GameObject extra1;
    public GameObject extra2;
    public GameObject extra3;

    public GameObject chickMeat;
    public GameObject beefMeat;
    public GameObject porkMeat;
    public GameObject chickBroth;
    public GameObject beefBroth;
    public GameObject vegBroth;
    public GameObject mushroom;
    public GameObject sheets;
    public GameObject egg;

    public GameObject meatCorrect;
    public GameObject brothCorrect;
    public GameObject extraCorrect;
    public GameObject Player;

    public enemySpawner ES;

    public float win;




    // Start is called before the first frame update
    void Start()
    {
        meatNum = Random.Range(1, 4);
        brothNum = Random.Range(1, 4);
        extraNum = Random.Range(1, 4);
        changeItemIMG();

    }

    // Update is called once per frame
    void Update()
    {
        if (win == 3)
        {
            SceneManager.LoadScene("Winning Scene");
        }
    }

    public void changeItemIMG()
    {
        switch (meatNum)
        {
            case 1:
                correctMeat = beefMeat;
                meat1.SetActive(true);
                break;

            case 2:
                correctMeat = chickMeat;
                meat2.SetActive(true);
                break;

            case 3:
                correctMeat = porkMeat;
                meat3.SetActive(true);
                break;
        }

        switch (brothNum)
        {
            case 1:
                correctBroth = beefBroth;
                broth1.SetActive(true);
                break;

            case 2:
                correctBroth = chickBroth;
                broth2.SetActive(true);
                break;

            case 3:
                correctBroth = vegBroth;
                broth3.SetActive(true);
                break;
        }

        switch (extraNum)
        {
            case 1:
                correctExtra = egg;
                extra1.SetActive(true);
                break;

            case 2:
                correctExtra = mushroom;
                extra2.SetActive(true);
                break;

            case 3:
                correctExtra = sheets;
                extra3.SetActive(true);
                break;
        }

        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject == correctMeat)
        {
            Destroy(collision.gameObject);
            meatCorrect.SetActive(true);
            win++;
        }

        if (collision.gameObject == correctBroth)
        {
            Destroy(collision.gameObject);
            brothCorrect.SetActive(true);
            win++;
        }

        if (collision.gameObject == correctExtra)
        {
            Destroy(collision.gameObject);
            extraCorrect.SetActive(true);
            win++;
        }
        else if(collision.gameObject != Player )
        {
            
        }
        else
        {
            ES.WrongChoice();
        }
        
    }
}
