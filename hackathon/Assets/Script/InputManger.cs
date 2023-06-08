using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class inputManager : MonoBehaviour
{
    private PlayerInput playerinput;
    private PlayerInput.onFootAction onFoot;

    private PlayerMotor motor;
     
    // Start is called before the first frame update
    void Awake()
    {
        playerinput = new PlayerInput();
        onFoot = playerinput.onFoot;
        motor = GetComponent<PlayerInput>();
    }
   
    private void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>;
    }
    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
