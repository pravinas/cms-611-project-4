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

    public void loadLevel(int i)
    {
        Application.LoadLevel(baseScene);
        Statics.currentLevel = i;
        Application.LoadLevelAdditive(Statics.levels[i]);
        Application.LoadLevelAdditive("UIHUD");
        Time.timeScale = 1.0f;
    }
    public void loadNextLevel(){
		Application.LoadLevel (baseScene);
        //TODO: If hit max level, handle properly
        Statics.currentLevel += 1;
        if (Statics.currentLevel < Statics.levels.Length) {
			if (Statics.latestUnlockedLevel < Statics.currentLevel)
				Statics.latestUnlockedLevel = Statics.currentLevel;
			Application.LoadLevelAdditive (Statics.levels [Statics.currentLevel]);
			Application.LoadLevelAdditive ("UIHUD");
		} else {
            Application.LoadLevelAdditive("EndGameScreen");
        }
	}

	public void reloadLevel()
	{
		LoadManager.UnloadSelf ();
		Application.LoadLevel (baseScene);
		Application.LoadLevelAdditive (Statics.levels[Statics.currentLevel]);
		Application.LoadLevelAdditive("UIHUD");
        Time.timeScale = 1.0f;
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
