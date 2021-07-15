using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgFollowCamera : MonoBehaviour
{
    public GameObject camera;
    public float offsetXDist = 2;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offsetXDist += camera.transform.position.x;
        offset = transform.position - new Vector3 (offsetXDist, camera.transform.position.y, camera.transform.position.z);   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = camera.transform.position + offset;
    }
}
