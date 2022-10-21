using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data / Character Data")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private float _baseHealth;
    [SerializeField] private float _baseSpeed;

    public float BaseHealth { get { return _baseHealth; } }
    public float BaseSpeed { get { return _baseSpeed; } }
}
