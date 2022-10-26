using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
