using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for(int i = 0; i < gameObject.transform.childCount - 1; i++)
            {
                gameObject.transform.GetChild(i).GetComponent<Renderer>().enabled = false;
            }

            GetComponent<Renderer>().enabled = false;
        }
    }
}