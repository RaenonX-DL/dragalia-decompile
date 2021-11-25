using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EmblemDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _Ruby;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private int _EmblemType;

		[SerializeField]
		private int _Sortid;

		[SerializeField]
		private string _Gettext;

		[SerializeField]
		private GiftType _DuplicateEntityType;

		[SerializeField]
		private int _DuplicateEntityId;

		[SerializeField]
		private int _DuplicateEntityQuantity;

		public int Id => default(int);

		public string Title => null;

		public string Ruby => null;

		public int Rarity => default(int);

		public int EmblemType => default(int);

		public int Sortid => default(int);

		public string Gettext => null;

		public GiftType DuplicateEntityType => default(GiftType);

		public int DuplicateEntityId => default(int);

		public int DuplicateEntityQuantity => default(int);
	}
}
