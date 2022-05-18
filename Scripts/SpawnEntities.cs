using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntities : MonoBehaviour
{
    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject objectToSpawn5;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate<GameObject>(objectToSpawn1, spawn1.transform.localPosition, spawn1.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn2, spawn2.transform.localPosition, spawn2.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn3, spawn3.transform.localPosition, spawn3.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn4, spawn4.transform.localPosition, spawn4.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn5, spawn5.transform.localPosition, spawn5.transform.localRotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnTargets()
    {
        Instantiate<GameObject>(objectToSpawn1, spawn1.transform.localPosition, spawn1.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn2, spawn2.transform.localPosition, spawn2.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn3, spawn3.transform.localPosition, spawn3.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn4, spawn4.transform.localPosition, spawn4.transform.localRotation);
        Instantiate<GameObject>(objectToSpawn5, spawn5.transform.localPosition, spawn5.transform.localRotation);
    }
}
