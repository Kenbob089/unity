using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedConditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kendrick");

        //Nested conditionalsn are conditionals inside of conditionals
        //change measurement of bloom so that:
        // 1) Only "Full grown flower" prints
        // 2) "Full grown flower" and Flower is ready to pick" both print
        // 3) Only "Flower is ready to pick" prints

        float measurement = 7.2f;
        string bloom = "Full";

        if (measurement > 5)
        {
            print("Full grown flower");
            if (bloom == "Full")
            {
                print("Flower is ready to pick");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
