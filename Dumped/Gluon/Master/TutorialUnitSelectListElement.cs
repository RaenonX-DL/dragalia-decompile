using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TutorialUnitSelectListElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _UnitSelelctGroupId;

		[SerializeField]
		private GiftType _SelectEntityType;

		[SerializeField]
		private int _SelectEntityId;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _IsPickup;

		[SerializeField]
		private string _IntroductionText;

		public int Id => default(int);

		public int UnitSelelctGroupId => default(int);

		public GiftType SelectEntityType => default(GiftType);

		public int SelectEntityId => default(int);

		public int SortId => default(int);

		public int IsPickup => default(int);

		public string IntroductionText => null;
	}
}
