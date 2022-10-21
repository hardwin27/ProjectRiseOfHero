using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour
{
    [SerializeField] private CharacterData _data;

    private float _currentHealth;
    private float _maxHealth;

    public CharacterData Data { get { return _data; } }

    private void Awake()
    {
        SetInitialStats();
    }

    private void SetInitialStats()
    {
        _maxHealth = Data.BaseHealth;
        _currentHealth = _maxHealth;
    }
}
