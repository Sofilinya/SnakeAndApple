using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameField : MonoBehaviour
{

    // ������� ������ ������
    public Transform _firstCellPoint;

    // ������ ������ (�� X � Y)
    public Vector2 �ellSize;

    // ���������� ����� � ����� ����
    public int CellsInRow = 12;

    // ��������� ������ �� ������� ������ ������
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
        // ���� �� �����������

        // ���� �� ��������� 

        // ������ ��������� ������ �������� CellsInRow x CellsInRow
        _cellsPositions = new Vector2[CellsInRow, CellsInRow];

        // �������� �� ������ ����������� ���� ����� (i)
        for (int x = 0; x < CellsInRow; x++)
        {
            // �������� �� ������ ����������� ���� ����� (j)
            for (int y = 0; y < CellsInRow; y++)
            {
                // ������������� ������� ������� ������ � ������ � ������� � ������� i, j
                _cellsPositions[x, y] = (Vector2)_firstCellPoint.position + Vector2.right * x * �ellSize.x + Vector2.up * y * �ellSize.y;
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
