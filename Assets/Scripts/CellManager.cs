using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CellStyle
{
    public int number;
    public Color cellColor;
    public Color textColor;
}

public class CellManager : Singleton<CellManager> {
    public CellStyle[] cell;
}
