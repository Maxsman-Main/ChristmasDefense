using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteEnemy : Enemy
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out WhiteSnow snow))
        {
            Die();
        }
    }
}
