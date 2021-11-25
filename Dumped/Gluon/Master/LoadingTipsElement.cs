using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LoadingTipsElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TipsLayoutType;

		[SerializeField]
		private int _TipsType;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _ImageId;

		[SerializeField]
		private QuestType _ReleaseQuestType;

		[SerializeField]
		private int _ReleaseQuestId;

		[SerializeField]
		private int _AssignedTurorialStepId;

		[SerializeField]
		private int _AssignedTipsType;

		[SerializeField]
		private int _AssignedTargetId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int TipsLayoutType => default(int);

		public int TipsType => default(int);

		public string Title => null;

		public string Text => null;

		public int ImageId => default(int);

		public QuestType ReleaseQuestType => default(QuestType);

		public int ReleaseQuestId => default(int);

		public int AssignedTurorialStepId => default(int);

		public int AssignedTipsType => default(int);

		public int AssignedTargetId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
