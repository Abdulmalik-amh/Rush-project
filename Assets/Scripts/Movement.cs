using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
     bool jump;
    public Rigidbody body;
    public Vector2 InputSystemMovement;
    // Start is called before the first frame update
   public void PlayerMovementInputSystem (InputAction.CallbackContext context){

        InputSystemMovement = context.ReadValue<Vector2>();

   }
    public void Jump (InputAction.CallbackContext context){
        jump = context.action.triggered;

    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 Move = new Vector3(InputSystemMovement.x,-0.5f,InputSystemMovement.y);
        body.velocity = Move *10;

        if(jump){
            body.AddForce(Vector3.up*100);
        }
        
    }   
}
