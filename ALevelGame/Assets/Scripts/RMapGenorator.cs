using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{
    public GameObject[] nodes;
    public List<Room> roomsList = new List<Room>();
    public Room Room;
    public List<ObjectLocation> wallsList = new List<ObjectLocation>();
    private int[,] WeightToMoveArray = new int [50,50];
    public const int maxint = 2147483647;

    public void AddToRoomsList(Room room)
    {
        roomsList.Add(room);
    }

    public void AddToWallsList(List<ObjectLocation> walls)
    {
        foreach (var wallTile in walls)
        {
            wallsList.Add(wallTile);  
        }
    }

    void Start()
    {
        waitTillEnd();

        foreach (var wall in wallsList)
        {
            int wallx = wall._x;
            int wally = wall._y;

            WeightToMoveArray[wallx, wally] = maxint;

        }
    }

    IEnumerator waitTillEnd()
    {
        yield return new WaitForEndOfFrame();
    }

}

public class Room
{
    int _x;
    int _y;
    List<ObjectLocation> _doors;

    public Room(int x, int y, List<ObjectLocation> doors)
    {
        _x = x;
        _y = y;
        _doors = doors;
    }
}

public class ObjectLocation
{
    public int _x;
    public int _y;
    int _direction;

    public ObjectLocation(int x, int y, int direction)
    {
        _x = x;
        _y = y;
        _direction = direction;
    }
}

public class ArraySquareWeights
{
    int _x;
    int _y;
    int _weightOfMoving;
    int _SteppingWeight;

    public ArraySquareWeights(int x, int y, int weightOfMoving,int SteppingWeight)
    {
        _x = x;
        _y = y;
        _weightOfMoving = weightOfMoving;
        _SteppingWeight = SteppingWeight;
    }
}