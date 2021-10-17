using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange : MonoBehaviour
    
{
    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "camTrigger")

        
        {
            if (myBody.velocity.x > 0)
            {
                Vector3 newCamPos = new Vector3(10, collision.gameObject.transform.position.y, -10);
                Camera.main.transform.position = newCamPos;
            }
            else
            {
                Vector3 newCamPos = new Vector3(-4, collision.gameObject.transform.position.y, -10);
                Camera.main.transform.position = newCamPos;
            }

        }
    }
}


