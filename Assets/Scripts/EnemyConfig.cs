using UnityEngine;
using UnityEngine.UI;

public class EnemyConfig : MonoBehaviour
{
    [SerializeField] private Mover _whiteEnemy;
    [SerializeField] private Mover _blueEnemy;
    [SerializeField] private Mover _redEnemy;

    [SerializeField] private InputField _whiteConfigInput;
    [SerializeField] private InputField _blueConfigInput;
    [SerializeField] private InputField _redConfigInput;

    public void SetWhiteEnemySpeed()
    {
        _whiteEnemy.SetMoveSpeed(-System.Convert.ToSingle(_whiteConfigInput.text));
    }
    
    public void SetBlueEnemySpeed()
    {
        _blueEnemy.SetMoveSpeed(-System.Convert.ToSingle(_blueConfigInput.text));
    }
    
    public void SetRedEnemySpeed()
    {
        _redEnemy.SetMoveSpeed(-System.Convert.ToSingle(_redConfigInput.text));
    }
}