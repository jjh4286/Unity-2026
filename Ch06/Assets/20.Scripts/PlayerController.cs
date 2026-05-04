/* using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float walkForce = 3f;
    float maxWalkSpeed = 1f;
    float jumpForce = 300f;
    Animator anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;

    Rigidbody2D rb;
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }
        if(rb.linearVelocityX < maxWalkSpeed)
        {
        rb.AddForce(transform.right * walkForce);
        }
        time += Time.deltaTime;
        if(rb.linearVelocityY != 0)
        {
            anim.SetBool("isJumping", true);
        }
        else if(time > animationPeriod)
        {
            anim.SetBool("isJumping", false);
        }
        // if(rb.linearVelocityY != 0)
        // {
        //     sr.sprite = jumpSprite;
        // }
        // if(time > animationPeriod)
        // {
        //     time = 0;
        //     sr.sprite = walkSprites[idx];
        //     idx ++;
        //     if(idx == walkSprites.Length)
        //     {
        //         idx = 0;
        //     }
        // }
    }
    private void OnTriggerEnter(Collider2D other)
    {
        Debug.Log("Gool");
        SceneManager.LoadScene("ClearScene");
    }
}*/
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float walkForce = 30f;
    float maxWalkSpeed = 5f;
    public float jumpForce = 300f;
    Animator anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;
    Rigidbody2D rb;
    int key = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        key = 0;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        if (key != 0)
        {
            if (key == -1) sr.flipX = true;
            else if (key == 1) sr.flipX = false;

            if(Mathf.Abs(rb.linearVelocityX) < maxWalkSpeed)
            {
                rb.AddForce(transform.right * key * walkForce);
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(Mathf.Abs(rb.linearVelocityY) < 0.01f) 
            {
                rb.AddForce(transform.up * jumpForce);
            }
        }

        if(Mathf.Abs(rb.linearVelocityY) > 0.01f)
        {
            anim.SetBool("isJumping", true);
        }
        else 
        {
            anim.SetBool("isJumping", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Gool");
        SceneManager.LoadScene("ClearScene");
    }
}