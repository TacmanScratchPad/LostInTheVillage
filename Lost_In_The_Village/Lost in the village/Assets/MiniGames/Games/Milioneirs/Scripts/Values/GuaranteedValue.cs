using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts.IfCurrent
{
    public class GuaranteedValue : MonoBehaviour
    {
        [SerializeField] private int position;

        private void Update()
        {
            if (MilioneirsQuestions.CurrentPosition == position) { transform.GetComponent<Image>().color = Color.red; }
            else transform.GetComponent<Image>().color = new Color(0.0017f, 0.0f, 0.7547f);
        }
    }
}