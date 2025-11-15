using UnityEngine;
using System.Collections.Generic;
public class EnemiesManager : MonoBehaviour
{
    public static  EnemiesManager instance;
    
    public List<Enemy> enemies;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicate Score Manager, ignoring this one", gameObject);
        }
    }
}
