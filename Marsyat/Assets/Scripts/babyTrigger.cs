using UnityEngine;

public class babyTrigger : MonoBehaviour
{
    //public ParticleSystem storm;
    //MessageMessageManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           // MessageMessageManager.Instance.ShowMessage(1);
            UIMessageController.Instance.ShowMessage(2);
            print("showing error");

           // if (!storm.isPlaying) storm.Play();
        }

    }
}

