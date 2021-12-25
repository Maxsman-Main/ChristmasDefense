using UnityEngine;
using Characters;
using System;

public abstract class Snow : MonoBehaviour
{

    protected IPlayer _player;

    public void Init(IPlayer player)
    {
        _player = player;
    }
    
    protected void Die()
    {
        Destroy(gameObject);
    }
}
