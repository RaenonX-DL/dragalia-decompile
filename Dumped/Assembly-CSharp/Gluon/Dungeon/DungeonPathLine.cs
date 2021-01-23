/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonPathLine : MonoBehaviour
	{
		// Fields
		public List<Switch> linkSwitchList;
		[HideInInspector]
		[SerializeField]
		public GameObject nextPathPoint;
		public static readonly int isForceRouteModePointIndexNone;
		[HideInInspector]
		public int isForceRouteModePointIndex;
		[HideInInspector]
		[SerializeField]
		private List<GameObject> pointList;
	
		// Nested types
		public class PathPoint
		{
			// Fields
			private DungeonPathLine _line;
			[CompilerGenerated]
			private int _index_k__BackingField;
	
			// Properties
			public DungeonPathLine line { get; set; }
			public int index { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public PathPoint(DungeonPathLine initLine);
	
			// Methods
			public Vector3 GetPosition();
			public bool IsEndPoint();
			public Vector3 GetPrevPointPosition();
			public void SetNextPoint();
			public float GetPathLengthToEnd();
			public bool IsForceRouteMode();
		}
	
		private class PathCalcInfo
		{
			// Fields
			public float allLength;
	
			// Constructors
			public PathCalcInfo();
	
			// Methods
			public void SetData(PathCalcInfo info);
		}
	
		// Constructors
		public DungeonPathLine();
		static DungeonPathLine();
	
		// Methods
		public bool IsEnablePath();
		public List<GameObject> GetPointList();
		public int GetPointIndex(GameObject obj);
		public List<Vector3> GetPositionList();
		public PathPoint GetFirstPoint();
		public Vector3 GetPointPosition(int index);
		public List<GameObject> GetPointListCurrentBranch(List<GameObject> logObjList = null, int index = 0);
		public float GetPathLengthToEnd(int index = 0);
		private void SeekBranch(List<PathCalcInfo> infoList, PathCalcInfo currentInfo, GameObject lastConnectObj, DungeonPathLine checkLine, int firstIndex = 0);
		private float GetMagnitude(Vector3 pos1, Vector3 pos2);
		public float GetPathLengthMax();
	}
}
