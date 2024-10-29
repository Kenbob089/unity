using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("kendrick");
        int a = 1;
        int b = 5;
        print(a < b); //Figure out a and b so this evaluates to True

        int c = 8;
        int d = 7;
        print(c >= 8 && d != 8); //Figure out c and d so this evaluates to True

        int x = 8;
        int y = 23;
        print(x == 7 || y <= 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
