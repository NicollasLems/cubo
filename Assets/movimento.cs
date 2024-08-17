using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        m.x = 0;
        m.y = 5;
        m.z = 0;
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            m.y = 0.05f;
            transform.Translate(m);
        }

        if (transform.position.x < -4.5)
        {
            transform.position = new Vector3(-4.5f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 4.5)
        {
            transform.position = new Vector3(4.5f, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 4.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 4.5f);
        }

        if (transform.position.z < -4.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4.5f);
        }

        m.Set(0, 0, 0);

    }
}