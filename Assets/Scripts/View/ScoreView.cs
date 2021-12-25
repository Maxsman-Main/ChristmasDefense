using UnityEngine;
using TMPro;
using Characters;

namespace View
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreDisplay;
        [SerializeField] private Player _player;

        private void OnEnable()
        {
            _player.OnScoreUpdated += UpdateScoreView;
        }

        private void UpdateScoreView(int score)
        {
            _scoreDisplay.text = score.ToString();
        }
    }
}