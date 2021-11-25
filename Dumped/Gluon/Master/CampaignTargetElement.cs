using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CampaignTargetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private QuestGroupType _QuestGroupType;

		[SerializeField]
		private int _QuestGroupId;

		public int Id => default(int);

		public int GroupId => default(int);

		public QuestGroupType QuestGroupType => default(QuestGroupType);

		public int QuestGroupId => default(int);
	}
}
