using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CallMinionData : ActionParts.PartsData
	{
		public enum PopStyle
		{
			Offset,
			Around
		}

		public enum BaseType
		{
			Generator,
			Owner,
			WorldCenter,
			Target,
			AreaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private string _generatorLabel;

		[SerializeField]
		[HideInInspector]
		private PopStyle _popStyle;

		[SerializeField]
		[HideInInspector]
		private BaseType _baseType;

		[SerializeField]
		[HideInInspector]
		private float _angle;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[SerializeField]
		[HideInInspector]
		public bool _isMinionDirEdit;

		[SerializeField]
		[HideInInspector]
		private float _minionForward;

		[SerializeField]
		[HideInInspector]
		private float _minionAreaRadius;

		[SerializeField]
		[HideInInspector]
		private bool _isHostSync;

		public string generatorLabel => null;

		public PopStyle popStyle => default(PopStyle);

		public BaseType baseType => default(BaseType);

		public float angle => default(float);

		public float radius => default(float);

		public Vector3 offset => default(Vector3);

		public bool isMinionDirEdit => default(bool);

		public float minionForward => default(float);

		public float minionAreaRadius => default(float);

		public bool IsHostSync => default(bool);
	}
}
