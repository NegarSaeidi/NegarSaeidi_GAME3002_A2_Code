using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float m_fSpringConst = 0f;
    [SerializeField]
    private float m_fOriginalPos = 0f;
    [SerializeField]
    private float m_fPressedPos = 0f;
    [SerializeField]
    private float m_fFlipperSpringDamp = 0f;

    private bool contact = false;
    private HingeJoint m_hingeJoint = null;
    private JointSpring m_jointSpring;

    private void Start()
    {
        m_hingeJoint = GetComponent<HingeJoint>();
        m_hingeJoint.useSpring = true;

        m_jointSpring = new JointSpring();
        m_jointSpring.spring = m_fSpringConst;
        m_jointSpring.damper = m_fFlipperSpringDamp;

        m_hingeJoint.spring = m_jointSpring;
    }

    private void OnObstacleHitInternal()
    {
        m_jointSpring.targetPosition = m_fPressedPos;
        m_hingeJoint.spring = m_jointSpring;
    }

    private IEnumerator OnObstacleReleasedInternal()
    {
        yield return new WaitForSeconds(0.5f);
        m_jointSpring.targetPosition = m_fOriginalPos;
        m_hingeJoint.spring = m_jointSpring;
     
    }

    private void Update()
    {
        if (contact == true)
        {
            StartCoroutine(OnObstacleReleasedInternal());
           
            contact = false;
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ball")
        {
           
            OnObstacleHitInternal();
            contact = true;
        }

        
          
        
    }
}
