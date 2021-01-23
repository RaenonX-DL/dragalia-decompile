/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlUguiGraphic : MaskableGraphic
	{
		// Fields
		public UIVertex[] vertices;
		private List<UIVertex> verts;
		private List<int> indicies;
		private Vector2 position;
		private Texture texture;
	
		// Properties
		public override Texture mainTexture { get; }
	
		// Constructors
		public FlUguiGraphic();
	
		// Methods
		protected override void Awake();
		public void Initialize();
		protected override void OnPopulateMesh(VertexHelper vh);
		public void SetVertexPosition(Vector3[] posVec);
		public void SetUV(float u, float v, float w, float h, bool rotated);
		public void SetColorOffset(Vector2[] colorOffsetList0, Vector2[] colorOffsetList1);
		public void SetColor(Color[] color);
		public void SetMaterial(Material mat, Texture mainTex, Texture alphaTex);
		public void Refresh();
	}
}
