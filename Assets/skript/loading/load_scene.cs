using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("g");
        if (collision.gameObject.tag == "Player")
        {
            print("gh");
            SceneManager.LoadScene(1);
        }
    }
}
