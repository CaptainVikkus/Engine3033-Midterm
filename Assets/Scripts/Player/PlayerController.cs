using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput input;
    private CharacterController character;

    #region Movement
    [Header("Movement")]
    public float speed = 5.0f;
    public float rotateSpeed = 15.0f;
    public float jumpHeight = 5.0f;
    public float gravity = -30.0f;
    public Transform body;
    public float groundRadius = 0.25f;
    public LayerMask groundMask;

    private bool jumping = false;
    private Vector3 velocity;
    private Vector2 movement;
    #endregion

    public AnimationManager animationManager;

    private void Awake()
    {
        input = new PlayerInput();
        input.Movement.Walk.performed += _ => movement = _.ReadValue<Vector2>();
    }
    private void OnEnable()
    {
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(body.position, groundRadius);
    }

    //Change Skybox color
    private void ChangeColor(COLOR color)
    {
        switch (color)
        {
            case COLOR.RED:
                RenderSettings.skybox.color = Color.red;
                break;
            case COLOR.GREEN:
                RenderSettings.skybox.color = Color.green;
                break;
            case COLOR.BLUE:
                RenderSettings.skybox.color = Color.blue;
                break;
            case COLOR.YELLOW:
                RenderSettings.skybox.color = Color.yellow;
                break;
            case COLOR.PURPLE:
                RenderSettings.skybox.color = Color.magenta;
                break;
            case COLOR.CYAN:
                RenderSettings.skybox.color = Color.cyan;
                break;
            default:
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        ColorManager.OnChangeColor += ChangeColor;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }

    private void _Move()
    {

        #region Walking
        Vector3 move = transform.right * movement.x + transform.forward * movement.y;
        character.Move(move * speed * Time.deltaTime);

        //Rotate
        move.Normalize();
        move.y = 0;
        if (move == Vector3.zero)
            move = body.forward;

        Quaternion targetRot = Quaternion.LookRotation(move);
        targetRot = Quaternion.Slerp(body.rotation, targetRot, rotateSpeed * Time.deltaTime);
        body.rotation = targetRot;

        #endregion

        #region Jumping
        jumping = !Physics.CheckSphere(body.position, groundRadius, groundMask);

        if (!jumping && velocity.y < 0)
        {
            velocity.y = -2.0f;
        }

        if (input.Movement.Jump.triggered && !jumping )
        {
            Debug.Log("Jump");
            velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        character.Move(velocity * Time.deltaTime);
        #endregion
    }

    private void _Animations()
    {
        float moveAnim = Mathf.Clamp01(Mathf.Abs(movement.x) + Mathf.Abs(movement.y));
        animationManager.UpdateAnimatorMovement(0, moveAnim);
    }
}
