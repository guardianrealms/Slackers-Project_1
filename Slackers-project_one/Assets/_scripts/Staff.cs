using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour {

    public float Charge = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetButton("Fire1"))
        {//adds charge untill it cann fire
            Charge += 5f;
            Debug.Log(Charge);
            
        }
        if (Charge == 300f)
        {
            Debug.Log("shooting");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 50 , Color.yellow);
            if (Physics.Raycast(ray, 100))
                print("Hit something!");
            //resets
            Charge = 0f;
            //will add cd system
        }
    }
}
