using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController player;
    [Space]
    [SerializeField] private float walkingSpeed = 2f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float jumpHeight = 1f;
    [SerializeField] private float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public float gravity = 9.81f;

    bool isGrounded;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }

        float hor = Input.GetAxis("Horizontal") * walkingSpeed;
        float ver = Input.GetAxis("Vertical") * walkingSpeed;
        
        Vector3 move = transform.right * hor + transform.forward * ver;

        player.Move(move * walkingSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        player.Move(velocity * Time.deltaTime);

        if(Input.GetButton("Jump") &&  isGrounded) 
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // формула прыжка:
                                                                 // корень из высоты умноженная на минус 2 и умноженная на гравитацию
        }
    } 
}
