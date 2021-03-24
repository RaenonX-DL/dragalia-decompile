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
	[AddComponentMenu]
	[RequireComponent]
	public class EnemyCylinderCollider : FastUpdateMonoBehaviour
	{
		// Fields
		private MeshCollider _meshCollider;
		private const int CYLINDER_ANGLE = 360;
		private const int VERTICES_NUM = 12;
		[SerializeField]
		private float _radius;
		[SerializeField]
		private float _height;
		[SerializeField]
		private Vector3 _offset;
		[SerializeField]
		private float _pushPowerRate;
		[Header]
		[SerializeField]
		private bool _floorAlignment;
		[Header]
		[SerializeField]
		private bool _lieDown;
		private float _oldRadius;
		private float _oldHeight;
		private Vector3 _oldOffset;
		private Vector2 meshColliderCenterPositionXZ;
		private Vector2 charaColliderCenterPositionXZ;
	
		// Properties
		public float radius { get; }
		public float height { get; }
		protected MeshCollider meshCollider { get; }
	
		// Constructors
		public EnemyCylinderCollider();
	
		// Methods
		private void Awake();
		public void CreateCylinderCollider(float radius, float height, int fanAngle, Vector3 offset, int numVertices = 32);
		private Mesh CreateMesh(float radius, float height, Vector3 offSet, int angle, int numVertices);
		private void LateUpdate();
	}
}
