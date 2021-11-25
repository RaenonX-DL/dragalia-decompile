using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _AbilityGroupName;

		public int Id => default(int);

		public string AbilityGroupName => null;
	}
}
