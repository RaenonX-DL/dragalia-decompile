/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MaterialPropertyScroll : MaterialControlComponent
	{
		// Fields
		[SerializeField]
		private ScrollData[] _scrollData;
	
		// Properties
		public ScrollData[] scrollData { get; }
	
		// Nested types
		[Serializable]
		public class ScrollData
		{
			// Fields
			[SerializeField]
			[Tooltip]
			private string _texturePropertyName;
			private int _texturePropertyID;
			[SerializeField]
			[Tooltip]
			private bool _animationCurveMode;
			[SerializeField]
			[Tooltip]
			private float _Speed;
			[Range]
			[SerializeField]
			[Tooltip]
			private int _IntervalFrame;
			[SerializeField]
			[Tooltip]
			private int _randomOffsetMaxFrame;
			[SerializeField]
			[Tooltip]
			private float _animationTotalTime;
			[SerializeField]
			[Tooltip]
			private float _animationStartOffsetTime;
			[SerializeField]
			[Tooltip]
			private AnimationCurve _animationCurve;
			private int _oldFrame;
			private float _intervalTime;
			private int _randomOffsetFrame;
	
			// Properties
			public float speed { get; set; }
	
			// Constructors
			public ScrollData();
	
			// Methods
			public void Start();
			public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock);
		}
	
		// Constructors
		public MaterialPropertyScroll();
	
		// Methods
		protected override void Awake();
		protected void Reset();
		private void Update();
		public void Play();
		public void Stop();
	}
}
