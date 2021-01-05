using UnityEngine;
using UnityEngine.SceneManagement;

namespace Solid.Presentation
{
    /// <summary>
    /// Not relevant, this is just for the sake of the first presentation screen in the first scene
    /// </summary>
    public class SwitchPanel : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _panels;

        [SerializeField]
        private string _nextSceneName = "1.1 - Bad_SRP";

        private int _currentPanelIndex = 0;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (_currentPanelIndex == 0)
                    return;

                _panels[_currentPanelIndex].SetActive(false);
                _currentPanelIndex--;
                _panels[_currentPanelIndex].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (_currentPanelIndex == _panels.Length - 1)
                    return;

                _panels[_currentPanelIndex].SetActive(false);
                _currentPanelIndex++;
                _panels[_currentPanelIndex].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(_nextSceneName);
            }
        }
    }
}