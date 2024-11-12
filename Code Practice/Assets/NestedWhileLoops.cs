using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NestedWhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");
        //Warm Up: 1) Make a new C# script named NestedWhileLoops
        //2) Create a while loop that prints "You could still win." five times and 
        //after the loop it prints "You won!"

        int x = 0;
        while (x < 5)
        {
            print("You could still win");
            x++;
            print("You won!");

            //Nested while loops have a while llop inside a while loop.
            //The Loop on the inside will fully run for each iteration of the outside loop.

            int i = 0;
            while (i < 3)
            {
                int j = 0;
                print("B");
                i++;
                while (j < 2)
                {
                    print("A");
                    j++;
                }
            }
            CountToTen();
            CountToTwentyEven();
            CountToTwentyOdd();
            ALoopInALoop();
        }
    }

    void CountToTen()
    {
        //Construct a while loop to count from 1 to 10 (including 1 and 10). Print each index to the console.
        int y = 0;
        while (y < 10)
        {
            y++;
            print(y);
        }
    }
    void CountToTwentyEven()
    {
        int even = 0;
        while (even < 20)
        {
            even +=2;
            print(even);
        }
   
    }
    void CountToTwentyOdd()
    {
        int odd = 0;
        while (odd < 20)
        {
            if (odd % 2 == 1)
            {
                odd++;
                print(odd);
            }
        }
    }
    void ALoopInALoop()
    {
        int i = 0;
        while (i <100)
        {
            int j = 0;
            while (j < 10)
            {
                i++;
                j++;
                print(i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
