using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ReactiveLightningData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private string _subEnemyGroupName;

		[SerializeField]
		[HideInInspector]
		private int _subActionId;

		public string attachNodeName => null;

		public Vector3 offset => default(Vector3);

		public float radius => default(float);

		public string subEnemyGroupName => null;

		public int subActionId => default(int);
	}
}
