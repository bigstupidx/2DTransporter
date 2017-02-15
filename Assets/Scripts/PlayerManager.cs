using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float Speed = 10.0f;
    public float ReverseSpeed = 5.0f;
    public float TurnSpeed = 0.1f;

    private float _moveDirection = 0.0f;
    private float _turnDirection = 0.0f;

    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            _moveDirection = Input.GetAxis("Vertical") * Speed;
            _rigidbody2D.AddRelativeForce(new Vector2(0, _moveDirection), ForceMode2D.Force);            
        }

        if(Input.GetAxis("Vertical") < 0.0f)
        {
            _moveDirection = Input.GetAxis("Vertical") * ReverseSpeed;
            _rigidbody2D.AddRelativeForce(new Vector2(0, _moveDirection), ForceMode2D.Force);            
        }

        _turnDirection = Input.GetAxis("Horizontal") * TurnSpeed;
        _rigidbody2D.AddTorque(_turnDirection, ForceMode2D.Force);
    }
}
