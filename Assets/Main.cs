using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject container;
    private GameObject box;
    public GameObject Sphere;
    private GameObject spherespawn;
    public GameObject Cube;
    private GameObject cubespawn;
    public GameObject Capsule;
    private GameObject capsulespawn;


    // Use this for initialization
    void Start()
    {
        box = Instantiate(container);
        spherespawn = Instantiate(Sphere);
        cubespawn = Instantiate(Cube);
        capsulespawn = Instantiate(Capsule);
        cubespawn.transform.position = new Vector3(0, 25, 0);
        spherespawn.transform.position = new Vector3(0, 30, 0);
        capsulespawn.transform.position = new Vector3(0, 35, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnMouseDown()
    {
        print("hi");
        

    }
}