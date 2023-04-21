using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Transform itemHolder;
    public LayerMask itemLayer;
    private GameObject currentItem = null;
    public Vector3 Offset;
    public AudioSource itemPickup;
    


    private void Start()
    {
        
    }
    void Update()
    {
        Offset = new Vector3(itemHolder.position.x + 5, itemHolder.position.y + 5, itemHolder.position.z);
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentItem == null)
            {
                Collider2D item = Physics2D.OverlapCircle(transform.position, 3f, itemLayer);
                if (item != null)
                {
                    currentItem = item.gameObject;
                    currentItem.transform.SetParent(itemHolder);
                    currentItem.transform.localPosition = Vector3.zero;
                    currentItem.GetComponent<Rigidbody2D>().simulated = false;
                    itemPickup.Play();
                }
            }
            else
            {
                currentItem.transform.SetParent(null);
                currentItem.GetComponent<Rigidbody2D>().simulated = true;
                currentItem.transform.position = Offset;
                currentItem = null;
                itemPickup.Play();
            }
        }
    }

    
}