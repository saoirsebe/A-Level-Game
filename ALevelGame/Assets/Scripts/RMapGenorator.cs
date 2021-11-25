using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{

    public GameObject[] nodes;
    public List<Room> roomsList = new List<Room>();
    public Room Room;



    public List<Vector2Int> shortestPathCoridors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors


        return corridors;

    }
}

public class Room
{
    int x;
    int y;
    List<Door> doors;

    public Room(int x, int y, List<Door> doors)
    {
    }
}

public class Door
{
    int x;
    int y;
    int direction;

    public Door(int x, int y, int direction)
    {
    }
}
