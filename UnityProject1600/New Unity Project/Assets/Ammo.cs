using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {
    public int ammo = 1;

    // Use this for initalization
    void Start (){
        while(ammo < 12){
            ammo ++;
            print("loading round" + ammo);

        }
    }
}
