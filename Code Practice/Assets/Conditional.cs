using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Conditional : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");

        //Conditional statements are one way programs "Think" or make decisions

        bool condition = true;
        if (condition)
        {
            print("Do this code");
        }

        //Choose a value for score that will make the print statement run
        int score = 60;
        if (score > 50)
        {
            print("You won");
        }

        //Write an if statement that will determine if a number is even.
        int num = 8;
        if (num % 2 == 0)
        {
            print("The number is even");
        }
        //Else Statements - if the first condition doesnt work out we still might want to do something

        //Write and if - statement that print when a number is even or odd
        int num2 = 7;
        if (num2 % 2 == 0)
        {
            print("The number is even");
        }
        else
        {
            print("The number is odd");
        }
        //Make an if else statement that tells you whether or not the water is boiling based on temperature. Water boils at 100 deg c
        int temp = 42;
        if (temp >= 100)
        {
            print("The water is boiling");
        }
        else
        {
            print("The water is not boiling");
        }
        //Many times there are many situation we want to check - use else - if statements!

        //Write and else -if statement that prints 1) "It's hot outside. Wear shorts" if it's abhove 80 deg
        //2) "it's warm outside. No Jacket needed" if the temp is above 70 deg
        //3) "It's getting chilly. Wear a jacket" if the temp is above 60 deg
        //Otherwise it should print "It's cold outside. Wear a heavy jacket"

        int temp2 = 88;
        if(temp2 > 80)
        {
            print("It's hot outside. Wear shorts");
        }
        else if(temp2 > 70)
        {
            print("it's warm outside. No Jacket needed");
        }
        else if (temp2 > 60)
        {
            print("It's getting chilly. Wear a jacket");
        }
        else
        {
            print("It's cold outside. Wear a heavy jacket");
        }
        //it works for boolean operators too!

        int temp3 = 85;
        string weather = "Sunny";

        if(temp3<70 || weather == "Rainy")
        {
            print("Wear a jacket");
        }
        else if (temp3 > 80 && weather == "Sunny")
        {
            print("Put on sunblock");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
