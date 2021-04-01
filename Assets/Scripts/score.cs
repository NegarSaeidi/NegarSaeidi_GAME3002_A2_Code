using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    [SerializeField]
    private float m_score = 0f;
    [SerializeField]
    private int m_live =3;
    [SerializeField]
    private Text scoreLabel;
    [SerializeField]
    private Text livesLabel;
    [SerializeField]
    private AudioSource toySound;
    [SerializeField]
    private AudioSource bumperSound;
    [SerializeField]
    private AudioSource doorSound;
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
        if (other.gameObject.tag == "toy")
        {

            m_score += 50;
            scoreLabel.text = m_score.ToString();
            toySound.Play();
        }
        if (other.gameObject.tag == "bumper")
        {

            m_score += 10;
            scoreLabel.text = m_score.ToString();
            bumperSound.Play();
        }
        if (other.gameObject.tag == "door")
        {
            doorSound.Play();
        }
            if (other.gameObject.tag == "fall")
        {
            if (m_live > 1)
            {
                transform.position = new Vector3(-5.75f, 0.206f, 6.24f);
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                m_live -= 1;
                livesLabel.text = m_live.ToString();
            }
            else
            {
                Debug.LogError("GAME OVER");
                SceneManager.LoadScene("gameOver");
                m_live = 3;
                m_score = 0;
            }
        }


    }
}
