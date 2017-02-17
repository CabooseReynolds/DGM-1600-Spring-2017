using UnityEngine;
using System.Collections;

public class PoridgeCode : MonoBehaviour
{
    float PoridgeTemperature = 100.0f;
    float hotLimitTemperature = 90.0f;
    float coldLimitTemperature = 60.0f;
    
/* In this code, Goldilocks will be trying to eat PapaBears Poridge. We seehere that the temperature is set t 100.0f. 
Which is over the hot limit. So during this code it will see that the temperature is too hot for goldilocks and return a 
print of "Poridge is too hot. If the Poridge sad at below 60.0f it would return as too cold. but if the temperature sits
between 60.1f and 89.9f the code should read as "Pordige is just right. Goldilocks can then eat the poridge. */
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        PoridgeTemperature -= Time.deltaTime * 5f;
    }
    
    
    void TemperatureTest ()
    {
        // If the Poridge's temperature is greater than the hottest drinking temperature
        if(PoridgeTemperature > hotLimitTemperature)
        {
            // do this.
            print("Poridge is too hot.");
        }
        // If it isn't, but the Poridge temperature is less than the coldest drinking temperature
        else if(PoridgeTemperature < coldLimitTemperature)
        {
            // do this.
            print("Poridge is too cold.");
        }
        // If it is neither of those then
        else
        {
            // do this.
            print("Poridge is just right.");
        }
    }
}