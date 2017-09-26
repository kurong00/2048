using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {

    [HideInInspector]
    public bool addNumber = false;
    public int row,col;
    int number;
    Text cellText;
    Image cellBackground;
    CellStyleHolder cellStyleHolder;

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            if (number == 0)
            {
                SetCellHide();
            }
            else
            {
                ChangeCellStyle(number);
                SetCellVisual();
            }
        }
    }

    private void Awake()
    {
        cellBackground = transform.GetChild(0).GetComponent<Image>();
        cellText = transform.GetChild(1).GetComponent<Text>();
        cellStyleHolder = CellStyleHolder.Instance();
    }

    void GetCellStyle(int index)
    {
        cellBackground.color = cellStyleHolder.cellStyle[index].cellColor;
        cellText.color = cellStyleHolder.cellStyle[index].textColor;
        cellText.text = cellStyleHolder.cellStyle[index].number.ToString();
    }

    void ChangeCellStyle(int index)
    {
        switch (index)
        {
            case 2:
                GetCellStyle(0);
                break;
            case 4:
                GetCellStyle(1);
                break;
            case 8:
                GetCellStyle(2);
                break;
            case 16:
                GetCellStyle(3);
                break;
            case 32:
                GetCellStyle(4);
                break;
            case 64:
                GetCellStyle(5);
                break;
            case 128:
                GetCellStyle(6);
                break;
            case 256:
                GetCellStyle(7);
                break;
            case 512:
                GetCellStyle(8);
                break;
            case 1024:
                GetCellStyle(9);
                break;
            case 2048:
                GetCellStyle(10);
                break;
            case 4096:
                GetCellStyle(11);
                break;
            case 8192:
                GetCellStyle(12);
                break;
            default:
                Debug.LogError("invalid number!");
                break;
        }
    }

    void SetCellVisual()
    {
        cellText.enabled = true;
        cellBackground.enabled = true;
    }

    void SetCellHide()
    {
        cellText.enabled = false;
        cellBackground.enabled = false;
    }

    public void ResetAddNumberFlag()
    {
        addNumber = false;
    }
}
