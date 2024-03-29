﻿using UnityEngine;
using System.Collections;

public class MazeCell : MonoBehaviour {

	public IntVector2 coordinates; 

	private MazeCellEdge[] edges = new MazeCellEdge[MazeDirections.COUNT];

	private int initializedEdgeCount;

	public MazeCellEdge GetEdge (MazeDirection direction) {
		return edges [(int)direction];
	}

	public void SetEdge (MazeDirection direction, MazeCellEdge edge) {
		edges [(int)direction] = edge;
		initializedEdgeCount += 1; 
	}

	public bool IsFullyInitialized {
		get {
			return initializedEdgeCount == MazeDirections.COUNT;
		}
	}

	public MazeDirection RandomUninitializedDirection {
		get {
			int skips = Random.Range(0, MazeDirections.COUNT - initializedEdgeCount);
			for (int i = 0; i < MazeDirections.COUNT; i++) {
				if (edges[i] == null) {
					if (skips == 0) {
						return (MazeDirection)i;
					}
					skips -= 1;
				}
			}
			throw new System.InvalidOperationException("MazeCell has no uninitialized directions left.");
		}
	}

}
