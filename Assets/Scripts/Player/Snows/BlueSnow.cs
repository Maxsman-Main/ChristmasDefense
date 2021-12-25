using System.Collections;
using System.Collections.Generic;
using Characters;
using UnityEngine;

public class BlueSnow : Snow
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.TryGetComponent(out Player player) &&
            !other.gameObject.TryGetComponent(out Snow snow))
        {
            if (other.gameObject.TryGetComponent(out BlueEnemy whiteEnemy))
            {
                _player.TakeScorePoints(whiteEnemy.Points);
            }
            else
            {
                _player.TakeDamage(5);
            }
            Die();
        }
    }
}
