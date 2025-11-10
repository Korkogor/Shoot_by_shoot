using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab; // Предоставляем скрипту доступ к префабу
    public GameObject shootPoint;

    public void OnAttack(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }
}
