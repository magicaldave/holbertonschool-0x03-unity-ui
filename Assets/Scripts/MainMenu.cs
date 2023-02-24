using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
	public Toggle colorblindMode;
	public Material trapMat, goalMat;

	// Init the MAZE GAEM
	public void PlayMaze()
	{
		toggleColorBlind();
		// Brackeys used the Build Index instead, perhaps faster than iterating through all scenes?
		// Since this project has two scenes it is at worst, O(2), so no big deal.
		SceneManager.LoadSceneAsync("Maze");
	}

	public void QuitMaze()
	{
		trapMat.SetColor("_Color", Color.red);
		goalMat.SetColor("_Color", Color.green);

		if (Application.platform.ToString().Contains("Editor"))
			Debug.Log("Quit Game");
		else
			Application.Quit();
	}

	void toggleColorBlind()
	{
		if (colorblindMode.isOn)
		{
			// Sort of a bronzey color
			trapMat.SetColor("_Color", new Color32(255, 112, 0, 1));
			goalMat.SetColor("_Color", Color.blue);
		}
		else
		{
			trapMat.SetColor("_Color", Color.red);
			goalMat.SetColor("_Color", Color.green);
		}
	}
}

