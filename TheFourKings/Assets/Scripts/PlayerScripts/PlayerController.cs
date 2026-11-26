using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 move = new Vector2();

    Vector3 velocity;

    CharacterController Cc;

    [SerializeField] Manoplas Weapon;

    [SerializeField] float speed = 2;

    [SerializeField] LayerMask enemy, floor;

    [SerializeField] GameObject player;

    [SerializeField] int jumps = 1;

    float gravity = -9.8f;

    void Start()
    {
        Cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 horiMove = transform.right * move.x + transform.up * move.y;

        velocity.y += gravity * Time.deltaTime;

        Vector3 moviment = horiMove * speed + Vector3.up * velocity.y;

        Cc.Move(moviment * Time.deltaTime);

        if(Cc.isGrounded == true && jumps == 0)
        {
            jumps++;
        }
    }

    void Recal()
    {

    }

#region InputAction
    public void Movement(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();

        if(move.x <= -0.5)
        {
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(move.x >= 0.5)
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    //Rever
    public void Jump(InputAction.CallbackContext value)
    {
        if(value.performed)
        {
            return;
        }

        if(value.ReadValue<float>() >= 0.5 && jumps > 0)
        {
            velocity.y = 7;
            jumps--;
        }
    }

    public void Attack(InputAction.CallbackContext value)
    {
        if(value.performed)
        {
            return;
        }

        if(value.ReadValue<float>() >= 0.5)
        {
            RaycastHit hit;

            if(Physics.Raycast(transform.position, player.transform.right, out hit, Weapon.rangeDa))
            {
                Debug.Log("Você atacou");
            }
        }
    }
#endregion
}
