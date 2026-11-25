using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 move = new Vector2();

    Vector3 velocity;

    CharacterController Cc;

    [SerializeField] float speed = 2;

    string IDweapon;

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
    }

#region InputAction
    public void Movement(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();
    }

    //Rever
    public void Jump(InputAction.CallbackContext value)
    {
        if(value.performed)
        {
            return;
        }

        if(value.ReadValue<float>() >= 0.5)
        {
            Debug.Log("Player pulou");
            transform.position = new Vector3(transform.position.x, transform.position.y + 30, 0);
        }
    }
#endregion
}
