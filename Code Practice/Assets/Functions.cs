using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Should print false since 25 is not greater than or equal to 200.
        GreaterThanOrEqualTo(25, 200);

        // Should print true since 4 is even.
        IsEven(4);

        // Should print A.
        GetLetterGrade(91);
        // Should print C.
        GetLetterGrade(75);

        //Create a new c sharp script and name it functions
        print("Kendrick");
        //Warm-Up: Write the code for a conditional statement that does the following:
        // 1) Create an int variable named score and set it equal to 70
        int score = 70;
        // 2) If the score is greater than 100, print "You won!"
        if (score > 100) 
        {
            print("You won!");
        }
        // 3) If the score is greater than 70, print "You're getting close!"
        else if (score > 70) 
        {
            print("You're getting close!");
        }
        // 4) If the score is greater than 40, print "Real progress"
        else if (score > 40) 
        {
            print("Real progress");
        }
        // 5) If the score is greater than or equal to zero, print "Keep trying!"
        else if (score >= 0) 
        {
            print("Keep trying!");
        }
        // 6) Otherwise, print "You lost, try again."
        else
        {
            print("You lost, try again.");
        }
        whatToWear(85);
        whatToWear(75);
        whatToWear(65);
        whatToWear(30);
        winner(50, 40);
        winner(40, 50);
        winner(50, 50);
    }
    void whatToWear(int temp2)
    {
        if (temp2 > 80)
        {
            print("It's hot outside. Wear shorts");
        }
        else if (temp2 > 70)
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
    }
    void GreaterThanOrEqualTo(int numOne, int numTwo)
    {
        // Use a conditional structure to print whether numOne is greater than or equal to numTwo.
        if (numOne >= numTwo)
        {
            print("true");
        }
        else
        {
            print("false");
        }
    }

    void IsEven(int num)
    {
        // Use conditionals to print whether num is even or odd (Hint: use % modulo operator)
        if (num % 2 == 0)
        {
            print("true");
        }
        else
        {
            print("false");
        }
    }

    void GetLetterGrade(float percentage)
    {
        // Use conditionals to print the equivalent letter grade of the given percentage.
        if (percentage >= 90)
        {
            print("A");
        }
        else if (percentage >= 80)
        {
            print("B");
        }
        else if (percentage >= 70)
        {
            print("C");
        }
        else if (percentage >= 60)
        {
            print("D");
        }
        else
        {
            print("F");
        }
    }

//Write a function that determines if Team A won, Team B won, or if it was a tie. Then call it in the start method
// using different values such  that Team A wins. Team B wins, and they tie

void winner(int scoreA, int scoreB)
    {
        if (scoreA == scoreB)
        {
            print("Teams Tied!");
        }
        else if (scoreA > scoreB)
        {
            print("Team A Wins!");
        }
        else if (scoreB > scoreA)
        {
            print("Team B Wins!");
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
