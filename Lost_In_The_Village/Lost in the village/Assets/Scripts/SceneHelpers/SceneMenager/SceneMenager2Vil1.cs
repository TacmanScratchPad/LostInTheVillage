using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneMenager
{
    public class SceneMenager2Vil1 : MonoBehaviour
    {
        private void Start()
        {
            SceneMenager2.CurrentScene = Helpers.Scenes.Village1;
        }
    }
}
