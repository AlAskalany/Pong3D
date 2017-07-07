using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Ball : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private SphereCollider myCollider;
    public GameObject ExplosionPrefab;

    // Awake
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myCollider = GetComponent<SphereCollider>();
    }

    // Use this for initialization
    void Start()
    {
        var rand = Mathf.Round(Random.Range(0f, 1f));
        if (rand > 0)
        {
            myRigidbody.velocity = new Vector3(5f, 0f, Random.Range(0.1f, 2f));
        }
        else
        {
            myRigidbody.velocity = new Vector3(-5f, 0f, Random.Range(0.1f, 2f));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "EndWall")
        {
            StartCoroutine(Death());
        }
        else if (col.gameObject.tag == "BounceWall")
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x * 2f,
                                               myRigidbody.velocity.y,
                                               myRigidbody.velocity.z);
        }
        else if (col.gameObject.tag == "Racket")
        {
            
        }
    }

    private IEnumerator Death()
    {
        myRigidbody.velocity = new Vector3(0f, 0f, 0f);
        ExplosionPrefab.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}