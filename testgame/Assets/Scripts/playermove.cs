using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class playermove : MonoBehaviour
{
    SerialPort sp;
    public float maxSpeed;
    
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 입력 키값
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if(rigid.velocity.x > maxSpeed) // Right max Speed
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);  
        }
        else if (rigid.velocity.x < maxSpeed*(-1)) // Left max Speed
        {
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
        }
    }
 
}
