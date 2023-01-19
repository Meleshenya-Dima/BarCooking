using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public List<PathPosition> pathPositions;

    public void OnDrawGizmos()
    {
        if (pathPositions == null || pathPositions.Count < 2)
            return;
        for (int i = 1; i < pathPositions.Count; i++)
            Gizmos.DrawLine(pathPositions[i - 1].Position.position, pathPositions[i].Position.position);
    }

    public bool GetFirstPositionOpen()
    {
        return pathPositions[0].IsFree;
    }

    public (Transform, int, bool) CheckNextPosition(int nowIndexPosition)
    {
        if (pathPositions.Count - 1 == nowIndexPosition)
        {
            return (pathPositions[nowIndexPosition].Position, nowIndexPosition, true);
        }   

        else if (pathPositions[nowIndexPosition + 1].IsFree)
        {
            int newIndexPosition = nowIndexPosition + 1;
            pathPositions[newIndexPosition].IsFree = false;
            pathPositions[nowIndexPosition].IsFree = true;
            return (pathPositions[nowIndexPosition].Position, newIndexPosition, true);
        }

        else
        {
            pathPositions[nowIndexPosition].IsFree = false;
            return (pathPositions[nowIndexPosition].Position, nowIndexPosition, true);
        }
    }

    public void BuyerUpdatePosition(int nowIndexPosition)
    {
        pathPositions[nowIndexPosition].IsFree = true;
    }
}