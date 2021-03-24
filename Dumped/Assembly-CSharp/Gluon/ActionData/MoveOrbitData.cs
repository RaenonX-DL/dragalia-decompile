/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveOrbitData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private OrbitType _type;
		[HideInInspector]
		[SerializeField]
		private Vector3 _anchorPosition;
		[HideInInspector]
		[SerializeField]
		private float _rotateSpeed;
		[HideInInspector]
		[SerializeField]
		private float _winchSpeed;
	
		// Properties
		public OrbitType type { get; }
		public Vector3 anchorPosition { get; }
		public float rotateSpeed { get; }
		public float winchSpeed { get; }
	
		// Nested types
		public enum OrbitType
		{
			Anchor = 0,
			Target = 1
		}
	
		// Constructors
		public MoveOrbitData();
	}
}
