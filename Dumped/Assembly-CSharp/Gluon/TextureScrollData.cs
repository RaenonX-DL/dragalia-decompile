/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class TextureScrollData
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private string _texturePropertyName;
		private string _texturePropertyName_ST;
		private int _texturePropertyID;
		private int _texturePropertyID_ST;
		[SerializeField]
		[Tooltip]
		private string _alphaTexturePropertyName;
		private string _alphaTexturePropertyName_ST;
		private int _alphaTexturePropertyID_ST;
		[SerializeField]
		[Tooltip]
		private bool _animationCurveMode;
		[SerializeField]
		[Tooltip]
		private Vector2 _Speed;
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
		private AnimationCurve _animationCurveU;
		[SerializeField]
		[Tooltip]
		private AnimationCurve _animationCurveV;
		private Vector4 _Texture_ST;
		private int _oldFrame;
		private float _intervalTime;
		private int _randomOffsetFrame;
	
		// Properties
		public string AlphaTexturePropertyName { get; }
		public Vector2 speed { get; set; }
	
		// Constructors
		public TextureScrollData();
	
		// Methods
		public void Start();
		public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock, Vector2 scale);
	}
}
