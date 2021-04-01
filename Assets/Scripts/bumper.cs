using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{

    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private float power = 20.0f;
    private bool contact = false;
  //  private void ReflectVel(Collision other);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ball")
        {
            ReflectVel(other);
        }
   
    }
    private void ReflectVel(Collision other)
    {
       
       other.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.Reflect(other.gameObject.GetComponent<Rigidbody>().velocity*power, Vector3.forward);
    }
}
