using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate three different instances of the fruit class each representing a different type of fruit
        //Use the second constructor to set the name and color of each fruit instance
        //For each instance print the result of the ToString() method

        Fruit banna = new Fruit("Banna", "Yellow");
        Fruit apple = new Fruit("Apple", "Green");
        Fruit orange = new Fruit("Orange", "Orange");

        print(banna.ToString());
        print(apple.ToString());
        print(orange.ToString());
    }
}
/* Create a new class called fruit
 * string name
 * string color
 * A default constructor method with no parameters
 * A second constructor method with two string parameters: One to set
 * the name and one to set the color of a new fruit instance.
 * A method called ToString() which returns a string containing the name of the fruit and its color
 * */

public class Fruit
{
    string name;
    string color;

    public Fruit()
    {

    }
    public Fruit(string _name, string _color)
    {
        name = _name;
        color = _color;
    }
    public string ToString()
    {
        return color + name;
    }

}