using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] logs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLog", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnLog()
    {
        
        Instantiate(logs[Random.Range(0,6)], new Vector3(Random.Range(-0.51f, 0.51f), 5f, 3f), transform.rotation);
    }

}
