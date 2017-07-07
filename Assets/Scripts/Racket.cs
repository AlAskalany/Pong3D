using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Racket : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerDownHandler
{
    private AudioSource myAudioSource;
    private Rigidbody myRigidbody;
    private CapsuleCollider myCapsuleCollider;
    private float _distance = 10;
    private Transform myTransform;

    // Awake
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myCapsuleCollider = GetComponent<CapsuleCollider>();
        myTransform = transform;
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

    void FixedUpdate()
    {
        transform.position = myTransform.position;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(eventData.position.x, eventData.position.y, _distance);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        objectPosition = new Vector3(transform.position.x, transform.position.y, objectPosition.z);
        if (Mathf.Abs(objectPosition.z) > 4)
        {
            objectPosition.z = transform.position.z;
        }
        myTransform.position = objectPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            myAudioSource.Play();
        }
    }
}