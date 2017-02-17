using UnityEngine;
using System.Collections;

public class PoridgeCode : MonoBehaviour
{
    float PoridgeTemperature = 100.0f;
    float hotLimitTemperature = 90.0f;
    float coldLimitTemperature = 60.0f;
    

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