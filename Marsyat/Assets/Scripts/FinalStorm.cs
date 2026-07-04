using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalStorm : MonoBehaviour
{
    public GameObject canvas;
    public ParticleSystem storm;

    private void Start()
    {
       storm.Stop();
        canvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!storm.isPlaying) storm.Play();
            canvas.SetActive(true);
        }

    }
}
