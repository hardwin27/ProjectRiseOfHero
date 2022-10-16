using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : ScriptableObject
{
    [SerializeField] private float _characterHealth;
    [SerializeField] private float _characterSpeed;

    public float CharacterHealth { get { return _characterHealth; } }
    public float CharacterSpeed { get { return _characterSpeed; } }


}
