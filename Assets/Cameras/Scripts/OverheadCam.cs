using UnityEngine;
using System.Collections;

public class OverheadCam : MonoBehaviour {

    public GameObject target;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update () {
	
	}

    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;

        transform.LookAt(target.transform.position);
    }
}
