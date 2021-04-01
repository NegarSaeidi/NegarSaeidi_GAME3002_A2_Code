using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag=="ball")
        {
          
           float x= Random.Range(2.2f, -6.5f);
            float y = 0.206f;
            float z= 0;
            other.transform.position = new Vector3(x, y, z);
        }
     
    }
}
