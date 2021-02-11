﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PetriNet
{
    public NodeInfo[] nodeInfos;
    public EdgeInfo[] edgeInfos;
    public Vector3 camPos;
    public float camSize;

    public PetriNet(List<Node>nodes, List<Edge> edges)
    {
        int nodesLen = nodes.Count;
        int edgesLen = edges.Count;
        nodeInfos = new NodeInfo[nodesLen];
        edgeInfos = new EdgeInfo[edgesLen];
        for(int i=0; i<nodesLen; i++)
        {
            NodeInfo nodeInfo = new NodeInfo(nodes[i]);
            nodeInfos[i] = nodeInfo;
        }
        for (int i = 0; i < edgesLen; i++)
        {
            EdgeInfo edgeInfo = new EdgeInfo(edges[i]);
            edgeInfos[i] = edgeInfo;
        }
    }

    public void SetCamParam(Camera cam)
    {
        camPos = cam.transform.position;
        camSize = cam.orthographicSize;
        //Debug.Log(camPos + " " + camSize);
    }
}
