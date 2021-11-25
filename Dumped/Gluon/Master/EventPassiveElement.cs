using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventPassiveElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _PassiveNum;

		[SerializeField]
		private EventPassiveType _EventPassiveType;

		[SerializeField]
		private string _EventPassiveNameText;

		[SerializeField]
		private string _EventPassiveDetailText;

		[SerializeField]
		private int _MaxGrowValue;

		[SerializeField]
		private int _UpGrowValue;

		[SerializeField]
		private int _ViewRarity;

		[SerializeField]
		private int _PartyPowerGrowValue;

		[SerializeField]
		private int _IconImage;

		public int Id => default(int);

		public int EventId => default(int);

		public int PassiveNum => default(int);

		public EventPassiveType EventPassiveType => default(EventPassiveType);

		public string EventPassiveNameText => null;

		public string EventPassiveDetailText => null;

		public int MaxGrowValue => default(int);

		public int UpGrowValue => default(int);

		public int ViewRarity => default(int);

		public int PartyPowerGrowValue => default(int);

		public int IconImage => default(int);
	}
}
