using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab; // Предоставляем скрипту доступ к префабу
    public GameObject shootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation); // Функция Instantiate используется для клонирования префаба
        }
    }
}
