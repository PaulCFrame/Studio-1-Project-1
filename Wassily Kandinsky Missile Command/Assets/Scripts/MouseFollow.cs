using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour {

    public float Distance = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray R = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 pos = R.GetPoint(Distance);
        transform.position = pos;	
	}
}
