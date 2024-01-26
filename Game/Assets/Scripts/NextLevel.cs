using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Next Level"))
        {
            Next();
            Debug.Log("Next");
        }
    }

    void Next()
    {
        SceneManager.LoadScene("GameScene2", LoadSceneMode.Single);
    }
}
