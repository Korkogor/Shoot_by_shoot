using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate); //P:160
        Invoke("CancelInvoke", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
