using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");
        int a = 0;
        for (int i = 0; i > 10; i--)
        {
            print("i: " + i);
            for (int j = 0; j < 10; j++)
            {
                a += j;
            }
        }
        print(a);
        CountToTen();
        Countdown(5);
        ConstructAGrid(10, 10);
    }
    void CountToTen()
    {
        //Use a for loop to count from 1 to 10, including 1 and 10. Print each index value.
        for (int c = 1; c <= 10; c++)
        {
            print(c);
        }
    }
    void Countdown(int start)
    {
        //Use a for loop to count from start down to 0. Print each index value.
        for (int s = start; s > 0; s--)
        {
            print(s);
        }
    }
    void ConstructAGrid(int sizeX, int sizeY)
    {

        //Create a nested for loop, with an outer loop incrementing 
        //from -x to x and an inner loop incrementing from -y to y. 
        //In each iteration of the inner for loop, print the following 
        // "x: [value of x], y: [Value of y]"
        for (int x = -sizeX; x<= sizeX; x++)
        {
            for(int y = -sizeY; y<= sizeY; y++)
            {
                print("x: " + x + ", y:" + y);
            }
        } 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
