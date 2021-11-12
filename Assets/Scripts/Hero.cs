using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Joystick joystick;
   [SerializeField] private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     private void Update()
    {
        Vector2 moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            anim.SetBool("isRun1", true);
        }
        else
        {
            anim.SetBool("isRun1", false);
        }
    }
     void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
