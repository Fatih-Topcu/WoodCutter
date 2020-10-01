using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Log : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip woodSound;
    public GameObject LeftWood;
    public GameObject RightWood;
    public GameObject WoodMark;
    public GameObject woodParticles;
    

    // Start is called before the first frame update

    void Start()
    {
        Destroy(gameObject, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Saw")
        {

            Score.score += 20;
            GameObject effect = (GameObject)Instantiate(woodParticles, WoodMark.transform.position, WoodMark.transform.rotation);
            GameObject effect2 = (GameObject)Instantiate(woodParticles, other.gameObject.transform.position, other.gameObject.transform.rotation);
            if (effect != null)
            {
                Destroy(effect, 1f);
            }

            if (effect2 != null)
            {
                Destroy(effect2, 1f);
            }

            audioSource = GetComponent<AudioSource>();
            audioSource.clip = woodSound;
            audioSource.Play();

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Saw")
        {
            Score.score += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        

        if (other.gameObject.tag == "Saw")
        {
          
            Destroy(WoodMark);
            
            if(LeftWood.transform.parent != null)
            {
                LeftWood.transform.parent = null;
                LeftWood.AddComponent<Rigidbody>();
                LeftWood.AddComponent<BoxCollider>();
            }

            if (RightWood.transform.parent != null)
            {
                RightWood.transform.parent = null;
                RightWood.AddComponent<Rigidbody>();
                RightWood.AddComponent<BoxCollider>();

            }
            Score.score += 10;

            Destroy(LeftWood, 10f);
            Destroy(RightWood, 10f);

        }
    }

    

    
}
