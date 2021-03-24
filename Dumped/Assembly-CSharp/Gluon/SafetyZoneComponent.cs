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
	public class SafetyZoneComponent : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private int _invalidActionId;
		[SerializeField]
		[Tooltip]
		private int[] _invalidActionIdArray;
		[SerializeField]
		[Tooltip]
		private Shape _shape;
		[SerializeField]
		[Tooltip]
		private float _length;
		[SerializeField]
		[Tooltip]
		private float _width;
		[SerializeField]
		[Tooltip]
		private float _height;
		[SerializeField]
		[Tooltip]
		private bool _isCheckHitCollisionForward;
	
		// Properties
		public int invalidActionId { get; }
		public int[] invalidActionIdList { get; }
		public Shape shape { get; }
		public float length { get; }
		public float width { get; }
		public float height { get; }
		public bool isCheckHitByCollisionForward { get; }
	
		// Nested types
		public enum Shape
		{
			None = 0,
			Sphere = 1,
			Cube = 2
		}
	
		// Constructors
		public SafetyZoneComponent();
	}
}
