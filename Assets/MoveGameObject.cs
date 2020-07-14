using System.Diagnostics;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    // The speed that the GameObject will move
    private float _speed = 2;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.up * _speed) * Time.deltaTime;
        }
        // Move the GameObject to the right this frame
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (Vector3.down * _speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * _speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * _speed) * Time.deltaTime;
        }

    }
}
