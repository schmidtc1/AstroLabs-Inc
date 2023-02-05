using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityCheck : MonoBehaviour
{

    public Behaviour halo;
    public ParticleSystem beam;
    // Start is called before the first frame update
    void Start()
    {
        beam = gameObject.GetComponent<ParticleSystem>();
        beam.Stop();
        halo = gameObject.GetComponent<Behaviour>();
        halo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey("e"))
        {
            //beam.Play();
            halo.enabled = true;
        }
        else if (other.gameObject.tag == "Player" && !Input.GetKey("e")) {
            //beam.Stop();
            halo.enabled = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //beam.Stop();
        halo.enabled = false;
    }
}
