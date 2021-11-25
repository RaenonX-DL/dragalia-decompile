using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CombatEventLocationElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _LocationRewardId;

		[SerializeField]
		private string _LocationName;

		[SerializeField]
		private float _LocationPointerX;

		[SerializeField]
		private float _LocationPointerY;

		[SerializeField]
		private int _ReleaseQuestId;

		[SerializeField]
		private int _ClearQuestId;

		[SerializeField]
		private string _TopBannerImage;

		[SerializeField]
		private string _HowToPlayImage;

		[SerializeField]
		private int _HowToPlayCount;

		[SerializeField]
		private int _ShowTriggerEntityId;

		[SerializeField]
		private int _ShowTriggerEntityQuantity;

		public int Id => default(int);

		public int EventId => default(int);

		public int LocationRewardId => default(int);

		public string LocationName => null;

		public float LocationPointerX => default(float);

		public float LocationPointerY => default(float);

		public int ReleaseQuestId => default(int);

		public int ClearQuestId => default(int);

		public string TopBannerImage => null;

		public string HowToPlayImage => null;

		public int HowToPlayCount => default(int);

		public int ShowTriggerEntityId => default(int);

		public int ShowTriggerEntityQuantity => default(int);
	}
}
