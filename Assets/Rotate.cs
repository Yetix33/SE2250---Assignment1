using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(new Vector3(0, 0, 5));
        }

        if (Input.GetMouseButtonDown(1)) {

            transform.Rotate(new Vector3(0, 0, -5));
        }
    }

    // Update is called once per frame
    void onMouseDown () {
        transform.Rotate(new Vector3(0,0,10));
        print("hi");

        


	}
}
