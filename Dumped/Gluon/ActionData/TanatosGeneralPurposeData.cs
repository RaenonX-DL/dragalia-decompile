using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosGeneralPurposeData : ActionParts.PartsData
	{
		public enum Type
		{
			EnemyDeadRecoverCountInit,
			DeathCountRecover,
			CountUIOn,
			DefaultDeathCount
		}

		[SerializeField]
		[HideInInspector]
		private Type _type;

		[SerializeField]
		[HideInInspector]
		private int[] _countRecoverParam;

		[SerializeField]
		[HideInInspector]
		private int[] _countRecoverParam2;

		public Type type => default(Type);

		public int[] countRecoverParam => null;

		public int[] countRecoverParam2 => null;
	}
}
