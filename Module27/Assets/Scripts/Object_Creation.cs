using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Creation : MonoBehaviour
{
    public GameObject gameObject;

    private Vector3 _regularScale;

    private void Start()
    {
        _regularScale = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Scale(2);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            gameObject.Scale(2);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = _regularScale;
        }
    }
}
