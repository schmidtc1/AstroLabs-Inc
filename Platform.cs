using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public float distance;
    public float timer;

    public bool moveX = true, moveY = false, moveZ = false;
    private float xR = 1.0f, yR = 0.0f, zR = 0.0f;

    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        //Q1.1) What would happen if we didnt save this? (see Q1.2)
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Q1.2) Why would we add start?
        if (moveX)
            xR = 1.0f;
        else
            xR = 0.0f;

        if (moveY)
            yR = 1.0f;
        else
            yR = 0.0f;

        if (moveZ)
            zR = 1.0f;
        else
            zR = 0.0f;

        gameObject.transform.position = start + new Vector3(distance * Mathf.Cos(timer * speed) * Mathf.Sin(timer * speed) * xR, distance * Mathf.Sin(timer * speed) * Mathf.Sin(timer * speed) * yR, distance * Mathf.Cos(timer * speed) * zR);
        timer += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = null;
        }
    }
}
