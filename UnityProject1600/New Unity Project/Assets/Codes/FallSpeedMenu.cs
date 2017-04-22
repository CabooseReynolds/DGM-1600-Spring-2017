using UnityEngine;
using System.Collections;

public class FallSpeedMenu : MonoBehaviour {
    void Update() {
    float translation = Time.deltaTime * 10;
        // transform.Translate(0, 0, translation);
        Destroy(gameObject, 8);    }
}