using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestWallElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _QuestGroupId;

		[SerializeField]
		private QuestGroupType _GroupType;

		[SerializeField]
		private string _SectionName;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _Class;

		[SerializeField]
		private Gluon.ElementalType _Elemental;

		[SerializeField]
		private int _IsLockView;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private string _ThumbnailImage;

		[SerializeField]
		private string _ArmoryBackImage;

		public int Id => default(int);

		public int QuestGroupId => default(int);

		public QuestGroupType GroupType => default(QuestGroupType);

		public string SectionName => null;

		public string Title => null;

		public string Class => null;

		public Gluon.ElementalType Elemental => default(Gluon.ElementalType);

		public int IsLockView => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public string ThumbnailImage => null;

		public string ArmoryBackImage => null;
	}
}
