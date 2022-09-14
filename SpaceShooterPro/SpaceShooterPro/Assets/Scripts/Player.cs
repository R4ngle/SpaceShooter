using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
  
    [SerializeField]
    private float fireRate = .3f;
    private float nextFire = -1;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
       
    }

    void Update()
    {
        CalculateMovement();
        FireLaser();  
    }
          void CalculateMovement() { 
        {

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

            transform.Translate(direction * _speed * Time.deltaTime);

            if (transform.position.y >= 0)
            {
                transform.position = new Vector3(transform.position.x, 0, 0);
            }
            else if (transform.position.y <= -3.8f)
            {
                transform.position = new Vector3(transform.position.x, 3.8f, 0);
            }
            if (transform.position.x > 11.3f)
            {
                transform.position = new Vector3(-11.3f, transform.position.y, 0);
            }
            else if (transform.position.x < -11.3f)
            {
                transform.position = new Vector3(11.3f, transform.position.y, 0);
            }
     void FireLaser() {

            }
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(_laserPrefab, GameObject.FindWithTag("Player").transform.position + new Vector3(0, .7f, 0), Quaternion.identity);

            }
        }
    }
}