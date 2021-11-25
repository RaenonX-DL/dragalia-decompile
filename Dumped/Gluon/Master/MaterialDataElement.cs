using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MaterialDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Detail;

		[SerializeField]
		private int _MaterialRarity;

		[SerializeField]
		private int _QuestEventId;

		[SerializeField]
		private MaterialType _Category;

		[SerializeField]
		private int _TargetRarity;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private DetailLinkType _DetailLinkType;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _MoveQuest1;

		[SerializeField]
		private int _MoveQuest2;

		[SerializeField]
		private int _MoveQuest3;

		[SerializeField]
		private int _MoveQuest4;

		[SerializeField]
		private int _MoveQuest5;

		[SerializeField]
		private int _PouchRarity;

		[SerializeField]
		private int _Exp;

		[SerializeField]
		private int _Plus;

		public int Id => default(int);

		public string Name => null;

		public string Detail => null;

		public int MaterialRarity => default(int);

		public int QuestEventId => default(int);

		public MaterialType Category => default(MaterialType);

		public int TargetRarity => default(int);

		public int SortId => default(int);

		public DetailLinkType DetailLinkType => default(DetailLinkType);

		public string Description => null;

		public int MoveQuest1 => default(int);

		public int MoveQuest2 => default(int);

		public int MoveQuest3 => default(int);

		public int MoveQuest4 => default(int);

		public int MoveQuest5 => default(int);

		public int PouchRarity => default(int);

		public int Exp => default(int);

		public int Plus => default(int);
	}
}
