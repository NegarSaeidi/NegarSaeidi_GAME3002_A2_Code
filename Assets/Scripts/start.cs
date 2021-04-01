using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public void buttonPressed()
    {
        SceneManager.LoadScene("main");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
