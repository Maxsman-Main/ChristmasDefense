using System;
using UnityEngine;
using Characters;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _points;
    
    public int Damage => _damage;
    public int Points => _points;

    protected void Die()    
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out Player player))
        {
            Die();
        }
    }
}
