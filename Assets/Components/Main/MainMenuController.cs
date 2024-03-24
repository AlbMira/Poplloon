using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace Poplloon.main
{
    public class MainMenuController : Singleton<MainMenuController>
    {
        [SerializeField] private TextMeshProUGUI _filterText;
        public static int indexFilter;

        private void LateUpdate()
        {
            _filterText.text = SetFilterController.colorBlindFilters[indexFilter];
        }

        private void Update()
        {
            if (indexFilter < 0)
            {
                indexFilter += 5;
            }

            if (indexFilter > 4)
            {
                indexFilter -= 5;
            }
        }

        public void PlayGame(string input)
        {
            input = SetFilterController.colorBlindFilters[indexFilter];

            SceneManager.LoadScene("Play");
        }

        public void RightArrow()
        {
            indexFilter++;
        }

        public void LeftArrow()
        {
            indexFilter--;
        }
    }
}
