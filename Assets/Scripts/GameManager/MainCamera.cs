using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed, Space.World);

        if(transform.position.y >=77.6f)
        {
            speed = 0;
            SceneManager.LoadScene("Victoria");
        }
    }
}
