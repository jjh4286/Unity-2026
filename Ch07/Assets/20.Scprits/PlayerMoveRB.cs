using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMoveRB : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 1f;
    private Rigidbody rb;
    //rigidbody를 사용하는 것이 더욱 효과적
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * rotationSpeed * Time.deltaTime;
        float zSpeed = zInput * moveSpeed * Time.deltaTime;

        transform.Translate(0, 0, zSpeed);
        transform.Rotate(0, xSpeed, 0);
        rb.linearVelocity = zSpeed * transform.forward;
    }
}
