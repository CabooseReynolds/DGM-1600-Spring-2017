using UnityEngine;
using System.Collections;

    public class Move : MonoBehaviour {

        public int moveSpeed = 10;

        //Use this for initilization
        void Start () {

        }

        // Update is called once per frame
        void Update () {
            /* Transform tran = transform;
            transform.position = new Vector3(0,0,moveSpeed); */

            if(Input.GetButton("Fire1")){
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);  }

        }
    }