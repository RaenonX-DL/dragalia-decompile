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

namespace Gluon
{
	public class LongTapParticle : Graphic
	{
		// Fields
		public float particleScaleDelta1;
		public float particleScaleDelta2;
		private int particleNum;
		private int particleIndex;
		private float particleAlphaDec;
		private float particleScaleDec;
		private static Vector3 initialPosition;
		private Texture texture;
		private List<UIVertex> verts;
		private List<int> indicies;
		private MeshRect[] meshRects;
	
		// Properties
		public override Texture mainTexture { get; }
	
		// Nested types
		private class MeshRect
		{
			// Fields
			public float x;
			public float y;
			public float alpha;
			public float scale;
			public float scale1Time;
			private float sizeHalf;
			public UIVertex[] vertices;
	
			// Constructors
			public MeshRect();
	
			// Methods
			public void SetPosition(float x, float y, float size);
			public void DecrementAlpha(float delta);
			public void DoScaleAnimation(float timeDec1, float delta1, float delta2);
			private void SetColor(float alpha);
		}
	
		// Constructors
		public LongTapParticle();
		static LongTapParticle();
	
		// Methods
		protected override void Awake();
		protected override void OnPopulateMesh(VertexHelper vh);
		public void AddParticle(float x, float y, float size);
		public void Update();
	}
}
