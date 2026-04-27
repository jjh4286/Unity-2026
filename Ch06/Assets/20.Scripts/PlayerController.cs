using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float walkForce = 3f;
    float maxWalkSpeed = 1f;
    /*public*/ float jumpForce = 300f;
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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gool");
        SceneManager.LoadScene("ClearScene");
    }
}
