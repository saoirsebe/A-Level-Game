using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{


    public GameObject[] nodes;

    /*
    public List<Transform> findShortestPath(Transform start,Transform end)
    {
        nodes = GameObject.FindGameObjectsWithTag("Door");

        List<Transform> result = new List<Transform>();
        Transform node = dijkstrasAlgo(start, end);

        while (node != null)
        {
            result.Add(node);
            Node currentNode = node.GetComponent<Node>();
            node = currentNode.getParentNode();
        }
        //result.Reverse();
        return result;
    }

    private Transform dijkstrasAlgo(Transform start, Transform end)
    {
        double startTime = Time.realtimeSinceStartup;

        List<Transform> unexplored = new List<Transform>(); //unexplored nodes
        foreach (GameObject obj in nodes)
        {
            Node n = obj.GetComponent<Node>();
            if (n.isWalkable())
            {
                n.resetNode();
                unexplored.Add(obj.transform);
            }
        }
        Node startNode = start.GetComponent<Node>();
        startNode.setWeight(0);

        while (unexplored.Count > 0)
        {
            // Sort the explored by their weight in ascending order.
            unexplored.Sort((x, y) => x.GetComponent<Node>().getWeight().CompareTo(y.GetComponent<Node>().getWeight()));

            // Get the lowest weight in unexplored.
            Transform current = unexplored[0];
            unexplored.Remove(current);

            Node currentNode = current.GetComponent<Node>();
            List<Transform> neighbours = currentNode.getNeighbourNode();
            foreach (Transform neighNode in neighbours)
            {

            }

        }*/



    public List<Vector2Int> shortestPathCoriidors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors

        nodes = GameObject.FindGameObjectsWithTag("Door");

        int doorsNotConnected = nodes.Length; //Nodes unconnected
        

        List<int> doorsnotUsed = new List<int>(); //List of indices of doors not conneted to others in nodes
        int n = 0;
        for (int i = 0; i < doorsNotConnected; i++) //Adds number 0,1,2.. to doorsnotUsed to get indeces in nodes of doors not Connected to others
        {
            doorsnotUsed.Add(n);
            n += 1;
        }

        while (doorsNotConnected >0)
        {

            //

            int doorsNotVisitedLength = nodes.Length; //number of doors not visited
            List<int> doorsnotVisited = new List<int>(); //List of indices of doors not visited in doorsList/nodes
            int n1 = 0;
            for (int i = 0; i < doorsNotVisitedLength; i++) //Adds number 0,1,2.. to doorsnotVisited to get indeces of doors not visited by this door in nodes
            {
                doorsnotVisited.Add(n);
                n1 += 1;
            }


            while (doorsNotVisitedLength > 0)
            {
                //?int rand1 = Random.Range(0, doorsNotVisitedLength);
                //DoorToConnect = nodes(1); //Ramdom door



                doorsnotVisited.RemoveAt(rand1);
                doorsNotVisitedLength -= 1;


            }

            doorsNotConnected -= 1; //One less door not connected
        }



        return corridors;

    }
}
