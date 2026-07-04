using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] allPanels; // drag all 4 canvases/panels here once
    bool showDisc;
    public void ShowPanel(GameObject panelToShow)
    {
        // Special case for panel 0
        if (panelToShow == allPanels[0])
        {
            print("i got 1");
            HideAllPanels();

            if (showDisc)
                allPanels[0].SetActive(true);
            else
                allPanels[3].SetActive(true);

            return;
        }

        // Normal behavior
        foreach (GameObject panel in allPanels)
        {
            panel.SetActive(panel == panelToShow);
        }
    }

    private void HideAllPanels()
    {
        foreach (GameObject panel in allPanels)
            panel.SetActive(false);
    }
    public void ShowDiscovery()
    {
        showDisc =true;
    }
}