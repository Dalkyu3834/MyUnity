using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    Vector3 moveVec;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Horizontal");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }
}
