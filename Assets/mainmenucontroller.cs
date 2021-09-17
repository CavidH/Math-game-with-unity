using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmenucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject levelsPanel;
    [SerializeField] private GameObject mainMenuPanel;

    public void onPlayButoonPressed()
    {
        PlayerPrefs.SetInt("LevelIndex", 0);
        SceneManager.LoadScene("GameplayScene");
 }
    public void onLevelButoonPressed()
    {
        mainMenuPanel.SetActive(false);
        levelsPanel.SetActive(true);

    }
    public void onExitButoonPressed()

   {
        Application.Quit();
    }
    
    public void onLevelExitButoon()
{
      
        levelsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }  
    public void onLeevelSelectButoon(int leveindex) {
        PlayerPrefs.SetInt("LevelIndex", leveindex);
        SceneManager.LoadScene("GameplayScene");
    }
}

