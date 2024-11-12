using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] private float forwardSpeed = 5;
    [SerializeField] private float horizontalSpeed = 2.5f;
    
    private Vector3 clickScreenPosition;
    private Vector3 clickPlayerPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        HandleControl();
    }

    private void MoveForward()
    {
        transform.position += Vector3.forward * (forwardSpeed * Time.deltaTime);
    }

    private void HandleControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickScreenPosition = Input.mousePosition;
            clickPlayerPosition = transform.position;
        }
        
        else if (Input.GetMouseButton(0))
        {
            float horizontalDistance = Input.mousePosition.x - clickScreenPosition.x;
            horizontalDistance /= Screen.width;
            horizontalDistance *= horizontalSpeed;

            Vector3 position = transform.position;
            position.x = clickPlayerPosition.x + horizontalDistance;
            transform.position = position;

        }
    }
}
