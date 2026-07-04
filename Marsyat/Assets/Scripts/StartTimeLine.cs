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

        StartCoroutine(AfterTimeline());
    }

    IEnumerator AfterTimeline()
    {
        // Wait until the timeline finishes
        yield return new WaitForSeconds((float)timeline.duration);

        // Wait 5 more seconds
        yield return new WaitForSeconds(5f);

        UIMessageController.Instance.ShowMessage(3);
    }
}


