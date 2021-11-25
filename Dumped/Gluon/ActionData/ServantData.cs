using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ServantData : ActionParts.PartsData
	{
		public enum PopStyle
		{
			Offset,
			Around
		}

		public enum BasePoint
		{
			Owner,
			Target
		}

		public static readonly int popNumMax;

		[SerializeField]
		[HideInInspector]
		private int _popNum;

		[SerializeField]
		[HideInInspector]
		private PopStyle _popStyle;

		[SerializeField]
		[HideInInspector]
		private BasePoint _basePoint;

		[SerializeField]
		[HideInInspector]
		private float[] _angle;

		[SerializeField]
		[HideInInspector]
		private float[] _radius;

		[SerializeField]
		[HideInInspector]
		private Vector3[] _offset;

		public int popNum => default(int);

		public PopStyle popStyle => default(PopStyle);

		public BasePoint basePoint => default(BasePoint);

		public float[] angle => null;

		public float[] radius => null;

		public Vector3[] offset => null;
	}
}
