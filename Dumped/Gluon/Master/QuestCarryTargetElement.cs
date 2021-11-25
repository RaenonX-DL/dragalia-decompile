using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestCarryTargetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TargetGroupId;

		[SerializeField]
		private int _TargetQuestId;

		public int Id => default(int);

		public int TargetGroupId => default(int);

		public int TargetQuestId => default(int);
	}
}
