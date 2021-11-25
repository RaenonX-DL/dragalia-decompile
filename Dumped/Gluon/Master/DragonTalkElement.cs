using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonTalkElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private string _Text;

		public int CharaId => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public string Text => null;
	}
}
