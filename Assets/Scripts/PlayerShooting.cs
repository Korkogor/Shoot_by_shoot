using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab; // Предоставляем скрипту доступ к префабу

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab, transform.position, transform.rotation); // Функция Instantiate используется для клонирования префаба
        }
    }
}
