using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter (Collision collision)
    {
        GameObject player = GameObject.FindWithTag("Player");
        PlayerController pCntrl = player.GetComponent<PlayerController>();

        if (collision.gameObject.tag == "PickUpItem")
        {
            Destroy(collision.gameObject);
            pCntrl.AddPoint();
        }
    }


}
