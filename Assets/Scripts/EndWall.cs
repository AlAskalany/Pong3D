using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWall : MonoBehaviour
{
    private AudioSource myAudioSource;

    // Awake
    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // OnCollisionEnter
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            myAudioSource.Play();
        }
    }
}