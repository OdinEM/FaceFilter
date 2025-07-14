using UnityEngine;

public class FilterSpawner : MonoBehaviour
{
    public GameObject maskPrefab;
    public GameObject catNosePrefab;
    public GameObject hatPrefab;

    public Transform faceAnchor;  // The anchor where filters should attach

    private GameObject currentFilter;

    public void ShowMask()
    {
        SpawnFilter(maskPrefab);
    }

    public void ShowCatNose()
    {
        SpawnFilter(catNosePrefab);
    }

    public void ShowHat()
    {
        SpawnFilter(hatPrefab);
    }

    private void SpawnFilter(GameObject prefab)
    {
        if (currentFilter != null)
        {
            Destroy(currentFilter);
        }

        currentFilter = Instantiate(prefab, faceAnchor);
        currentFilter.transform.localPosition = Vector3.zero;
        currentFilter.transform.localRotation = Quaternion.identity;
    }
}
