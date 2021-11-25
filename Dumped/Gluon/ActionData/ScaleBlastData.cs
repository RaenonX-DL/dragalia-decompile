using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ScaleBlastData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsScaleBlast.ChildParam _blackChildParam;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsScaleBlast.ChildParam _whiteChildParam;

		[SerializeField]
		[HideInInspector]
		private int _blackActionId;

		[SerializeField]
		[HideInInspector]
		private int _whiteActionId;

		[SerializeField]
		[HideInInspector]
		private int _defeatedActionId;

		[SerializeField]
		[HideInInspector]
		private int[] _blastActionId;

		[SerializeField]
		[HideInInspector]
		private float _idleTime;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		public Gluon.ActionPartsScaleBlast.ChildParam blackChildParam => default(Gluon.ActionPartsScaleBlast.ChildParam);

		public Gluon.ActionPartsScaleBlast.ChildParam whiteChildParam => default(Gluon.ActionPartsScaleBlast.ChildParam);

		public int blackActionId => default(int);

		public int whiteActionId => default(int);

		public int defeatedActionId => default(int);

		public int[] blastActionId => null;

		public float idleTime => default(float);

		public float waitTime => default(float);
	}
}
