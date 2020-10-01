using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour

{

    private Touch touch;
    private float moveSpeed;



    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.0025f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(720 * Time.deltaTime, 0, 0);


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {

                if(transform.position.x + touch.deltaPosition.x * moveSpeed > -1.05f  && transform.position.x + touch.deltaPosition.x * moveSpeed < 1.05f)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * moveSpeed,
                    transform.position.y,
                    transform.position.z);
                }
               
            }
        }
        
    }
}
