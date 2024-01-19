using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public PlayerMovement Movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Debug.Log("Death");
            Die();
        }
    }

    void Die()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        //gameObject.GetComponent<Rigidbody>().isKinematic = true;
        Movement.enabled = false;
    }
}
