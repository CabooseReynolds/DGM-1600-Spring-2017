using UnityEngine;
using System.Collections;

public class FallSpeed : MonoBehaviour {
    void Update() {
        float translation = Time.deltaTime * 10;
        transform.Translate(0, 0, translation);
    }
}