using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{
	public TMP_Text PlayerNameInputField;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	
	public void SavePlayerName()
	{
		DataManager.Instance.PlayerName = PlayerNameInputField.text;
		Debug.Log(PlayerNameInputField.text);
	}
		
}
