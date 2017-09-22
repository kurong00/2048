using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : Singleton<GamePlayManager> {

    void Start()
    {
        InitCell();
    }

    void InitCell()
    {
        Cell[] cellList = GameObject.FindObjectsOfType<Cell>();
        foreach (Cell t in cellList)
        {
            t.Number = 0;
        }
    }

    void Update()
    {

    }

    public void Move(MoveDirection move)
    {
        Debug.Log(move.ToString());
    }
}
