using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class SpeedInputField : MonoBehaviour
{
    [SerializeField] private Mover _enemy;

    private InputField _inputField;

    private void OnEnable()
    {
        _inputField = GetComponent<InputField>();
        _inputField.text = (-_enemy.Speed).ToString();
    }
}
