using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using System.Collections;

public class ScannableObject : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    private Renderer targetRenderer;
    private Material scanMat;
    private bool isHovered = false;
    private bool isScanned = false;
    [Header("Info Panel")]
    public GameObject infoPanel; // drag the info GameObject here
    public float infoDisplayDuration = 3f; // how long it stays visible
    PanelSwitcher switchPanel;
    void Awake()
    {
        switchPanel = GameObject.Find("RoverUI").GetComponent<PanelSwitcher>();
        interactable = GetComponent<XRSimpleInteractable>();
        targetRenderer = this.GetComponent<Renderer>();
        scanMat = targetRenderer.material; // instance copy
        interactable.hoverEntered.AddListener(_ => OnHoverEntered());
        interactable.hoverExited.AddListener(_ => OnHoverExited());

        if (infoPanel != null)
            infoPanel.SetActive(false); // make sure it starts hidden
    }

    void OnHoverEntered()
    {
        isHovered = true;
        // optional: if you kept a Highlighted property for pre-scan hover glow
    }

    void OnHoverExited()
    {
        isHovered = false;
    }

    public bool IsHovered => isHovered;
    public bool IsScanned => isScanned;

    public void TriggerScan()
    {
        if (isScanned) return;
        print("i am scanning now");
        StartCoroutine(ScanRoutine());
    }

    IEnumerator ScanRoutine()
    {
        switchPanel.Show();
        isScanned = true;
        float t = 0f, duration = 1.5f;
        float minVal = -0.9f, maxVal = 0.19f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float progress = Mathf.Lerp(minVal, maxVal, t / duration);
            scanMat.SetFloat("ScanProgress", progress);
            yield return null;
        }
        scanMat.SetFloat("ScanProgress", maxVal);

        // show info panel after scan completes
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
            yield return new WaitForSeconds(infoDisplayDuration);
            infoPanel.SetActive(false);
        }
    }
}