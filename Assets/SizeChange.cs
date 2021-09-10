using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale = new Vector3(25.0f, 25.0f, 25.0f);

        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
            transform.localScale = new Vector3(30.0f, 30.0f, 30.0f);

        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);
            transform.localScale = new Vector3(35.0f, 35.0f, 35.0f);
        }
    }
}

//Source code from :Source Code: https://www.youtube.com/watch?v=MC-zQJ8duy8