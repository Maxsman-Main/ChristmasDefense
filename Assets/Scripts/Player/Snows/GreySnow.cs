using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Characters;

public class GreySnow : Snow
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.TryGetComponent(out Player players)&&
            !other.gameObject.TryGetComponent(out Snow snow))
        {
            if (other.gameObject.TryGetComponent(out GreyEnemy whiteEnemy))
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
