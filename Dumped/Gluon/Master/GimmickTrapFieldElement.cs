using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickTrapFieldElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _ActionHitAttribute;

		public string Id => null;

		public string ActionHitAttribute => null;
	}
}
