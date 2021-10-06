using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ships : MonoBehaviour
{     
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
