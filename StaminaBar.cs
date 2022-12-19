using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public float stamina;
    float maxStamina;
    public Component movement;
    public GameObject staminaUI;

    public Slider staminaBar;
    public float dValue;
    public bool isSprint;
    // Start is called before the first frame update
    void Start()
    {
        maxStamina = stamina;
        staminaBar.maxValue = maxStamina;
        
    }

    // Update is called once per frame
    void Update()
    {
        staminaUI.SetActive(false);
        isSprint = movement.GetComponent<Movement>().isWalk;

        if (Input.GetKey(KeyCode.LeftShift)&&isSprint==true)
        {
            DecreaseEnergy();
            
        }
        else if(stamina!=maxStamina)
        {
            IncreaseEnergy();
            
        }
        staminaBar.value = stamina; 
    }

    private void DecreaseEnergy()
    {
        staminaUI.SetActive(true);
        if (stamina!=0)
        {
            stamina -= dValue * Time.deltaTime;

        }
        if(stamina<=0)
        {
            stamina = 0;
        }
    }
    private void IncreaseEnergy()
    {
        staminaUI.SetActive(true);
        stamina += dValue * Time.deltaTime;
        if (stamina>=maxStamina)
        {
            stamina = maxStamina;
        }
        
    }
}
