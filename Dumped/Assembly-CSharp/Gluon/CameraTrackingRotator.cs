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
	public class CameraTrackingRotator : FastUpdateMonoBehaviour
	{
		// Fields
		private Camera _targetCamera;
		private Transform _targetTransformCache;
		[SerializeField]
		protected Vector3 cameraEularRatation;
	
		// Properties
		public Camera targetCamera { get; set; }
		public Transform targetTransformCache { get; }
	
		// Constructors
		public CameraTrackingRotator();
	
		// Methods
		private void Start();
	}
}
