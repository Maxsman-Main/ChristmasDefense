using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Characters;
public class RedSnow : Snow
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.TryGetComponent(out Player player)&&
            !other.gameObject.TryGetComponent(out Snow snow))
        {
            if (other.gameObject.TryGetComponent(out RedEnemy redEnemy))
            {
                _player.TakeScorePoints(redEnemy.Points);
            }
            else
            {
                _player.TakeDamage(5);
            }
            Die();
        }
    }
}
