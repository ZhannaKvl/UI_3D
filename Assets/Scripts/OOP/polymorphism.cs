using UnityEngine;

public interface ISphere
{
    void InteractWithBush(Bush bush);
}

public class Bush : MonoBehaviour
{
    public void CreateBush()
    {
        Debug.Log("Creating a bush...");
    }
}

public class Sphere : MonoBehaviour, ISphere
{
    public void InteractWithBush(Bush bush)
    {
        Debug.Log("Interacting with a bush...");
        bush.CreateBush();
    }
}

public class polymorphism : MonoBehaviour
{
    public Bush bush;
    public ISphere[] spheres;

    void Start()
    {
        bush = GetComponent<Bush>();
        spheres = GetComponents<ISphere>();

        foreach (ISphere sphere in spheres)
        {
            sphere.InteractWithBush(bush);
        }
    }
}

