using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ÁreaDescarte : MonoBehaviour
{
    bool hayPortal;
    GameObject elPortal;

    private CreatePortal createPortal;

    private void Start()
    {
        createPortal = FindAnyObjectByType<CreatePortal>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Portal"))
        {
            hayPortal = true;
            elPortal = collision.gameObject;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Portal"))
        {
            hayPortal = false;
            elPortal = null;
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && hayPortal)
        {
            Destroy(elPortal);
            createPortal.RestarPortales();
        }
    }
}
