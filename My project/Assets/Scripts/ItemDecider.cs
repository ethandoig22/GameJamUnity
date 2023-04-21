using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDecider : MonoBehaviour
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
        
    }

    public void changeItemIMG()
    {
        switch (meatNum)
        {
            case 1:
                correctMeat = meat1;
                meat1.SetActive(true);
                break;

            case 2:
                correctMeat = meat2;
                meat2.SetActive(true);
                break;

            case 3:
                correctMeat = meat3;
                meat3.SetActive(true);
                break;
        }

        switch (brothNum)
        {
            case 1:
                correctBroth = broth1;
                broth1.SetActive(true);
                break;

            case 2:
                correctBroth = broth2;
                broth2.SetActive(true);
                break;

            case 3:
                correctBroth = broth3;
                broth3.SetActive(true);
                break;
        }

        switch (extraNum)
        {
            case 1:
                correctExtra = extra1;
                extra1.SetActive(true);
                break;

            case 2:
                correctExtra = extra2;
                extra2.SetActive(true);
                break;

            case 3:
                correctExtra = extra3;
                extra3.SetActive(true);
                break;
        }
    }
}
