using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRadar : MonoBehaviour
{
    private bool nearby;
    public float distance;
    private float maxDistance;
    private bool radarOn;
    public GameObject obj;
    public RadarBar radar;

    // Start is called before the first frame update
    void Start()
    {
        distance = 11.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (nearby && Input.GetKeyDown(KeyCode.R))
        {
            distance = Vector3.Distance(obj.transform.position, transform.position);
        }
        radar.Scan(distance);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Collectible")
        {
            nearby = true;
            obj = collider.gameObject;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Collectible")
        {
            nearby = false;
            distance = 11.0f;
            obj = null;
        } 
    }
}
