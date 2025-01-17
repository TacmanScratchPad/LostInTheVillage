using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CoverArea : MonoBehaviour
{
    private Cover[] covers;

    private Cover currentCover;

    private void Awake()
    {
        covers = GetComponentsInChildren<Cover>();
    }

    public Cover GetNearestCover(Vector3 agentLocation, Cover currentCover)
    {
        Cover nearestCover = null;
        float nearestDistance = Mathf.Infinity;

        if (covers.Length == 1) return covers[0];

        foreach (Cover cover in covers)
        {
            if (!cover.Equals(currentCover))
            {
                float distance = Vector3.Distance(agentLocation, cover.transform.position);

                if (distance < nearestDistance)
                {
                    nearestCover = cover;
                    nearestDistance = distance;
                }
            }
        }
        return nearestCover;
    }
}
