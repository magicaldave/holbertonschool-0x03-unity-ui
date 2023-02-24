using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void start()
	{
	}

	// Init the MAZE GAEM
	public void PlayMaze()
	{
		// Brackeys used the Build Index instead, perhaps faster than iterating through all scenes?
		// Since this project has two scenes it is at worst, O(2), so no big deal.
		SceneManager.LoadSceneAsync("Maze");
	}

	public void QuitMaze()
	{
		if (Application.platform.ToString().Contains("Editor"))
			Debug.Log("Quit Game");
		else
			Application.Quit();
	}
}
