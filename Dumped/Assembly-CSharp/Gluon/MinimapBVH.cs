/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MinimapBVH
	{
		// Fields
		private List<BVHNode> _nodes;
	
		// Nested types
		private class BVHNode
		{
			// Fields
			public bool isBranch;
			public Rect rect;
			public int[] child;
			public MiniMapParam param;
	
			// Constructors
			public BVHNode();
		}
	
		// Constructors
		public MinimapBVH();
	
		// Methods
		public void Clear();
		public Rect TopNodeRect();
		private int AddNode();
		private int AddNode(MiniMapParam param);
		public MiniMapParam Inside(Vector2 pos);
		public void Build(MiniMapParam[] list);
		private void Internal(MiniMapParam[] list, int nodeId);
		private MiniMapParam Inside(int nodeIdx, Vector2 pos);
		public void Overlaps(Rect rect, ref List<MiniMapParam> viewMiniMap);
		private MiniMapParam Overlaps(BVHNode root, Rect rect, ref List<MiniMapParam> result);
	}
}
