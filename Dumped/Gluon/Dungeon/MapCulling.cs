using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Gluon.Dungeon
{
	public sealed class MapCulling : MonoBehaviour
	{
		private sealed class DirtyQueue
		{
			public Cell[] _items;

			public int _tailFromHead;

			public int _tailFromBack;

			public override string ToString()
			{
				return null;
			}

			public DirtyQueue(int size)
			{
			}

			public void Reset()
			{
			}

			public void Remove(int index)
			{
			}

			public void AddFromHead(Cell item)
			{
			}

			public void AddFromBack(Cell item)
			{
			}
		}

		[Serializable]
		private sealed class Cell
		{
			private struct Runtime
			{
				public bool _dirty;

				public bool _isCulled;

				public int _dirtyQueueIndex;

				public static Runtime Default()
				{
					return default(Runtime);
				}
			}

			[SerializeField]
			private Renderer[] _renderers;

			private Runtime _runtime;

			public int dirtyQueueIndex => default(int);

			public void SetDirtyQueueIndex(int i)
			{
			}

			public void ResetRuntime()
			{
			}

			public Cell(Renderer[] renderers)
			{
			}

			public void SetCullingState(bool culled)
			{
			}

			public void ApplyCullingStateIfDirty()
			{
			}

			public void DebugSetVisibility(bool visible)
			{
			}
		}

		private class Runtime
		{
			public bool existsAnyDirtyCell;

			public int cellIndex;

			private DirtyQueue _dirtyQueue;

			private int[][] _visibleCellIndices;

			private int[] _visibleCellNum;

			private int _currentBufferIndex;

			public DirtyQueue dirtyQueue => null;

			public int[] curVisibleCellIndices => null;

			public int[] nextVisibleCellIndices => null;

			public int curVisibleCellNum
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int nextVisibleCellNum
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public void Initialize(int cullMargin, int totalCellNum)
			{
			}

			public void AddNextVisibleCellIndex(int index)
			{
			}

			public void SwapVisibleCellIndicesBuffer()
			{
			}
		}

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

		[Conditional("MAPCULLING_LOG")]
		private static void DebugLog(string log)
		{
		}

		private void Awake()
		{
		}

		private void RuntimeInitialize()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateCulling(Vector3 cullingCenter)
		{
		}

		private void ApplyDirtyCells()
		{
		}

		private Cell GetCell(float xPos, float zPos)
		{
			return null;
		}

		private Cell GetCell(int xIndex, int zIndex)
		{
			return null;
		}

		private void CalculateCellIndexXZ(out int xIndex, out int zIndex, int index)
		{
		}

		private void CalculateCellIndexXZ(out int xIndex, out int zIndex, float xPos, float zPos)
		{
		}

		private int CalculateCellIndex(int xIndex, int zIndex)
		{
			return default(int);
		}

		private int CalculateCellIndex(float xPos, float zPos)
		{
			return default(int);
		}

		public void SetEnable(bool enable)
		{
		}

		public void MakeCullingData()
		{
		}

		private static void CollectRenderers(List<Renderer> rendererList, GameObject mapRootNode, string collectRootPath)
		{
		}

		private void ClearCullingData()
		{
		}

		private bool SetupArea(Bounds bounds)
		{
			return default(bool);
		}

		private void SetupCells(List<Renderer> rendererList)
		{
		}

		private static bool CalculateMinMax(out int min, out int max, float boundsMin, float boundsMax, float margin, int cellSize)
		{
			return default(bool);
		}

		private static int ToBigAbsInt(float x)
		{
			return default(int);
		}

		private static int ToSmallAbsInt(float x)
		{
			return default(int);
		}
	}
}
