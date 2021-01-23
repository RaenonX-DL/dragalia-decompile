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
	public class CacheTransform : MonoBehaviour
	{
		// Fields
		private Transform _cacheTransform;
		private Vector3 _nowWorldPosition;
		private Vector3 _beforeWorldPosition;
		private Vector3 _moveDirection;
		private float _moveLength;
	
		// Properties
		public Transform chacheTransform { get; }
		public Vector3 nowWorldPosition { get; }
		public Vector3 beforeWorldPosition { get; }
		public Vector3 moveDirection { get; }
		public float moveLength { get; }
	
		// Constructors
		public CacheTransform();
	
		// Methods
		private void Awake();
		private void Start();
		private void Update();
	}
}
