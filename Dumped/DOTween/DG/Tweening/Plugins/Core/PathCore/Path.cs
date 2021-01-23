/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins.Core.PathCore
{
	[Serializable]
	public class Path
	{
		// Fields
		private static CatmullRomDecoder _catmullRomDecoder;
		private static LinearDecoder _linearDecoder;
		public float[] wpLengths;
		[SerializeField]
		internal PathType type;
		[SerializeField]
		internal int subdivisionsXSegment;
		[SerializeField]
		internal int subdivisions;
		[SerializeField]
		internal Vector3[] wps;
		[SerializeField]
		internal ControlPoint[] controlPoints;
		[SerializeField]
		internal float length;
		[SerializeField]
		internal bool isFinalized;
		[SerializeField]
		internal float[] timesTable;
		[SerializeField]
		internal float[] lengthsTable;
		internal int linearWPIndex;
		private Path _incrementalClone;
		private int _incrementalIndex;
		private ABSPathDecoder _decoder;
		private bool _changed;
		internal Vector3[] nonLinearDrawWps;
		internal Vector3 targetPosition;
		internal Vector3? lookAtPosition;
		internal Color gizmoColor;
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Color? gizmoColor = default);
		internal Path();
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal);
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false);
		internal float ConvertToConstantPathPerc(float perc);
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment);
		internal static void RefreshNonLinearDrawWps(Path p);
		internal void Destroy();
		internal Path CloneIncremental(int loopIncrement);
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false);
		internal void AssignDecoder(PathType pathType);
		internal void Draw();
		private static void Draw(Path p);
	}
}
