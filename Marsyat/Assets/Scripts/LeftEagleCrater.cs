using UnityEngine;

public class LeftEagleCrater : MonoBehaviour
{
    public ParticleSystem storm;
    MessageMessageManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MessageMessageManager.Instance.ShowMessage(1);
            UIMessageController.Instance.ShowMessage(1);

            if (!storm.isPlaying) storm.Play();
        }
       
    }
}

