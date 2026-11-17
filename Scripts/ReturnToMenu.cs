using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void LoadMenuScene() 
    {
        SceneManager.LoadScene(0);
    }
  
}
