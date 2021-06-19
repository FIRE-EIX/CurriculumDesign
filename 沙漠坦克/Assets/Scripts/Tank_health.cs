using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_health : MonoBehaviour {

    public int hp = 100;
    public GameObject tankExplosion;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void TakeDamage()
    {
        if (hp <= 0)
            return;
        hp -= Random.Range(10, 20);
        if (hp <= 0)
        {
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }

}
