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
	public class UVMoviePlayer : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Renderer _renderer;
		[SerializeField]
		[Tooltip]
		private UVMovieController _uvMovieController;
		[SerializeField]
		[Tooltip]
		private float _playOffsetTime;
		[SerializeField]
		[Tooltip]
		private bool _isStartPlay;
		[SerializeField]
		[Tooltip]
		private string _texturePropertyName;
		private int _texturePropertyID;
		private int _textureSTPropertyID;
		private MaterialPropertyBlock _materialPropertyBlock;
		private float _startTime;
	
		// Constructors
		public UVMoviePlayer();
	
		// Methods
		private float GetNowTime();
		private void Awake();
		private void Start();
		private void LateUpdate();
	}
}
