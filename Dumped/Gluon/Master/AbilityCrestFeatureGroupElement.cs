using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestFeatureGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _GroupText;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public string GroupText => null;

		public int SortId => default(int);
	}
}
