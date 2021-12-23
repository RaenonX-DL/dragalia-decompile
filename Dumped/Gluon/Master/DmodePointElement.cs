using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodePointElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _RecordNum;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public int RecordNum => default(int);
	}
}
