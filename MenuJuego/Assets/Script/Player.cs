using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    Vector3 direction;
    
    Rigidbody player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        direction.z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        player.AddForce(direction, ForceMode.Impulse);
    }
}
