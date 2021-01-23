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
	public class BaseCanvasParticle : Graphic
	{
		// Fields
		private int emissionCount;
		public static int particleNum;
		public static int emissionIntervalMyPage;
		public static int emissionIntervalCommon;
		public static int initialNumberMyPage;
		public static int initialNumberCommon;
		public static float rangeX;
		public static float offsetX;
		public static float rangeY;
		public static float offsetY;
		public static Color particleColorMyPage;
		public static Color particleColorCommon;
		public static float alphaMyPage;
		public static float alphaCommon;
		public static int lifeRange;
		public static int lifeBase;
		public static float radiusRangeMyPage;
		public static float radiusRangeCommon;
		public static float radiusBaseMyPage;
		public static float radiusBaseCommon;
		public static float moveSpeedRangeX;
		public static float moveSpeedBaseX;
		public static float moveSpeedRangeY;
		public static float moveSpeedBaseY;
		public static float fadeSpeed;
		private Material normalParticleMaterial;
		private Material mypageParticleMaterial;
		private Texture normalParticleTexture;
		private Texture mypageParticleTexture;
		private Texture texture;
		private List<UIVertex> verts;
		private List<int> indicies;
		private MeshRect[] meshRects;
		private List<int> indexPoolList;
		private BaseCanvasParticleSettings settings;
		[SerializeField]
		private bool isForMyPageOverlay;
		private bool is2dMyPageScene;
	
		// Properties
		public override Texture mainTexture { get; }
	
		// Nested types
		private class MeshRect
		{
			// Fields
			public float x;
			public float y;
			public float alpha;
			public float alphaMax;
			public float directionX;
			public float directionY;
			public float radius;
			public int life;
			public Color baseColor;
			public bool isBorn;
			public bool isDead;
			public UIVertex[] vertices;
	
			// Constructors
			public MeshRect();
	
			// Methods
			public void Reset();
			public void Init(float alphaMax, float radius, Color baseColor);
			public void Update();
		}
	
		// Constructors
		public BaseCanvasParticle();
	
		// Methods
		protected override void Awake();
		public void ResetPageStatus();
		private void InitMeshRect(int index);
		private void Update();
		protected override void OnPopulateMesh(VertexHelper vh);
	}
}
