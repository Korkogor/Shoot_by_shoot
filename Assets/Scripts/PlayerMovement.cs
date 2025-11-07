using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private Vector2 movementValue;
    private float lookValue;

    void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
                                            // P: 173
    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }
    void Update()
    {
        transform.Translate(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime );
        transform.Rotate(Vector3.up, lookValue * Time.deltaTime);
        // if (Input.GetKey(KeyCode.W)) {transform.Translate(0, 0, speed * Time.deltaTime);}
        // if (Input.GetKey(KeyCode.S)){transform.Translate(0, 0, -speed * Time.deltaTime);}
        // if (Input.GetKey(KeyCode.A)){transform.Translate(-speed * Time.deltaTime, 0, 0);}
        // if (Input.GetKey(KeyCode.D)){transform.Translate(speed * Time.deltaTime, 0, 0);}
        //
        // float mouseX = Input.GetAxis("Mouse X"); // считывание горизонтального перемещения мыши
        // transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0); //горизонтальный поворот объекта на основе движения мыши
        
    }
    
}
