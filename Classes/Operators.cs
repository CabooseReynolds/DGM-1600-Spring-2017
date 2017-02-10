using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {
        public int valOne = 5;
        public int valTwo = 2;

        // use this for initilization
            void Start (){

            }

        // Update is called once per frame
        void update (){

            // Addition two variables together
            Debug.Log(valOne + valTwo);
            // Modulus
            Debug.Log(valOne % valTwo);
            //Subtracting two variables
            Debug.Log(valOne - valTwo);
            //Multiplcation of two variables
            Debug.Log(valOne * valTwo);
            //Division of two variables
            Debug.Log(valOne / valTwo);
            //Incremental growth of a variable
            Debug.Log(valOne ++);
            //Decremental shrinking of a variable
            Debug.Log(valTwo --);
        }
}