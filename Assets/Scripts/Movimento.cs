using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tecla de Espaço");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, 5.0f * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-5.0f * Time.deltaTime, 0.0f, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -5.0f * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(5.0f * Time.deltaTime, 0.0f, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }
    }
}
