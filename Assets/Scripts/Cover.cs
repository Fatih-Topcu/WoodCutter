using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cover : MonoBehaviour
{

    public GameObject leftCover;
    public GameObject rightCover;
    public int coverState;


    // Start is called before the first frame update
    void Start()
    {
        coverState = 0;
        InvokeRepeating("OpenCloseCover", 9f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OpenCloseCover()
    {

        if(coverState == 0)
        {
            Debug.Log("aç");
            coverState = 1;
            leftCover.transform.position = new Vector3(-2f, leftCover.transform.position.y, leftCover.transform.position.z);
            rightCover.transform.position = new Vector3(2f, rightCover.transform.position.y, rightCover.transform.position.z);
        }

        else if (coverState == 1)
        {
            Debug.Log("kapat");
            coverState = 2;
            leftCover.transform.position = new Vector3(-0.8f, leftCover.transform.position.y, leftCover.transform.position.z);
            rightCover.transform.position = new Vector3(0.8f, rightCover.transform.position.y, rightCover.transform.position.z);
        }
        else if (coverState == 2)
        {
            Debug.Log("bekle2");
            coverState = 3;
        }
        else if (coverState == 3)
        {
           
            Debug.Log("bekle3");
            coverState = 0;
        }
    }

}
