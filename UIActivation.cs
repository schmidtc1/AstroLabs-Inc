using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class UIActivation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mesh;
    private Image img;

    public bool imgState;
    private float imgTime;
    void Start()
    {
        img = GetComponent<Image>();
        img.enabled = false;
        imgState = false;
        imgTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!mesh.GetComponent<Renderer>().enabled)
        {
            img.enabled = true;
            imgState = true;
        }

        if (imgState)
        {
            imgTime += Time.deltaTime;
            if (imgTime >= 5.0f)
            {
                imgState = false;
                img.enabled = false;
            }
        }
    }

}
