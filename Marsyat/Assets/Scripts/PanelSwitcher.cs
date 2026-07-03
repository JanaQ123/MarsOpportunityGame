using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] allPanels; // drag all 4 canvases/panels here once
    bool showDisc;
    public void ShowPanel(GameObject panelToShow)
    {
        foreach (GameObject panel in allPanels)
        {
            if (panelToShow == allPanels[0])
            {
                if (!showDisc)
                {
                    allPanels[3].SetActive(true);
                    break;
                }
                else
                {
                    allPanels[3].SetActive(false);
                    allPanels[0].SetActive(true);
                }

            }
            panel.SetActive(panel == panelToShow);
        }
    }

    public void Show()
    {
        showDisc =true;
    }
}