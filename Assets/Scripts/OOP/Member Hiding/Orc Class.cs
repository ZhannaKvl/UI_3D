using UnityEngine;
using System.Collections;

public class Orc : Enemy_
{
    //This hides the Enemy version.
    public override void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}