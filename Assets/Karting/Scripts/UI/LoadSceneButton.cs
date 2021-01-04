using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;
        public bool again;

        public void LoadTargetScene() 
        {
            if((!again)&&(SceneName=="MainScene")&&(LevelManager.instance.levelNum<=2))
            {
                SceneManager.LoadSceneAsync(SceneName + (LevelManager.instance.levelNum+1).ToString());
            }
            if(again)
            {
                SceneManager.LoadSceneAsync(SceneName + LevelManager.instance.levelNum.ToString());
            }
            else
            {
                throw new System.Exception("没有对应的场景！");
            }
        }
    }
}
