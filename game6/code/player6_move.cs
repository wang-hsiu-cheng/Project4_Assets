using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player6_move : MonoBehaviour
{
    Color black = new Color(225, 225, 225, 225), white = new Color(0, 0, 0, 225);
    void Start()
    {
        collider_detect_2.collid = false;
        gameObject.GetComponent<Rigidbody2D>() .gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (collider_detect_2.collid) {
            gameObject.GetComponent<Rigidbody2D>() .gravityScale = 0;
            if (collider_detect_1.collid || collider_detect_0.collid) {
                collider_detect_2.collid = false;
            }
        }
        if (collider_detect_1.collid) {
            gameObject.GetComponent<Rigidbody2D>() .gravityScale = -1;
            // if (collider_detect_2.collid) {
            //     collider_detect_1.collid = false;
            // }
        }
        if (collider_detect_0.collid) {
            if (collider_detect_2.collid) {
                gameObject.GetComponent<Rigidbody2D>() .gravityScale = 0;
                gameObject.transform.position += new Vector3(0, 0.5f, 0);
                collider_detect_0.collid = false;
            }
            gameObject.GetComponent<Rigidbody2D>() .gravityScale = 1;
        }

        if (Input.GetKey("a") && collider_detect_0.collid) {
            transform.Translate(-12*Time.deltaTime, 0, 0);
            collider_detect_0.collid = false;
        } else if (Input.GetKey("a") && collider_detect_1.collid) {
            transform.Translate(12*Time.deltaTime, 0, 0);
            collider_detect_1.collid = false;
        }
        if (Input.GetKey("d") && collider_detect_0.collid) {
            transform.Translate(12*Time.deltaTime, 0, 0);
            collider_detect_0.collid = false;
        } else if (Input.GetKey("d") && collider_detect_1.collid) {
            transform.Translate(-12*Time.deltaTime, 0, 0);
            collider_detect_1.collid = false;
        }
        if (Input.GetKey("w") && collider_detect_2.collid) {
            transform.Translate(0, 2*Time.deltaTime, 0);
        } else if (Input.GetKey("s") && collider_detect_2.collid) {
            transform.Translate(0, -2*Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Space)) {
            // transform.position += new Vector3(0 ,-1, 0);
            if (transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color == white)
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = black;
            else 
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = white;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        
    }
}
