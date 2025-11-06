using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    [SerializeField] private float delay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
