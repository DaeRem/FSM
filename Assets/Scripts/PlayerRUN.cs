using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRUN : PlayerFSMState
{
    public Transform marker;
    public float moveSpeed = 3.0f;

	// Use this for initialization
	void Start ()
    {
        marker = GameObject.FindGameObjectWithTag("Marker").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("RUN");
        //transform.position = marker.position;
        transform.position = Vector3.MoveTowards(
            transform.position,
            marker.position,
            moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, marker.position) < 0.01f)      // 0이 아닌 0.01인 이유 : 0보다 작은 자연수는 없고 
                                                                                // 대충 0에 가까운 수가 되면 도착했다고 설정.
        {
         //   GetComponent<MFSManager>()
        }
    }
}
