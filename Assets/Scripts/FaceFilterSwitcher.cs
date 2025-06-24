using UnityEngine;

public class FaceFilterSwitcher : MonoBehaviour
{
    public GameObject maskFilter;
    public GameObject hatFilter;
    public GameObject catNoseFilter;

    void Start()
    {
        // Hide all filters by default
        maskFilter.SetActive(false);
        hatFilter.SetActive(false);
        catNoseFilter.SetActive(false);
    }

    public void ActivateFilter(string filterName)
    {
        maskFilter.SetActive(filterName == "Mask");
        hatFilter.SetActive(filterName == "Hat");
        catNoseFilter.SetActive(filterName == "CatNose");
    }
}
