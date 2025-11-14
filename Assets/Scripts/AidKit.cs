using UnityEngine;

public class AidKit : MonoBehaviour
{
    public float amount;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Life life = other.GetComponent<Life>();
        life.amount += amount;
    }
}
