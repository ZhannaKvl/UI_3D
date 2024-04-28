using UnityEngine;
using System.Collections;

public class FruitClass
{
    public FruitClass()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    // These methods are virtual and thus can be overridden
    // in child classes
    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}