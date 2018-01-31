using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseClick : MonoBehaviour {

    void OnMouseDown()
    {
        gameObject.transform.position = new Vector3(0, 25, 0);

    }
}
