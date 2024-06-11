using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float orbitSpped;
    Vector3 offSet;

    void Start()
    {
        offSet = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offSet;
        transform.RotateAround(target.position,
                               Vector3.up,
                               orbitSpped * Time.deltaTime);
        offSet = transform.position - target.position;
    }
}
