using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ActionCollisionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _IsPluralHit;

		public int Id => default(int);

		public int IsPluralHit => default(int);
	}
}
