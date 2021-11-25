using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CombatEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<CombatEventTalkElement> list;

		public List<CombatEventTalkElement> List => null;
	}
}
