using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MinimapBVH
	{
		private class BVHNode
		{
			public bool isBranch;

			public Rect rect;

			public int[] child;

			public MiniMapParam param;
		}

		private List<BVHNode> _nodes;

		public void Clear()
		{
		}

		public Rect TopNodeRect()
		{
			return default(Rect);
		}

		private int AddNode()
		{
			return default(int);
		}

		private int AddNode(MiniMapParam param)
		{
			return default(int);
		}

		public MiniMapParam Inside(Vector2 pos)
		{
			return null;
		}

		public void Build(MiniMapParam[] list)
		{
		}

		private void Internal(MiniMapParam[] list, int nodeId)
		{
		}

		private MiniMapParam Inside(int nodeIdx, Vector2 pos)
		{
			return null;
		}

		public void Overlaps(Rect rect, ref List<MiniMapParam> viewMiniMap)
		{
		}

		private MiniMapParam Overlaps(BVHNode root, Rect rect, ref List<MiniMapParam> result)
		{
			return null;
		}
	}
}
