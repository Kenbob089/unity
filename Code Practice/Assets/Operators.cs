using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 5;
        int b = 2;

        b = 5 + ++a;
        
        print(b);
        print("kendrick");
       // print(a += b); // 7
       // print(a -= b); // 5
       // print(a *= b); // 10
       // print(a / b); // 5
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
