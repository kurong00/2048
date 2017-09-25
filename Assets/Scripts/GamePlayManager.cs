using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : Singleton<GamePlayManager> {

    Cell[,] allCells = new Cell[4,4];
    List<Cell> emptyCells = new List<Cell>();
    void Start()
    {
        InitCell();
    }

    void InitCell()
    {
        
        Cell[] cellList = GameObject.FindObjectsOfType<Cell>();
        /*for(int i = 0; i < 4; i++)
        {int temp = 0;
            for(int j = 0; j < 4; j++)
            {
                cellList[temp].row = i;
                cellList[temp].col = j;
                cellList[temp].Number = 0;
                allCells[i, j] = cellList[temp];
                emptyCells.Add(cellList[temp]);
                temp++;
            }
        }*/
        foreach(Cell c in cellList)
        {
            c.Number = 0;
            allCells[c.row, c.col] = c;
            emptyCells.Add(c);
        }
    }

    void InitEmptyCellList()
    {
        if (emptyCells.Count > 0)
        {
            int index = Random.Range(0, emptyCells.Count);
            int random = Random.Range(0, 10);
            if (random == 0)
                emptyCells[index].Number = 4;
            else
                emptyCells[index].Number = 2;
            emptyCells.RemoveAt(index);
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
