using UnityEngine;

public class TargetController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BamsongiController>() != null)
        {
            Destroy(gameObject);
        }
    }
}
