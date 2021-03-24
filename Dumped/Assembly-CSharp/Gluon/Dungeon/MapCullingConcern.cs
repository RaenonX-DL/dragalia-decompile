/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class MapCullingConcern : MonoBehaviour
	{
		// Fields
		private const int SplitFlustmX = 1;
		private const int SplitFlustmY = 1;
		private const int SplitFlustmZ = 5;
		private Vector3 ntlSub;
		private Vector3 ntrSub;
		private Vector3 nblSub;
		private Vector3 nbrSub;
		private Vector3 ftlSub;
		private Vector3 ftrSub;
		private Vector3 fblSub;
		private Vector3 fbrSub;
		private Vector3 tempVecMax;
		private Vector3 tempVecMin;
		private bool isFlustumInitrialized;
		private Bounds[,,] FlustomBounds;
		public static bool requestFrustumSetup;
		[SerializeField]
		private int _xCellNum;
		[SerializeField]
		private int _zCellNum;
		[SerializeField]
		private int _xMin;
		[SerializeField]
		private int _xMax;
		[SerializeField]
		private int _zMin;
		[SerializeField]
		private int _zMax;
		[SerializeField]
		private Cell[] _cells;
		[SerializeField]
		private int _cellExtent;
		[SerializeField]
		private int _areaMargin;
		[SerializeField]
		private int _cullingMargin;
		private Runtime _runtime;
	
		// Nested types
		private sealed class DirtyQueue
		{
			// Fields
			public Cell[] _items;
			public int _tailFromHead;
			public int _tailFromBack;
	
			// Constructors
			public DirtyQueue(int size);
	
			// Methods
			public override string ToString();
			public void Reset();
			public void Remove(int index);
			public void AddFromHead(Cell item);
			public void AddFromBack(Cell item);
		}
	
		[Serializable]
		private sealed class Cell
		{
			// Fields
			[SerializeField]
			public Renderer[] _renderers;
			private Runtime _runtime;
	
			// Properties
			public int dirtyQueueIndex { get; }
	
			// Nested types
			private struct Runtime
			{
				// Fields
				public bool _dirty;
				public bool _isCulled;
				public int _dirtyQueueIndex;
	
				// Methods
				public static Runtime Default();
			}
	
			// Constructors
			public Cell(Renderer[] renderers);
	
			// Methods
			public void SetDirtyQueueIndex(int i);
			public void ResetRuntime();
			public void SetCullingState(bool culled);
			public void ApplyCullingStateIfDirty();
			public void DebugSetVisibility(bool visible);
		}
	
		private class Runtime
		{
			// Fields
			public bool existsAnyDirtyCell;
			public int cellIndex;
			private DirtyQueue _dirtyQueue;
			public HashSet<int>[] updateQue;
			private int _currentBufferIndex;
	
			// Properties
			public DirtyQueue dirtyQueue { get; }
			public HashSet<int> curVisibleCellIndices { get; }
			public HashSet<int> nextVisibleCellIndices { get; }
	
			// Constructors
			public Runtime();
	
			// Methods
			public void Initialize(int cullMargin, int totalCellNum);
			public void AddNextVisibleCellIndex(int index);
			public void SwapVisibleCellIndicesBuffer();
		}
	
		// Constructors
		public MapCullingConcern();
		static MapCullingConcern();
	
		// Methods
		[Conditional]
		private static void DebugLog(string log);
		private void Awake();
		private void RuntimeInitialize();
		private void LateUpdate();
		private void UpdateCulling(Vector3 cullingCenter);
		private void ApplyDirtyCells();
		private Cell GetCell(float xPos, float zPos);
		private Cell GetCell(int xIndex, int zIndex);
		private void CalculateCellIndexXZ(out int xIndex, out int zIndex, int index);
		private void CalculateCellIndexXZ(out int xIndex, out int zIndex, float xPos, float zPos);
		private int CalculateCellIndex(int xIndex, int zIndex);
		private int CalculateCellIndex(float xPos, float zPos);
		public void SetEnable(bool enable);
		public void MakeCullingData();
		private static void CollectRenderers(List<Renderer> rendererList, GameObject mapRootNode, string collectRootPath);
		private void ClearCullingData();
		private bool SetupArea(Bounds bounds);
		private void SetupCells(List<Renderer> rendererList);
		private static bool CalculateMinMax(out int min, out int max, float boundsMin, float boundsMax, float margin, int cellSize);
		private static int ToBigAbsInt(float x);
		private static int ToSmallAbsInt(float x);
		public void CalculateFlustomVertex(Vector3 pos, Vector3 at, Vector3 up, float fov, float farClip, float nearClip, float aspect, int splitX, int splitY, int splitZ);
		private bool CheckCollideFrustumMap(Bounds flustomBB, Bounds mapBB);
	}
}
