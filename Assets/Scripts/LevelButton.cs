using UnityEngine;
using System.Collections;

public class LevelButton : MonoBehaviour {

	public string level;
	private string baseScene = "BaseScene";

	public void loadLevel(){
		Application.LoadLevel (baseScene);
		Application.LoadLevelAdditive (level);
        Application.LoadLevelAdditive("UIHUD");
        Time.timeScale = 1.0f;
	}

	public void loadLevelNumber(int i)
	{
		Application.LoadLevel (baseScene);
		Statics.currentLevel = i;
		Application.LoadLevelAdditive (Statics.levels[i]);
		Application.LoadLevelAdditive("UIHUD");
	}
	public void loadNextLevel(){
		Application.LoadLevel (baseScene);
		//TODO: If hit max level, handle properly
		if (Statics.currentLevel < Statics.levels.Length) {
			Statics.currentLevel += 1;
			Debug.Log ("CurrentLevel " + Statics.currentLevel);
			if (Statics.latestUnlockedLevel < Statics.currentLevel)
				Statics.latestUnlockedLevel = Statics.currentLevel;
		}
		else
			Statics.currentLevel = 0;
		Application.LoadLevelAdditive (Statics.levels[Statics.currentLevel]);
		Application.LoadLevelAdditive("UIHUD");
	}

	public void reloadLevel()
	{
		LoadManager.UnloadSelf ();
		Application.LoadLevel (baseScene);
		Application.LoadLevelAdditive (Statics.levels[Statics.currentLevel]);
		Application.LoadLevelAdditive("UIHUD");
	}


	public void loadBaseScene(){
		Application.LoadLevel (baseScene);
	}

	public void loadLevelAdditive(){
		Application.LoadLevelAdditive (level);
	}

	public void loadLevelAdditive(string sceneName){
		Application.LoadLevelAdditive (sceneName);
	}

	public void unloadScene(){
		Debug.Log ("Now unloading self");
		LoadManager.UnloadSelf ();
	}

    public void exitToMenu()
    {
        Application.LoadLevel(baseScene);
        Application.LoadLevelAdditive(level);
    }

    public void loadLevelSelect()
    {
        Application.LoadLevel(baseScene);
        Application.LoadLevelAdditive(level);
    }


}
