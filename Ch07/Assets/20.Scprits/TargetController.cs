using UnityEngine;

public class TargetController : MonoBehaviour
{
    GameObject player;
    TargetGenerate tg;
    private void Start()
    {
        player = GameObject.Find("Player");
        tg = GameObject.FindAnyObjectByType<TargetGenerate>();
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
            tg.GenerateTarget(player.transform.position);
            Destroy(gameObject);
        }
    }
}
