using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class PauseTranslate : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI Resume;
        [SerializeField] private TextMeshProUGUI Restart;
        [SerializeField] private TextMeshProUGUI GameLevel;
        [SerializeField] private TextMeshProUGUI Easy;
        [SerializeField] private TextMeshProUGUI Medium;
        [SerializeField] private TextMeshProUGUI Hard;
        [SerializeField] private TextMeshProUGUI Quit;
        [SerializeField] private TextMeshProUGUI Music;
        [SerializeField] private TextMeshProUGUI Sounds;

        private void Start()
        {
            (Resume.text, Restart.text, GameLevel.text, Easy.text, Medium.text, Hard.text, Quit.text, Music.text, Sounds.text) = LanguagesTranslation.SetTextMenu();
        }
    }
}
