using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeeball : MonoBehaviour
{

    public int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            points += 50;
            Debug.Log("got points");
        }
    }

}
