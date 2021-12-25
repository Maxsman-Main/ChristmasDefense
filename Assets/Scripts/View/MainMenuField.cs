using UnityEngine;

namespace View
{
    enum Status
    {
        Opened,
        Closed
    }
    
    public class MainMenuField : MonoBehaviour, IUserInterface
    {
        [SerializeField] private Status _status;
        
        public void ClickAtField()
        {
            if (_status == Status.Closed)
            {
                ShowMenu();
            }
            else
            {
                CloseMenu();
            }
        }

        private void ShowMenu()
        {
            Time.timeScale = 0;
            _status = Status.Opened;
            gameObject.SetActive(true);
        }

        private void CloseMenu()
        {
            Time.timeScale = 1;
            _status = Status.Closed;
            gameObject.SetActive(false);
        }
    }
}