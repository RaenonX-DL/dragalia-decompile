using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class AppearWeakData : AppearEnemyData
	{
		[SerializeField]
		[HideInInspector]
		private int _whenDeadCenterCharaActionId;

		public int whenDeadCenterCharaActionId => default(int);
	}
}
