using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class PlayerHitConditionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Lable;

		public int Id => default(int);

		public string Lable => null;
	}
}
