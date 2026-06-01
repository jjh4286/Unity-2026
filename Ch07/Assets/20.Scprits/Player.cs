using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float movespeed = 2.0f;
    public float rotateSpeed = 20.0f;
    public float shootingForce = 100f;
    public float shootingDelay = 1.5f;

    public GameObject bamsongiprefab;
    public Transform shootingPoint;

    Rigidbody rb;
    Animator anim;

    Vector3 moveDirection;

    float xInput;
    float zInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Fire");
            Shooting();
            return;
        }

        moveDirection = new Vector3(xInput, 0, zInput);

        if (moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            anim.SetBool("IsWalking", true);
            Vector3 move = new Vector3(0, 0, zInput);
            Rotate();
            rb.MovePosition(rb.position + zInput * moveDirection * movespeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }

    void Rotate()
    {
        float rotSpeed = xInput * rotateSpeed * Time.deltaTime;
        rb.rotation = Quaternion.Euler(0, rotSpeed, 0) * rb.rotation;

    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(shootingDelay);

        GameObject bamsongi = Instantiate(bamsongiprefab, shootingPoint.position, shootingPoint.rotation);

        Vector3 dir = shootingPoint.forward * shootingForce;
        bamsongi.GetComponent<BamsongiController>().Shoot(dir);

    }
}