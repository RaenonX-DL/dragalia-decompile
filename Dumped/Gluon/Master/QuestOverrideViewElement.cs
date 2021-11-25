using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestOverrideViewElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _HeaderIconType;

		[SerializeField]
		private string _ClearText;

		[SerializeField]
		private string _FailureText;

		[SerializeField]
		private string _ClearSummaryText;

		[SerializeField]
		private string _QuestMission21Text;

		[SerializeField]
		private string _QuestMission25Text;

		[SerializeField]
		private string _QuestMission34Text;

		public int Id => default(int);

		public int HeaderIconType => default(int);

		public string ClearText => null;

		public string FailureText => null;

		public string ClearSummaryText => null;

		public string QuestMission21Text => null;

		public string QuestMission25Text => null;

		public string QuestMission34Text => null;
	}
}
