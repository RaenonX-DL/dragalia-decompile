/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LongTapTrail : Graphic
	{
		// Fields
		public static float widthHalf;
		public static float heightHalf;
		public static int rectNum;
		public static int divideNum;
		public static float adjustRate;
		private bool isShown;
		private int count;
		private float angle;
		private Texture texture;
		public MeshRect[] meshRects;
		private List<UIVertex> verts;
		private List<int> indicies;
	
		// Properties
		public override Texture mainTexture { get; }
	
		// Nested types
		public class MeshRect
		{
			// Fields
			public float x;
			public float y;
			public UIVertex[] vertices;
	
			// Constructors
			public MeshRect();
	
			// Methods
			public void SetPosition(float x, float y, float angle, int index);
			public void SetUV(int index);
			public void Reset();
		}
	
		// Constructors
		public LongTapTrail();
		static LongTapTrail();
	
		// Methods
		protected override void Awake();
		protected override void OnPopulateMesh(VertexHelper vh);
		public void Show(float x, float y);
		public void Hide();
	}
}
