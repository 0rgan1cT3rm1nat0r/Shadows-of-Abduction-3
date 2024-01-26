using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public PlayerMovement Movement;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Debug.Log("Death");
            Die();
        }
    }

    void Die()
    {
        //gameObject.GetComponent<MeshRenderer>().enabled = false;
        //gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //Movement.enabled = false;
        SceneManager.LoadScene("DeathScene", LoadSceneMode.Single);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

