using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naikTurunMoncong : MonoBehaviour
{
    Vector3 naik;
    Vector3 turun;

    static Quaternion toQuaternion(Vector3 euler){
		Quaternion q;
		float pitch = euler.y;
		float roll = euler.x;
		float yaw = euler.z;
		float t0 = Mathf.Cos(yaw * 0.5f);
		float t1 = Mathf.Sin(yaw * 0.5f);
		float t2 = Mathf.Cos(roll * 0.5f);
		float t3 = Mathf.Sin(roll * 0.5f);
		float t4 = Mathf.Cos(pitch * 0.5f);
		float t5 = Mathf.Sin(pitch * 0.5f);
		Debug.Log (t0+" "+t1+" "+t2+" "+t3+" "+t4+" "+t5);

		q.x = t0 * t3 * t4 - t1 * t2 * t5;
		q.y = t0 * t2 * t5 + t1 * t3 * t4;
		q.z = t1 * t2 * t4 - t0 * t3 * t5;
		q.w = t0 * t2 * t4 + t1 * t3 * t5;
		return q;
    }

    // Start is called before the first frame update
    void Start()
    {
        naik = new Vector3(0,0,1);
        turun = new Vector3(0,0,-1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
            transform.rotation = transform.rotation * toQuaternion(naik * 1/10 * Time.deltaTime);
        else if (Input.GetKey("down"))
            transform.rotation = transform.rotation * toQuaternion(turun * 1/10 * Time.deltaTime);

    }
}
