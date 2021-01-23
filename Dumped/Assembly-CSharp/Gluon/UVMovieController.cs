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
	public class UVMovieController : MonoBehaviour
	{
		// Fields
		private Texture2D _mainTexture;
		private Vector2 _mainTextureOffset;
		private Vector2 _mainTextureScale;
		[SerializeField]
		private UVMovieData _UVMovieData;
		private bool _isInitlize;
		private Vector2 _frameOffset;
		private Vector2 _frameScale;
		private Vector2 _texturePixelOffset;
		private Vector2 _texturePixelScale;
		private float _moviePlayFrameSec;
		private float _playTime;
		private float _endLoopSec;
		private float _totalLoopSec;
		private float _playStartSec;
		private int _fremePerImage;
	
		// Properties
		public Texture2D mainTexture { get; protected set; }
		public Vector2 mainTextureOffset { get; protected set; }
		public Vector2 mainTextureScale { get; protected set; }
	
		// Constructors
		public UVMovieController();
	
		// Methods
		private void Awake();
		private void Start();
		private void Initialize();
		public bool IsPlaying(float time);
		private void CalcProperty(float settime, bool isReversePlay);
		public void UpdateAddTime(float addtime, bool isReversePlay);
		public void UpdateSetTime(float settime, bool isReversePlay);
		public void SetPlayStartSec(int startOffsetFrame);
	}
}
