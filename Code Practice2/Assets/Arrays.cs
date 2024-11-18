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
        ConatenationLoop();
        RandomArray(5);
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
    void ConatenationLoop()
    {
        //Interate through the words array, creating a signle long string with spaces between each word.
        //Hint: In the body of a for loop, add the current value of word at index to a string
        //then a space using  += " ";

        string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

        string finalString = "";
        for (int i = 0;i < words.Length;i++)
        {
            finalString = finalString + words[i] + " ";
        }
        print(finalString);
    }
    void RandomArray(int size)
    {
        //Declare and intinalize a new array of intergers with length [size]
        //interate through the array setting the value at each index to a random number between one and ten
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Range(1, 11);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
