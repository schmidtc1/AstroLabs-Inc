using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Behaviour halo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey("e"))
        {
            halo.enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        halo.enabled = false;
    }
}
