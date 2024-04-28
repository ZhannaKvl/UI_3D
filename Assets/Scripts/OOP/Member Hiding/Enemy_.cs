using UnityEngine;
using System.Collections;

public class Enemy_ : Humanoid_
{
    //This hides the Humanoid version.
    public override void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}