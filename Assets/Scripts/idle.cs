using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle : MonoBehaviour
{
	public float speed = 1f;
	
	public SpriteRenderer sr;
	

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CheckPoint"))
        {
            speed = -1 * speed;
            if(sr.flipX){
                sr.flipX = false;
            }
            else {
                sr.flipX = true;
            }
        }

    }
}
