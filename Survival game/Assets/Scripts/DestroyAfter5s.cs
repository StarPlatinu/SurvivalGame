using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter5s : MonoBehaviour
{

    
    float destroyTime = -1f;
    float rebuild = -1f;
    // Start is called before the first frame update
    void Awake()
    {  
        destroyTime = Time.time + 5f;
        rebuild = Time.time + 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= destroyTime)    
        {
           gameObject.SetActive(false);
        }
        if (Time.time >= rebuild)
        {
            gameObject.SetActive(true);
        }
    }
 

}
