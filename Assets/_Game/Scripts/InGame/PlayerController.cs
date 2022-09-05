using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] private float speed;
    
    [SerializeField]private Transform isometricTransform;//using for isometric character move
    private Rigidbody characterRb;

    private void Start()
    {
        Application.targetFrameRate = 60;
        characterRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetMoveInput();//get player input on update method
    }

    private void FixedUpdate()
    {
        CharacterMovement();//use physics on fixedupdate 
    }

    private void GetMoveInput()
    {
        var horizontalMove = Input.GetAxis("Horizontal");
        var verticalMove = Input.GetAxis("Vertical");

        var xMovement = isometricTransform.right * horizontalMove;
        var zMovement = isometricTransform.forward * verticalMove;

        movement = xMovement+zMovement; //new Vector3(horizontalMove, 0, verticalMove);
    }
    private void CharacterMovement()
    {
        characterRb.AddForce(movement*speed);//move character with physic
    }
}
