using Characters;
using UnityEngine;

public class SnowInitializer : MonoBehaviour
{
    [SerializeField] private Player _player;

    public void Initialize(Snow _snow)
    {
        _snow.Init(_player);
    }
}
