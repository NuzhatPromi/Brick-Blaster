using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
    Ray ray;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                Debug.Log("Hit something");
                if(hit.transform.gameObject.CompareTag("Pick Up"))
                {
                    Debug.Log("Pick up hit");
                    Destroy(hit.transform.gameObject);

                }
            }
        }
	}
}
