using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{

    private bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            if(transform.position.z<7.98)
            transform.Translate(0, 0, 0.1f);
            else 
                move = false;
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("gate");
        if (other.gameObject.tag == "gate")
        {
            Debug.Log("gate");
            // transform.position = new Vector3(-5.78f, 0.1999998f, 7.98f);
            move = true;
           GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
