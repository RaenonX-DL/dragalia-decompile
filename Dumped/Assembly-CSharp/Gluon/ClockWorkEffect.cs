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
	public class ClockWorkEffect : BaseMeshEffect
	{
		// Fields
		private Color32 effectColor;
		private float effectValue;
		private static Vector2[] initVertex;
		private bool init;
		private bool updateColor;
		private bool failure;
		private List<UIVertex> vList;
		private List<UIVertex> setList;
		private UIVertex verts;
		private UIVertex vertexZero;
		private const int numTriangle = 8;
		private const int numVertex = 3;
		private float minX;
		private float minY;
		private float minU;
		private float minV;
		private float width;
		private float height;
		private float widthU;
		private float heightV;
	
		// Properties
		public Color32 EffectColor { get; set; }
		public float EffectValue { get; set; }
	
		// Constructors
		public ClockWorkEffect();
		static ClockWorkEffect();
	
		// Methods
		public override void ModifyMesh(VertexHelper vh);
		private void Refresh();
		private void SetEffectColor(Color32 col);
		private void SetEffectValue(float v);
	}
}
