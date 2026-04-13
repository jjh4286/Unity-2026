using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject director;
    public float dropSpeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float minDistance = 1.1f;
    void Start()
    {
        player = GameObject.Find("player");
        //Find 주의사항 찾는 이름이 실제로 존재하는가, 2개 이상 존재하는가, 한번 찾으면 또 찾을 필요 없다
        director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        float distance = (p1 - p2).magnitude;
        if(distance < minDistance)
        {
            director.GetComponent<GameDirector>().DecreseHP();
            Destroy(gameObject);
        }
    }
}
