using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] allPanels; // drag all 4 canvases/panels here once

    public void ShowPanel(GameObject panelToShow)
    {
        foreach (GameObject panel in allPanels)
        {
            panel.SetActive(panel == panelToShow);
        }
    }
}