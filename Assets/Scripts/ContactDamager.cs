using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        Life life = GetComponent<Life>();
        if (life != null)
        {
            life.amount -= damage;
        }
    }
}
