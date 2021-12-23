using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeAreaGimmickDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Difficulty;

		[SerializeField]
		private string _GimmickName;

		[SerializeField]
		private string _GimmickLabel;

		public int Id => default(int);

		public int Difficulty => default(int);

		public string GimmickName => null;

		public string GimmickLabel => null;
	}
}
