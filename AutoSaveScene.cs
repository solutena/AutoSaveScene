using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEditor;

[InitializeOnLoad]
public static class AutoSaveScene
{
	static AutoSaveScene()
	{
		EditorApplication.playModeStateChanged += LogPlayModeState;
	}

	static void LogPlayModeState(PlayModeStateChange state)
	{
		if(state == PlayModeStateChange.ExitingEditMode)
			EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
	}
}