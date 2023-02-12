using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadarBar : MonoBehaviour
{
    public Image radarBarImage; // displays on top of the black bar, drag and drop radarBarInner to this image.
    public float currentStamina = 1.0f;
    public bool recharging = false;
    public bool disabled = false;

    public void Scan(float stamina)
    {
        if (disabled) // when stamina hits 0, disable use of stamina 
        {
        /****** NEED TO DISABLE OTHER FEATURES AS WELL; DONT SHOW RADAR ON, DONT SHOW DISTANCE, ETC. ******/
            Debug.Log("Out of Stamina!");
            Recharge();
        }
        else
        {
            currentStamina -= stamina; // decrements stamina
        }
        if (currentStamina < 0.0f) // When stamina hits zero, disable radar and begin recharge
        {
            currentStamina = 0.0f;
            Debug.Log("Out of Stamina!");
            disabled = true;
        }
        radarBarImage.fillAmount = Mathf.Clamp(currentStamina, 0.0f, 1.0f);
    }
    public void Recharge()
    {
        if (currentStamina < 1.0f) // if stamina is less than 1, recharge by amount
        {
            currentStamina += 0.001f;
            Debug.Log("RECHARGING");
            radarBarImage.fillAmount = Mathf.Clamp(currentStamina, 0.0f, 1.0f);
        }
        else if (currentStamina >= 1.0f)
        {
            currentStamina = 1.0f;
            disabled = false;
            radarBarImage.fillAmount = Mathf.Clamp(currentStamina, 0.0f, 1.0f);
        }
    }
}
