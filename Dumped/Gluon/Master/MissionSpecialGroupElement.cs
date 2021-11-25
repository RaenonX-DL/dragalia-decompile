using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionSpecialGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public string Text => null;

		public int SortId => default(int);
	}
}
