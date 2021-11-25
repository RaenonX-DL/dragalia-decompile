using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ActiveCancelData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _actionId;

		[SerializeField]
		[HideInInspector]
		protected Gluon.ActionPartsActiveCancel.ActionType _actionType;

		[SerializeField]
		[HideInInspector]
		protected bool _motionEnd;

		[SerializeField]
		[HideInInspector]
		protected bool _needsUpdateOnce;

		public int actionId => default(int);

		public Gluon.ActionPartsActiveCancel.ActionType actionType => default(Gluon.ActionPartsActiveCancel.ActionType);

		public bool motionEnd => default(bool);

		public bool needsUpdateOnce => default(bool);
	}
}
