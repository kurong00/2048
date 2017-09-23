using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CellStyle
{
    public int number;
    public Color32 cellColor;
    public Color32 textColor;
}

public class CellManager : Singleton<CellManager>
{
    public CellStyle[] cellStyle;

    private void Start()
    {
        cellStyle[0].number = 2;
        cellStyle[0].cellColor = new Color32(239, 227, 114, 0);
        cellStyle[0].textColor = new Color32(126, 109, 80, 0);

        cellStyle[1].number = 4;
        cellStyle[1].cellColor = new Color32(236, 154, 90, 0);
        cellStyle[1].textColor = new Color32(255, 255, 255, 0);
    }
}
