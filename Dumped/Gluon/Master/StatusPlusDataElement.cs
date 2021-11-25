using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class StatusPlusDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Hp;

		[SerializeField]
		private int _Attack;

		[SerializeField]
		private int _Defense;

		public int Id => default(int);

		public int Hp => default(int);

		public int Attack => default(int);

		public int Defense => default(int);
	}
}
