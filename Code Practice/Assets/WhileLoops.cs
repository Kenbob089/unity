using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");

        int x = 0;
        while (x < 10)
        {
            x++;
            print(x);
        }

        print("hello!");


        //Create a while loop that prints "You are alive." while your health is greater than zero.
        //Create a health integer variable that begins at 12
        //Create a count variable that counts how many time you go through the loop.
        //Print the count variable inside the loop
        //Decrease the health by one each time you go through the loop
        //Print "Game Over" once you are done the loop
        //How many times do you think the loop will run?
        int count = 0;
        int health = 12;
        while (health > 0)
        {
            count++;
            health--;
            print("You are Alive");
            print("Health: " + health);
            print("Count: " + count);
        }
        print("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
