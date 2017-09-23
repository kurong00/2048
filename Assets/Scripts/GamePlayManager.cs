using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : Singleton<GamePlayManager> {

    Cell[,] cell = new Cell[4,4];
    List<Cell> emptyCell = new List<Cell>();
    void Start()
    {
        InitCell();
    }

    void InitCell()
    {
        int temp = 0;
        Cell[] cellList = GameObject.FindObjectsOfType<Cell>();
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                cellList[temp].row = i;
                cellList[temp].col = j;
                cellList[temp].Number = 0;
                cell[i, j] = cellList[temp];
                emptyCell.Add(cellList[temp]);
                temp++;
            }
        }
    }

    void InitEmptyCellList()
    {
        Debug.Log(emptyCell.Count+"aaaaa");
        if (emptyCell.Count > 0)
        {
            int index = Random.Range(0, emptyCell.Count);
            int random = Random.Range(0, 10);
            if (random == 0)
                emptyCell[index].Number = 4;
            else
                emptyCell[index].Number = 2;
            Debug.Log(index);
            emptyCell.RemoveAt(index);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitEmptyCellList();
        }
    }

    public void Move(MoveDirection move)
    {
        Debug.Log(move.ToString());
    }
}
