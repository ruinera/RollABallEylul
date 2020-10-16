using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float ForceMultiplier;

    private float _moveHorizontal;
    private float _moveVertical;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        _moveHorizontal = Input.GetAxis("Horizontal") * ForceMultiplier;
        _moveVertical = Input.GetAxis("Vertical") * ForceMultiplier;
        _rigidbody.AddForce(_moveHorizontal, 0, _moveVertical);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collect"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Hazard"))
        {
            Debug.Log(message: "Ouch!");
        }
    }
}

