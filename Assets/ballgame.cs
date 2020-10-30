using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballgame : MonoBehaviour
{

    public int point;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            point += 50;
            Debug.Log("got points");
            Instantiate(ball, new Vector3(25, -4, 1), Quaternion.identity);
        }
    }

}

