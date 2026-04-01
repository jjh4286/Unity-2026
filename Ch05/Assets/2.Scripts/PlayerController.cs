using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 0.1f;
    
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
    }
}
