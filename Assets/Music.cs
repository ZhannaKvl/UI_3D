using UnityEngine;
using System;

public class Music : MonoBehaviour
{
    public AudioClip defaultClip; 
    public AudioClip collisionClip; 

    private AudioSource audioSource;

    // Оголошення івенту
    public static event Action BallCollisionEvent;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = defaultClip; 
        audioSource.playOnAwake = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            audioSource.Stop();
            audioSource.clip = collisionClip;
            audioSource.Play();

            BallCollisionEvent?.Invoke();
        }
    }
}
