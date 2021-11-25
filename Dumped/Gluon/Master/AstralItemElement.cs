using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AstralItemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Detail;

		[SerializeField]
		private DetailLinkType _DetailLinkType;

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
		private string _Description;

		[SerializeField]
		private int _PouchRarity;

		public int Id => default(int);

		public string Name => null;

		public string Detail => null;

		public DetailLinkType DetailLinkType => default(DetailLinkType);

		public int MoveQuest1 => default(int);

		public int MoveQuest2 => default(int);

		public int MoveQuest3 => default(int);

		public int MoveQuest4 => default(int);

		public int MoveQuest5 => default(int);

		public string Description => null;

		public int PouchRarity => default(int);
	}
}
