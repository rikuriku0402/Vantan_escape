using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Vector2 _speed = new Vector2(0.05f,0.05f);
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= _speed.x;
        }
        else if (Input.GetKey("right"))
        {
            position.x += _speed.x;
        }
        else if (Input.GetKey("up"))
        {
            position.y += _speed.y;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= _speed.y;
            print("4");
        }
        transform.position = position;
    }
}
