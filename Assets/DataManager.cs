using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DataManager : MonoBehaviour
{
	public string PlayerName;
	public GameObject BestScoreText;
	
	
    // Start is called before the first frame update
    void Start()
	{
		BestScoreText = GameObject.Find("BestScoreText");
		BestScoreText.GetComponent<Text>().text = "Best Score: " + PlayerPrefs.GetString("bestPlayer") + " Points: " + PlayerPrefs.GetInt("bestScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public static DataManager Instance;
	
	private void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}
	
	public void SavePlayerName()
	{
		//PlayerName = PlayerNameInputArea.GetComponent<Text>().text;
		PlayerPrefs.SetString("currentPlayer", PlayerName);
		return;
	}
	
	public void StartNewGame()
	{
		SavePlayerName();
		SceneManager.LoadScene("main");
		Debug.Log(PlayerPrefs.GetString("currentPlayer"));
	}
	
	public void QuitTheGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
		Application.Quit();
	}
	
	public void DebugTest()
	{
		Debug.Log("bottone premuto");
	}
}
