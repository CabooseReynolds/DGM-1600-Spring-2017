using UnityEngine;
using System.Collections;

public class FallSpeed : MonoBehaviour {
    void Update() {
        float translation = Time.deltaTime * -2;
       transform.Translate(0, translation, 0);
        Destroy(gameObject, 8);
    }
}