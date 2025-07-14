using UnityEngine;

public class InfoPanelController : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject bgPanel;

    // Call this from the Button's OnClick
    public void TogglePanel()
    {
        bool isActive = infoPanel.activeSelf;
        infoPanel.SetActive(!isActive);
        bgPanel.SetActive(isActive);
    }
}
