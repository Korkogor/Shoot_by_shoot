using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {transform.Translate(0, 0, speed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.S)){transform.Translate(0, 0, -speed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.A)){transform.Translate(-speed * Time.deltaTime, 0, 0);}
        if (Input.GetKey(KeyCode.D)){transform.Translate(speed * Time.deltaTime, 0, 0);}
        
        float mouseX = Input.GetAxis("Mouse X"); // считывание горизонтального перемещения мыши
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0); //горизонтальный поворот объекта на основе движения мыши
    }
}
