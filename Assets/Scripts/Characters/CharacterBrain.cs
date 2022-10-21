using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBrain : MonoBehaviour
{

    [SerializeField] private CharacterEntity _entity;
    [SerializeField] private CharacterMovement _movement;

    /*public CharacterEntity Entity { get { return _entity; } }
    public CharacterMovement Movement { get { return _movement; } }*/

    public void SetMovementDirection(float moveDir)
    {
        _movement.SetMoveDirection(moveDir);
    }
}
