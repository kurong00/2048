using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MoveDirection
{
    Left,
    Right,
    Up,
    Down
}
public class InputManager : MonoBehaviour {
    
    GamePlayManager gamePlayManager;
	void Start () {
        gamePlayManager = GamePlayManager.Instance();
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gamePlayManager.Move(MoveDirection.Left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gamePlayManager.Move(MoveDirection.Right);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gamePlayManager.Move(MoveDirection.Up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gamePlayManager.Move(MoveDirection.Down);
        }
    }
}
