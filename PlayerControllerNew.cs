using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControllerNew : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float speed;
    public float jumpforce;

    public Text livesText;
    public Text loseText;
    public Text scoreText;
    public Text winText;
    private int score;
    private int lives;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioSource musicSource;
    private bool facingRight = true;
    Animator anim;




    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        winText.text = "";
        loseText.text = "";

        score = 0;
        SetScoreText();
        lives = 3;
        SetLivesText();

        musicSource.clip = musicClipOne;
        musicSource.Play();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
         float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb2d.AddForce(movement * speed);

        if (facingRight == false && moveHorizontal > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveHorizontal < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x = Scaler.x * -1;
        transform.localScale = Scaler;
    }


    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        anim.SetInteger("State", 1);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            anim.SetInteger("State", 1);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            anim.SetInteger("State", 0);

        if (Input.GetKeyUp(KeyCode.RightArrow))
            anim.SetInteger("State", 0);

        if (Input.GetKeyUp(KeyCode.UpArrow))
                             
            anim.SetInteger("State", 0);

        if (lives <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ((collision.collider.tag == "Ground") || (collision.collider.tag == "Platform"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {

                rb2d.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);

                anim.SetInteger("State", 2);
            }

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);

            lives = lives - 1;
            SetLivesText();
        }
        if (other.gameObject.CompareTag("Win"))
        {
            other.gameObject.SetActive(false);
            musicSource.clip = musicClipTwo;
            musicSource.Play();            
        }
        if (other.gameObject.CompareTag("Health"))
        {
            other.gameObject.SetActive(false);

            lives = 3;
            SetLivesText();
        }
        
    }

   
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
            if (score >= 8)
            winText.text = "You win!";

        if (score == 4)
        rb2d.transform.position = new Vector3(18f, 1f, 0f);
        

    }

    void SetLivesText()
    {
        livesText.text = "lives: " + lives.ToString();
        if (lives <= 0)
        {
            loseText.text = "You Lose!";
        }

        
    }
}
      
