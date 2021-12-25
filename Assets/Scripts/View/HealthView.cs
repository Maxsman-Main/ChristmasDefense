using Characters;
using TMPro;
using UnityEngine;

namespace View
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _healthDisplay;
        [SerializeField] private Player _player;

        private void OnEnable()
        {
            _player.OnDamaged += UpdateHealthView;
            _healthDisplay.text = 100.ToString();
        }

        private void UpdateHealthView(int health)
        {
            _healthDisplay.text = health.ToString();
        }
    }
}
