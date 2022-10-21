using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private CharacterBrain _characterBrain;

    private void Update()
    {
        MovementInputHandler();
    }

    private void MovementInputHandler()
    {
        _characterBrain.SetMovementDirection(Input.GetAxisRaw("Horizontal"));
    }
}
