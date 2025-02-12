using UnityEngine;


public class NekoScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    private LogicScript logic;
    private bool isNekoAlive = true;
    public static bool gameStarted = false;
    [SerializeField] private Animator NekoAnimator;
    [SerializeField] AudioManager audioManager;
    
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && isNekoAlive)  {
               if (!gameStarted)
            {
                myRigidbody.gravityScale = 4.5f; 
                logic.tutorialSet();
                gameStarted = true;
            }
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            NekoAnimator.SetTrigger("flap");
            audioManager.flapSound();
        } 
        if(transform.position.y > 17 || transform.position.y < -20 ) {
            logic.gameOver();
            isNekoAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        audioManager.bonkSound();
        logic.gameOver();
        isNekoAlive = false;
    }
}
