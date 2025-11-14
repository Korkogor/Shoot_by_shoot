using Unity.VisualScripting;
using UnityEngine;

public class AidKit : MonoBehaviour
{
    public float amount;
    public float rotationSpeed = 90f;
    public float hoverHeight = 0.2f;
    public float hoverSpeed = 1f;
    private float hoverTimer;
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Life life = other.GetComponent<Life>();
        life.amount += amount;
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        
        hoverTimer += Time.deltaTime * hoverSpeed;
        // Используем синус для плавного движения вверх-вниз
        float newY = transform.position.y + Mathf.Sin(hoverTimer) * hoverHeight;
        
        // Применяем новую позицию, сохраняя X и Z координаты
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
