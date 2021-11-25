using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TerminateOtherData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _startIndex;

		[SerializeField]
		[HideInInspector]
		private int _count;

		[SerializeField]
		[HideInInspector]
		private ConditionData _partConditionData;

		[SerializeField]
		[HideInInspector]
		private bool _toggleSkillNextAction;

		[SerializeField]
		[HideInInspector]
		private bool _skipRunningMotion;

		public int startIndex => default(int);

		public int count => default(int);

		public ConditionData partConditionData => null;

		public bool toggleSkillNextAction => default(bool);

		public bool skipRunningMotion => default(bool);
	}
}
