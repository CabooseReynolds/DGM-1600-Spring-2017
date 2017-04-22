using UnityEngine;
 
using System.Array;
 

 
public class SamplesArray2  : MonoBehaviour{
 

 
   public static void Main()  {
 
      // Creates and initializes the source Array.
 
      Array myArrayZero=Array.CreateInstance( typeof(String), 3 );
 
      myArrayZero.SetValue( "zero", 0 );
 
      myArrayZero.SetValue( "one", 1 );
 

 
      // Displays the source Array.
 
      Console.WriteLine( "The array with lower bound=0 contains:" );
 
      PrintIndexAndValues( myArrayZero );
 

 
      // Creates and initializes the target Array.
 
      int[] myArrLen = { 4 };
 
      int[] myArrLow = { 2 };
 
      Array myArrayTwo=Array.CreateInstance( typeof(String), myArrLen, myArrLow );
 
      myArrayTwo.SetValue( "two", 2 );
 
      myArrayTwo.SetValue( "three", 3 );
 
      myArrayTwo.SetValue( "four", 4 );
 
      myArrayTwo.SetValue( "five", 5 );
 

 
      // Displays the target Array.
 
      Console.WriteLine( "The array with lower bound=2 contains:" );
 
      PrintIndexAndValues( myArrayTwo );
 

 
      // Copies from the array with lower bound=0 to the array with lower bound=2.
 
      myArrayZero.CopyTo( myArrayTwo, 3 );
 

 
      // Displays the modified target Array.
 
      Console.WriteLine( "\nAfter copying to the target array from index 3:" );
 
      PrintIndexAndValues( myArrayTwo );
 
   }
 

 

 
   public static void PrintIndexAndValues( Array myArray )  {
 
      for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
 
         Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
 
   }
 
}