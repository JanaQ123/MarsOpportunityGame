using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIMessageController : MonoBehaviour
{
    public static UIMessageController Instance;

    public Image displayImage;
    public Sprite[] messages;

    [SerializeField] private float fadeDuration = 0.5f;
    [SerializeField] private float displayDuration = 3f;

    private Coroutine currentMessage;

    void Awake()
    {
        Instance = this;

        // Start hidden
        Color c = displayImage.color;
        c.a = 0;
        displayImage.color = c;
        ShowMessage(0);
    }

    public void ShowMessage(int index)
    {
        if (currentMessage != null)
            StopCoroutine(currentMessage);

        currentMessage = StartCoroutine(ShowMessageRoutine(index));
    }

    private IEnumerator ShowMessageRoutine(int index)
    {
        displayImage.sprite = messages[index];

        // Fade in
        yield return Fade(0f, 1f);

        // Stay visible
        yield return new WaitForSeconds(displayDuration);

        // Fade out
        yield return Fade(1f, 0f);

        currentMessage = null;
    }

    private IEnumerator Fade(float startAlpha, float endAlpha)
    {
        float elapsed = 0f;

        Color c = displayImage.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            c.a = Mathf.Lerp(startAlpha, endAlpha, elapsed / fadeDuration);
            displayImage.color = c;
            yield return null;
        }

        c.a = endAlpha;
        displayImage.color = c;
    }
}