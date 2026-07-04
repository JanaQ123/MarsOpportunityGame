using UnityEngine;
using UnityEngine.Playables;
using System.Collections;

public class StartTimeLine : MonoBehaviour
{
    public PlayableDirector timeline;
    void Start()
    {
        timeline.Stop();
        timeline.gameObject.SetActive(false);
    }
    public void StartTimeline()
    {
        timeline.gameObject.SetActive(true);
        timeline.Play();
        gameObject.SetActive(false);

        Invoke("AfterTimeline",10f);
    }
    public void AfterTimeline()
    {
        print("i showed it");
        UIMessageController.Instance.ShowMessage(3);
    }
}


