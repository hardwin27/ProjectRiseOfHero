using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private CharacterEntity _characterEntity;

    private Rigidbody2D _body;

    private float _moveDirection = 0f;
    private float _moveSpeed = 0f;

    private bool _canMove = true;
    private bool _isMoving = false;

    public bool CanMove { get { return _canMove; } }
    public bool IsMoving { get { return _isMoving; } }


    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
        _moveSpeed = _characterEntity.Data.BaseSpeed;
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void SetMoveDirection(float moveDirection)
    {
        _moveDirection = moveDirection;
    }

    private void Move()
    {
        if (!_canMove)
        {
            return;
        }

        _body.AddForce(new Vector2(_moveDirection * 20.0f, 0.0f));
        float absMoveSpeed = Mathf.Abs(_body.velocity.x);
        
        if (absMoveSpeed > _moveSpeed)
        {
            _body.velocity = new Vector2(_moveDirection * _moveSpeed, _body.velocity.y);
        }

        _isMoving = (absMoveSpeed > 0f);
    }
}
