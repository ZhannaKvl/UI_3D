using UnityEngine;
using System.Collections;

public class SomeOtherClassG : MonoBehaviour
{
    void Start()
    {
        SomeClassG myClass = new SomeClassG();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}