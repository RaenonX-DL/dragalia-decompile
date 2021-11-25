using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class IceRayData : ActionParts.PartsData
	{
		public enum GeneratePos
		{
			Owner,
			OwnerNode
		}

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetRotation;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[SerializeField]
		[HideInInspector]
		private float _rayLength;

		[SerializeField]
		[HideInInspector]
		private int _subActionID;

		[SerializeField]
		[HideInInspector]
		private string _subEnemyGroupName;

		[SerializeField]
		[HideInInspector]
		private bool _isRotationYaw;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private GeneratePos _generatePos;

		public Vector3 offsetRotation => default(Vector3);

		public Vector3 offset => default(Vector3);

		public float rayLength => default(float);

		public int subActionID => default(int);

		public string subEnemyGroupName => null;

		public bool isRotationYaw => default(bool);

		public string attachNodeName => null;

		public GeneratePos generatePos => default(GeneratePos);
	}
}
