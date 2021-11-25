using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class AppearEnemyData : ActionParts.PartsData
	{
		public enum ChildType
		{
			Child01Param,
			Child02Param,
			Child03Param
		}

		public enum PopType
		{
			Owner,
			WorldCenter,
			Target,
			AreaAnchor,
			TargetGround
		}

		public enum PopDesign
		{
			Direction,
			Offset
		}

		[SerializeField]
		[HideInInspector]
		private ChildType _childType;

		[SerializeField]
		[HideInInspector]
		private PopType _popType;

		[SerializeField]
		[HideInInspector]
		private PopDesign _popDesign;

		[SerializeField]
		[HideInInspector]
		private float _popAngle;

		[SerializeField]
		[HideInInspector]
		private float _popLength;

		[SerializeField]
		[HideInInspector]
		private Vector3 _popOffsetPos;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private bool _isDirectionEdit;

		[SerializeField]
		[HideInInspector]
		private float _childDirection;

		[SerializeField]
		[HideInInspector]
		private bool _production;

		[SerializeField]
		[HideInInspector]
		private bool _devolution;

		[SerializeField]
		[HideInInspector]
		private bool _isPopedInvincible;

		[SerializeField]
		[HideInInspector]
		private bool _isHostSync;

		[SerializeField]
		[HideInInspector]
		private bool _checkFloor;

		public ChildType childType => default(ChildType);

		public PopType popType => default(PopType);

		public PopDesign popDesign => default(PopDesign);

		public float popAngle => default(float);

		public float popLength => default(float);

		public Vector3 popOffsetPos => default(Vector3);

		public int childActionId => default(int);

		public bool isDirectionEdit => default(bool);

		public float childDirection => default(float);

		public bool production => default(bool);

		public bool devolution => default(bool);

		public bool isPopedInvincible => default(bool);

		public bool IsHostSync => default(bool);

		public bool checkFloor => default(bool);
	}
}
