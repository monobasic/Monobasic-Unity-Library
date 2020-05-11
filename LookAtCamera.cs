using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // We could do this in the Update() method, but instead we create a LateUpdate() method. As a rule of thumb, you should always use LateUpdate() instead of the Update() method in all camera scripts. LateUpdate() happens after Update() has finished, so the Player script has a chance to finish calculating the player's position before the camera calculates its position. This results in smoother camera motion
    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}
