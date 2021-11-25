using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class FacilityPerspectiveController : FastUpdateMonoBehaviour
	{
		private enum moveIndexType
		{
			Left,
			Right,
			Center
		}

		[Serializable]
		public struct PerspectiveTraceUnit
		{
			public int baseIndex;

			public int[] moveIndices;
		}

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

		private void Start()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
