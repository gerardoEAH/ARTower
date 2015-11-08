using System;
using UnityEngine;

    public class RollingBall : MonoBehaviour
    {
        public static float m_MovePower = 7; // The force added to the ball to move it.
    //[SerializeField] private bool m_UseTorque = true;
       //[SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
        private Rigidbody m_Rigidbody;


        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            // Set the maximum angular velocity.
      //GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move(Vector3 moveDirection)
        {
                // ... add force in upwards.
                //m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
        m_Rigidbody.velocity = new Vector3(moveDirection.x * m_MovePower, m_Rigidbody.velocity.y,moveDirection.z * m_MovePower);
        //if (m_UseTorque){
        //m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower/10);
        //}
        }
    }



