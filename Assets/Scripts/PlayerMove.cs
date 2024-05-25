using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform transform;
    public float Speed =20;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition +=new Vector3( 0,0,  + Time.deltaTime * Speed);
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += new Vector3(0, 0,  - Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += new Vector3( - Time.deltaTime * Speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += new Vector3( Time.deltaTime * Speed, 0, 0);
        }
    }
}
