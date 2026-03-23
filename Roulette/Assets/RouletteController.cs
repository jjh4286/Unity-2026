using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float startSpeed = 30f;
    public float decreaseRatio = 0.99f;
    float rotSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = startSpeed;
        }
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= decreaseRatio;
    }
}
