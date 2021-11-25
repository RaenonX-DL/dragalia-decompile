using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class UnitStoryGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Type;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _HiraganaPrinted;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		public int Id => default(int);

		public int Type => default(int);

		public string Name => null;

		public string HiraganaPrinted => null;

		public int BaseId => default(int);

		public int VariationId => default(int);
	}
}
