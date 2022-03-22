using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movercamara : MonoBehaviour
{
    public int velocidad;
    private Vector3 movimiento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 15.9)
            {
                movimiento = new Vector3(0, 1, 0);
                transform.position = transform.position + movimiento *velocidad* Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= 2.1)
            {
                movimiento = new Vector3(0, -1, 0);
                transform.position = transform.position + movimiento* velocidad * Time.deltaTime;
            }
        }

    }
}
