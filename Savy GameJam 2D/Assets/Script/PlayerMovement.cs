using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private Touch tch;
    bool grounded;
    [SerializeField] float jumpPower;

    //private int jumpCount = 7;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            tch = Input.GetTouch(0);

            if (tch.phase == TouchPhase.Began )
            {
                print("jump by touch");
                jump();
            }

        } /*else if (Input.GetKeyDown("space") )
        {
            print("jump using space button");
            jump();
        }*/
    } 
    void jump(){
        rb.velocity = Vector2.up * jumpPower;
       // jumpCount--;
    }
   void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Nail")|| col.gameObject.CompareTag("Ground"))
        {
            grounded=true;
            print("grounded");
           // jumpCount = 5;
        }
    }
   /* void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Nail")|| col.gameObject.CompareTag("Ground")){
            grounded=false;
            print("not grounded");
        }*/
    }

    


