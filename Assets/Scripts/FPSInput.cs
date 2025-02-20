using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    private CharacterController charController;
    public float speed = 6.0f;
    public float gravity = -9.8f;
    
    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        
        movement.y = gravity;

        //jumping function
        bool deltaY = Input.GetKey("space");
        if (deltaY){
            if (movement.y < 0){
                movement.y += 20.2f;
            }
        }

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        charController.Move(movement);


        //transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);
    }
}
