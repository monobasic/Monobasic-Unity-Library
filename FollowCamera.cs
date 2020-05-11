using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
