using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private float _speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    { 
      float horizontalInput = Input.GetAxis("Horizontal")
      float verticaInput   = Input.GetAxis("Vertical")
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        Vector3 direction = new Vector3(horizionta)
    }
}
