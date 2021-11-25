using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestSummaryElement : IMasterElement
	{
		[SerializeField]
		private Gluon.QuestClearType _QuestClearType;

		[SerializeField]
		private Gluon.QuestFailedType _QuestFailedType;

		[SerializeField]
		private string _ShowStartMessage;

		public Gluon.QuestClearType QuestClearType => default(Gluon.QuestClearType);

		public Gluon.QuestFailedType QuestFailedType => default(Gluon.QuestFailedType);

		public string ShowStartMessage => null;
	}
}
