using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayConroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ArrayElement[] QuestionsAnswers = new ArrayElement[2];
    [SerializeField] private TextMeshProUGUI leveltext;
    [SerializeField] private TextMeshProUGUI equationtext;
    [SerializeField] private TextMeshProUGUI answertext;
    [SerializeField] private GameObject mainMenuPanelpanel;

    [SerializeField] private Text text;
    

    private bool isclean;

    private int _levelindex;
    private void Start()
    {
        mainMenuPanelpanel.SetActive(false);

        _levelindex = PlayerPrefs.GetInt("LevelIndex");
        //Debug.Log(_levelindex);
        leveltext.text = "Level" + (_levelindex + 1);
        equationtext.text = QuestionsAnswers[_levelindex].Element[0];
    }
    public void reloadmenubutoon()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void levelchancger(int i) 
    {
        leveltext.text = "Level" + (i + 1);
        equationtext.text = QuestionsAnswers[i].Element[0];
    }
    public void onEnterButoon()
    {
        if (answertext.text==QuestionsAnswers[_levelindex].Element[1])
        {
            Debug.Log("true");
            text.color = Color.green;
            text.text = "Cavab dogrudu";
            answertext.text = "";
            _levelindex++;
            levelchancger(_levelindex);

        }
        else
        {
            mainMenuPanelpanel.SetActive(true);

        }

    }
    public void onNumberButoonPresed(int number)
    {
       
        if (!isclean)
        {
            answertext.text = "";
            isclean = true;


        }
        answertext.text += number;
    }
    public void onCleanTextButtonPressed()
    {
        answertext.text = "Enter Text..";
        isclean = false;
    }

}
[System.Serializable]
public class ArrayElement
   
{ 
      
    public string[] Element = new string[2];
}
