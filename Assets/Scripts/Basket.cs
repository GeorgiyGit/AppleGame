using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Key Assignments")]
    public KeyCode LeftMove;
    public KeyCode RightMove;




    public float speed = 3f;
    void Start()
    {
        this.transform.position = new Vector3(0f, 3f, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        ScoreDisplayer.AddScore(1);
        PointsDisplayer.Create(1);
    }
    // Update is called once per frame
    void Update()
    {
        int direction = 0;
        if (Input.GetKey(LeftMove))
        {
            direction -= 1;
        }
        if (Input.GetKey(RightMove))
        {
            direction += 1;
        }

        Vector3 pos = this.transform.position;
        pos.z += direction * Time.deltaTime * speed;
        this.transform.position = pos;
    }
}
