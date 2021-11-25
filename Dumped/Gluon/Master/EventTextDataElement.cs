using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventTextDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private string _StaticTextLabel;

		[SerializeField]
		private string _EventText;

		public int Id => default(int);

		public int EventId => default(int);

		public string StaticTextLabel => null;

		public string EventText => null;
	}
}
