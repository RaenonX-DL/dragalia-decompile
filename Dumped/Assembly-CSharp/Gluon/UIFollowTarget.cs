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
	public class UIFollowTarget : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _positionOffset_k__BackingField;
		private RectTransform rectTransform;
		private FortScene fortScene;
		[CompilerGenerated]
		private Transform _target_k__BackingField;
		private Camera mainCamera;
		[Header]
		[SerializeField]
		public Vector2 gaugeScaleRange;
		public bool needChangeScale;
	
		// Properties
		public Vector3 positionOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform target { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public UIFollowTarget();
	
		// Methods
		public void OnInit(FortScene scene, Transform transTarget = null);
		public void OnInit(FortScene scene, Vector3 offset, Transform transTarget = null);
		protected void LateUpdate();
		public void UpdatePosition();
	}
}
