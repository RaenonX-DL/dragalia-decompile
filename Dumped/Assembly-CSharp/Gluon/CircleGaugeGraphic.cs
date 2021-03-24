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
	public class CircleGaugeGraphic : Graphic
	{
		// Fields
		public int numOfTriangle;
		public int radius;
		[Range]
		public float gaugeValue;
		public string materialPath;
		private Texture texture;
		private List<UIVertex> verts;
		private List<int> indicies;
		private Material gaugeMaterial;
		private Texture gaugeTexture;
	
		// Properties
		public override Texture mainTexture { get; }
	
		// Constructors
		public CircleGaugeGraphic();
	
		// Methods
		protected override void Awake();
		public void SetGaugeRange(float range);
		public void ResetVerts();
		protected override void OnPopulateMesh(VertexHelper vh);
	}
}
