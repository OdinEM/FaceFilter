using UnityEngine;

public class PanelNavigator : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject infoPanel;

    public void ShowMainPanel()
    {
        mainPanel.SetActive(true);
        infoPanel.SetActive(false);
    }
}
