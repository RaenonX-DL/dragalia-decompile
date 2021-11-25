using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class VisibleData : ActionParts.PartsData
	{
		public enum EnemyPartsIndex
		{
			None,
			mPartsA,
			mPartsB,
			mPartsC,
			mPartsD
		}

		[SerializeField]
		[HideInInspector]
		private bool _isVisible;

		[SerializeField]
		[HideInInspector]
		private string _name;

		[SerializeField]
		[HideInInspector]
		private bool _isFullBody;

		[SerializeField]
		[HideInInspector]
		private bool _isActionClear;

		[SerializeField]
		[HideInInspector]
		private bool _isEffUi;

		[SerializeField]
		[HideInInspector]
		private bool _isPartsBreakToSub;

		[SerializeField]
		[HideInInspector]
		private EnemyPartsIndex _partsIdx;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public bool isVisible => default(bool);

		public string name => null;

		public bool isFullBody => default(bool);

		public bool isActionClear => default(bool);

		public bool isEffUi => default(bool);

		public bool isPartsBreakToSub => default(bool);

		public EnemyPartsIndex partsIdx => default(EnemyPartsIndex);

		public bool guarantee => default(bool);
	}
}
