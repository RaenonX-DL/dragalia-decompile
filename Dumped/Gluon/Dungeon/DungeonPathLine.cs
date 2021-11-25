using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonPathLine : MonoBehaviour
	{
		public class PathPoint
		{
			private DungeonPathLine _line;

			public DungeonPathLine line
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int index
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public PathPoint(DungeonPathLine initLine)
			{
			}

			public Vector3 GetPosition()
			{
				return default(Vector3);
			}

			public bool IsEndPoint()
			{
				return default(bool);
			}

			public Vector3 GetPrevPointPosition()
			{
				return default(Vector3);
			}

			public void SetNextPoint()
			{
			}

			public float GetPathLengthToEnd()
			{
				return default(float);
			}

			public bool IsForceRouteMode()
			{
				return default(bool);
			}
		}

		private class PathCalcInfo
		{
			public float allLength;

			public void SetData(PathCalcInfo info)
			{
			}
		}

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

		public bool IsEnablePath()
		{
			return default(bool);
		}

		public List<GameObject> GetPointList()
		{
			return null;
		}

		public int GetPointIndex(GameObject obj)
		{
			return default(int);
		}

		public List<Vector3> GetPositionList()
		{
			return null;
		}

		public PathPoint GetFirstPoint()
		{
			return null;
		}

		public Vector3 GetPointPosition(int index)
		{
			return default(Vector3);
		}

		public List<GameObject> GetPointListCurrentBranch([Optional] List<GameObject> logObjList, int index = 0)
		{
			return null;
		}

		public float GetPathLengthToEnd(int index = 0)
		{
			return default(float);
		}

		private void SeekBranch(List<PathCalcInfo> infoList, PathCalcInfo currentInfo, GameObject lastConnectObj, DungeonPathLine checkLine, int firstIndex = 0)
		{
		}

		private float GetMagnitude(Vector3 pos1, Vector3 pos2)
		{
			return default(float);
		}

		public float GetPathLengthMax()
		{
			return default(float);
		}
	}
}
