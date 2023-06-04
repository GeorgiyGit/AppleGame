using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TerrainAppleFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        ScoreDisplayer.RemoveScore(5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
