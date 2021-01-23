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
	[AddComponentMenu]
	public class CameraFollow : MonoBehaviour
	{
		// Fields
		public Transform target;
		[SerializeField]
		private float distance;
		[SerializeField]
		private float minDistance;
		[SerializeField]
		private float maxDistance;
		private float addDistance;
		[SerializeField]
		private float distanceDamping;
		private bool _isZoomControl;
		private float zoomRatio;
		[SerializeField]
		private Vector3 rotate;
		private ShakeCtrl shakeCtrl;
	
		// Properties
		public bool isZoomControl { get; }
	
		// Nested types
		private struct ShakeCtrl
		{
			// Fields
			public bool isActive;
			public float sec;
			public float power;
			public bool isResume;
		}
	
		// Constructors
		public CameraFollow();
	
		// Methods
		private void LateUpdate();
		public void ZoomOutWithDash();
		public void SetShake(float sec = 0.2f, float power = 0.08f, bool resume = false);
		private void UpdateShakeCtrl(Transform target);
		public void AddDistance(float value);
		public float GetDistance();
	}
}
