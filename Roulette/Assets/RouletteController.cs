using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float rotSpeed = 0;
    void Start()
    {
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
    }
    transform.Rotate(0, 0, this.rotSpeed);
}
