/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityPerspectiveController : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private PerspectiveTraceUnit topUnit;
		[SerializeField]
		private PerspectiveTraceUnit bottomUnit;
		[SerializeField]
		private float lookAtAngleEasingParam;
		private MeshFilter myMeshfilter;
		private Mesh myMesh;
		private Vector3 moveMaxVec;
		private Vector3 basicEuler;
		private Transform myTrans;
		private Transform cameraTrans;
		private Vector3[] morphingVertices;
		private Mesh morphingMesh;
		private int topCenterIndex;
	
		// Nested types
		private enum moveIndexType
		{
			Left = 0,
			Right = 1,
			Center = 2
		}
	
		[Serializable]
		public struct PerspectiveTraceUnit
		{
			// Fields
			public int baseIndex;
			public int[] moveIndices;
		}
	
		// Constructors
		public FacilityPerspectiveController();
	
		// Methods
		private void Start();
		public override void FastUpdate();
	}
}
