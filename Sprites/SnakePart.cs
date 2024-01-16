using UnityEngine;

public class SnakePart : MonoBehaviour
{
    // ������� ������ � ������ ������
    private Vector2Int _cellId;

    public void SetCellPosition(Vector2Int cellId, Vector2 position)
    {
        // ����� ���������� _cellId ���������� ��������
        _cellId = cellId;

        // ������������� ������� ����� ������ �� �����
        transform.position = position;
    }

    public Vector2Int GetCellId()
    {
        // ���������� �������� ���������� _cellId
        return _cellId;
    }
}