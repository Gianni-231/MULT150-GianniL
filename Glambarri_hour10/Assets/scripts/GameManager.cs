using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    private float elapsedTime = 0;
     public GoalScript blue, green, red, orange;
     private bool isRunning = false;
    private bool isGameOver = true;
    private bool isFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update ()
    {
        // If all four goals are solved then the game is over
       isGameOver = blue.isSolved && green.isSolved && red.isSolved &&  orange.isSolved;
       if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
    }
    private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;
    }
void OnGUI() {
		
		if(!isRunning)
		{
			string message;

			if(isFinished)
			{
				message = "Click or Press Enter to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}
		}
		
		// If the player finished the game, show the final time
		if(isFinished)
		{
			GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
	}

}
