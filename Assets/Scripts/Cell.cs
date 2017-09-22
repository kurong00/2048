using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {

    [HideInInspector]
    public int row,col;
    int number;
    Text cellText;
    Image cellBackground;
    CellManager cellManager;

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
                SetCellCHide();
            }
            else
            {
                ChangeCellStyle(number);
                SetCellCVisual();
            }
        }
    }

    private void Awake()
    {
        cellBackground = transform.GetChild(0).GetComponent<Image>();
        cellText = transform.GetChild(1).GetComponent<Text>();
        cellManager = CellManager.Instance();
    }

    void GetCellStyle(int index)
    {
        cellBackground.color = cellManager.cell[index].cellColor;
        cellText.color = cellManager.cell[index].textColor;
        cellText.text = cellManager.cell[index].number.ToString();
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
                Debug.Log("invalid number!");
                break;
        }
    }

    void Start () {
		
	}
	

	void Update () {
		
	}

    void SetCellCVisual()
    {
        cellText.enabled = true;
        cellBackground.enabled = true;
    }

    void SetCellCHide()
    {
        cellText.enabled = false;
        cellBackground.enabled = false;
    }
}
