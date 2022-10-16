using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour
{
    [SerializeField] private CharacterData _data;

    private bool _canMove;
    private bool _isMoving;

    public CharacterData Data { get { return _data; } }
}
