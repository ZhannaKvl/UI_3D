using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject Sphere;

    public GameObject settingsMenu;

    public void OnClick()
    {
        if (!isPaused)
        {
            Time.timeScale = 0; 
            isPaused = true; 
            settingsMenu.SetActive(true); 
            if (Sphere != null)
            {
                Rigidbody rb = Sphere.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
        else
        {
            Time.timeScale = 1; 
            isPaused = false; 
            settingsMenu.SetActive(false); 
        }
    }
}
