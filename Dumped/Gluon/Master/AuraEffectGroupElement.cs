using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AuraEffectGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _CoexistGroupId1;

		[SerializeField]
		private int _CoexistGroupId2;

		[SerializeField]
		private int _CoexistGroupId3;

		public int Id => default(int);

		public int Priority => default(int);

		public int CoexistGroupId1 => default(int);

		public int CoexistGroupId2 => default(int);

		public int CoexistGroupId3 => default(int);
	}
}
