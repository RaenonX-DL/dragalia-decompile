/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.DesignerTools.CameraDataCreator
{
	[Serializable]
	public class CameraDataInfo
	{
		// Fields
		[SerializeField]
		private float _time;
		[SerializeField]
		private Vector3 _position;
		[SerializeField]
		private Vector3 _rotation;
		[SerializeField]
		private Vector3 _targetPosition;
		[SerializeField]
		private Vector3 _upPosition;
		[SerializeField]
		private float _fovValue;
	
		// Properties
		public float Time { get; set; }
		public Vector3 Position { get; set; }
		public Vector3 Rotation { get; set; }
		public Vector3 TargetPosition { get; set; }
		public Vector3 UpPosition { get; set; }
		public float FovValue { get; set; }
	
		// Constructors
		public CameraDataInfo();
	}
}
