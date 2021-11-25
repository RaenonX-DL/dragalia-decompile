using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ChangeMeshOfPartsEnemyData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsChangeMeshOfPartsEnemy.PartsIndex _partsIdx;

		[SerializeField]
		[HideInInspector]
		private string _newMeshName;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsChangeMeshOfPartsEnemy.PartsIndex partsIdx => default(Gluon.ActionPartsChangeMeshOfPartsEnemy.PartsIndex);

		public string newMeshName => null;

		public bool guarantee => default(bool);
	}
}
