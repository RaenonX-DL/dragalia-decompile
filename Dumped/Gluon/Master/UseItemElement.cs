using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class UseItemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private UseItemEffect _ItemEffect;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _ItemEffectValue;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public UseItemEffect ItemEffect => default(UseItemEffect);

		public int SortId => default(int);

		public int ItemEffectValue => default(int);
	}
}
