using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Attack : MonoBehaviour {

    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;

    private Transform firePoint;

	// Use this for initialization
	void Start () {
        firePoint = transform.Find("FirePoint");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            GameObject go = GameObject.Instantiate(shellPrefab, firePoint.position, firePoint.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
	}
}
