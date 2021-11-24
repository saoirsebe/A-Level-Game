using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomFirstGenerator : MapGenerator
{
    [SerializeField]
    private int minRoomWidth = 4, minRoomHeight = 4;
    [SerializeField]
    private int mapWidth = 20, mapHeight = 20;
    [SerializeField]
    [Range(0,10)]
    private int offset = 1; //to ensure rooms are not attatched
    [SerializeField]
    private bool randomRooms = false; //which generation

    //protected override void runProceduralGeneration()
    
}
