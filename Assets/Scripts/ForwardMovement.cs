using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float _speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
