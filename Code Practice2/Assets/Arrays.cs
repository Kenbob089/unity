using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");
        string[] groceries = { "Lemons", "Aluminum Foil", "Ice Cream" };
        string[] groceriesTwo = groceries;

        groceries[1] = "Ice  Cream";
        groceriesTwo[1] = "Ice Cream";

        groceries = new string[] { "Lemons", "Aluminum Foil", "Ice Cream" };

        print(groceries[1]);

        int num = 0;
        int numTwo = num;

        num++;
        print(numTwo);
        int[] array1 = { 9, 24, 13, 18, 11 };
        LinearSearch(array1, 13);
    }

    void LinearSearch(int[] array, int value)
    {
        // Sarch through numbers until finding value. Once value is found print white it was found.
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                print(i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
