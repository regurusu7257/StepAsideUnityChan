using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyWall : MonoBehaviour
{

    private GameObject unitycahn;

    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        this.unitycahn = GameObject.Find("unitychan");

        this.difference = unitycahn.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitycahn.transform.position.z - difference);
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}
