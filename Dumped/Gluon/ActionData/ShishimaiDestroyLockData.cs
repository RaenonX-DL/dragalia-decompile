using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ShishimaiDestroyLockData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _destroyMotion;

		[SerializeField]
		[HideInInspector]
		private int _destroyDuration;

		[SerializeField]
		[HideInInspector]
		private int _openActionId;

		[SerializeField]
		[HideInInspector]
		private int _open2ndActionId;

		public string destroyMotion => null;

		public int destroyDuration => default(int);

		public int openActionId => default(int);

		public int open2ndActionId => default(int);
	}
}
