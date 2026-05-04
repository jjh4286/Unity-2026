using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            Vector3 dir = new Vector3(0, 200, 20000);
            bamsongi.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}
