using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IWeaponSnow
{
    [SerializeField] private WhiteSnow _whiteSnow;
    [SerializeField] private RedSnow _redSnow;
    [SerializeField] private BlueSnow _blueSnow;
    [SerializeField] private GreySnow _greySnow;
    [SerializeField] private SnowInitializer _initializer;
    [SerializeField] private AudioSource _source;

    private Transform _transform;
    
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    
    public void AttackWhiteSnow()
    {
        var newSnow = Instantiate(_whiteSnow, _transform);
        _initializer.Initialize(newSnow);
        _source.Play();
    }

    public void AttackRedSnow()
    {
        var newSnow = Instantiate(_redSnow, _transform);
        _initializer.Initialize(newSnow);
        _source.Play();
    }
    
    public void AttackBlueSnow()
    {
        var newSnow = Instantiate(_blueSnow, _transform);
        _initializer.Initialize(newSnow);
        _source.Play();
    }
    
    public void AttackGreySnow()
    {
        var newSnow = Instantiate(_greySnow, _transform);
        _initializer.Initialize(newSnow);
        _source.Play();
    }
}
