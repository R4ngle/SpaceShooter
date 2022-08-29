using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed = 8.0f;
   // private float _yPos = .7f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, .71f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
   if(transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}
