using UnityEngine;

public class TargetController : MonoBehaviour
{
    GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        transform.LookAt(player.transform);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BamsongiController>() != null)
        {
            Destroy(gameObject);
        }
    }
}
