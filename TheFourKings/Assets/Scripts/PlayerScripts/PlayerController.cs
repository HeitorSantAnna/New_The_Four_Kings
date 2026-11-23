using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 move = new Vector2();

    Vector3 movimentVert, movimentHori;

    CharacterController Cc;

    [SerializeField] GameObject player;

    [SerializeField] float speed = 2;

    float gravity = -9.8f;
    float VelVertical;

    void Start()
    {
        Cc = player.GetComponent<CharacterController>();
    }

    void Update()
    {
        VelVertical += gravity * Time.deltaTime;

        movimentVert = transform.up * VelVertical;

        movimentHori = (transform.right * move.x);
        
        Cc.Move((movimentHori * speed + movimentVert) * Time.deltaTimes);
    }

#region InputAction
    public void Move(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();
    }
#endregion
}
