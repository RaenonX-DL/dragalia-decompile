using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ExchangeTicketElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public int SortId => default(int);
	}
}
