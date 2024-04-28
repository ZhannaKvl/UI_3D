using UnityEngine;

public class FloorMusic : MonoBehaviour
{
    public AudioClip victoryClip; // Аудіокліп для виграшу
    public AudioClip lossClip;    // Аудіокліп для програшу

    private AudioSource audioSource;
    private Rigidbody sphereRigidbody;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = lossClip;
        audioSource.playOnAwake = false;

        sphereRigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Sphere"))
        //{
        //    string platformTag = gameObject.tag;

        //    if (platformTag == "VictoryPlatform")
        //    {
        //        audioSource.clip = victoryClip;
        //        audioSource.Play();
        //    }
        //    else if (platformTag == "LossPlatform")
        //    {
        //        audioSource.clip = lossClip;
        //        audioSource.Play();
        //    }
        //}
        //змінимо на тернарного оператора
        if (collision.gameObject.CompareTag("Sphere"))
        {
            string platformTag = gameObject.tag;

            AudioClip clipToPlay = platformTag == "VictoryPlatform" ? victoryClip : lossClip;

            audioSource.clip = clipToPlay;
            audioSource.Play();
        }
    }


}