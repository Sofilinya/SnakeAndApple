using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameField : MonoBehaviour
{

    // Позиция первой ячейки
    public Transform _firstCellPoint;

    // Размер ячейки (по X и Y)
    public Vector2 СellSize;

    // Количество ячеек в одном ряду
    public int CellsInRow = 12;

    // Двумерный массив из позиций каждой ячейки
    private Vector2[,] _cellsPositions;
    // Start is called before the first frame update
    void Start()
    {
        _firstCellPoint = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FillCellPosition()
    {
        // цикл по горизонтали

        // цикл по вертикали 

        // Создаём двумерный массив размером CellsInRow x CellsInRow
        _cellsPositions = new Vector2[CellsInRow, CellsInRow];

        // Проходим по первым координатам всех ячеек (i)
        for (int x = 0; x < CellsInRow; x++)
        {
            // Проходим по вторым координатам всех ячеек (j)
            for (int y = 0; y < CellsInRow; y++)
            {
                // Устанавливаем позицию текущей ячейки с учётом её размера и номеров i, j
                _cellsPositions[x, y] = (Vector2)_firstCellPoint.position + Vector2.right * x * СellSize.x + Vector2.up * y * СellSize.y;
            }
        }
    }
  
  public Vector2 GetCellPosition(uint x, uint y)
  {
    if(x >= CellsInRow || y >= CellsInRow) 
    {
      return Vector2.zero;
    }
    return _cellsPositions[x, y];
  }

}
