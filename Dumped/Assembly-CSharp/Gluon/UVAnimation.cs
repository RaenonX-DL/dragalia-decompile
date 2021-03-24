/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UVAnimation : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Rect rect;
		[Header]
		[SerializeField]
		private Vector2 marginSize;
		[Header]
		[SerializeField]
		private int imageCount;
		[Header]
		[SerializeField]
		private bool modifyTextureTiling;
		[Header]
		[SerializeField]
		private float speed;
		private float speedInverse;
		[Header]
		[SerializeField]
		private FrameWaitInfo[] frameWaitInfoArray;
		[Header]
		[SerializeField]
		private LoopInfo loopInfo;
		[Header]
		[SerializeField]
		private float delay;
		[Header]
		[SerializeField]
		private float delayRandom;
		private float totalDelay;
		[Header]
		[SerializeField]
		private InterruptionInfo[] interruptionInfo;
		[SerializeField]
		[Tooltip]
		private Material _sharedMaterial;
		[SerializeField]
		private bool isCreateAddtionalMeshForUV;
		private MeshRenderer orgMeshRenderer;
		private MeshFilter orgMeshFilter;
		private Mesh orgMesh;
		private Vector2[] addtionalUVs;
		private Mesh addtionalUvStream;
		private float duration;
		private float timeCount;
		private float delayTime;
		private Material _material;
		private int textureWidth;
		private int textureHeight;
		private int frame;
		private Vector2 mainTextureScale;
		private int remainingLoopNum;
		private float loopStartFrameX;
		private float loopStartFrameY;
		private float lastRowHeight;
		private bool hasAlphaTex;
	
		// Nested types
		[Serializable]
		public struct FrameWaitInfo
		{
			// Fields
			public int frame;
			public float waitTime;
		}
	
		[Serializable]
		public struct LoopInfo
		{
			// Fields
			public bool loop;
			public int startFrame;
			public int endFrame;
			public int loopNum;
		}
	
		[Serializable]
		public struct InterruptionInfo
		{
			// Fields
			[Header]
			[SerializeField]
			public int interruptionFrame;
			[Header]
			[SerializeField]
			public float delay;
			[Header]
			[SerializeField]
			public float delayRandom;
			[NonSerialized]
			public float totalDelay;
		}
	
		// Constructors
		public UVAnimation();
	
		// Methods
		private void Start();
		private void Update();
		private void Scroll();
	}
}
