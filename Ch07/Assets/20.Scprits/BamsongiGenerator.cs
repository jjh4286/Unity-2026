using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public float power;
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;
    public float minP = 10f;

    float startY;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            startY = Input.mousePosition.y;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            float power = Input.mousePosition.y - startY;
            if (power<minP) return;

            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;
            
            Vector3 dir = transform.forward + transform.up * 0.5f;
            bamsongi.GetComponent<BamsongiController>().Shoot(dir*power*throwForce);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //bamsongi.GetComponent<BamsongiController>().Shoot(ray.direction*2000);
        }
    }
}