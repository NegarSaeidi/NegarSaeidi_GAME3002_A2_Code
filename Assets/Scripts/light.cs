using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    private bool toggled = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
            StartCoroutine(ToggleLight());
    }
    private IEnumerator ToggleLight()
    {
       
        if (toggled)
        {
            GetComponent<Light>().intensity = 200f;
            yield return new WaitForSeconds(2f);
            toggled = false;
        }
        else
        {
            GetComponent<Light>().intensity = 0;
            yield return new WaitForSeconds(2f);
            toggled = true;
        }
     
    }
}
