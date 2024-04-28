using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid_ human = new Humanoid_();
        Humanoid_ enemy = new Enemy_();
        Humanoid_ orc = new Orc();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the correct overridden version of the Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}