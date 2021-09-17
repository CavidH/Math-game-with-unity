using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayConroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ArrayElement[] arrayElements = new ArrayElement[2];
    [SerializeField] private TextMeshProUGUI leveltext;

    private int _levelindex;
    private void Start()
    {
        _levelindex = PlayerPrefs.GetInt("LevelIndex");
        Debug.Log(_levelindex);
        leveltext.text = "Level" + (_levelindex + 1);

    }

}
[System.Serializable]
public class ArrayElement
   
{ 
      
    public string[] Element = new string[2];
}
