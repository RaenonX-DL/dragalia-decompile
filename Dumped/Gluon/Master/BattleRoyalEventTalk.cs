using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalEventTalk : IMaster<BattleRoyalEventTalk>
	{
		[SerializeField]
		private List<BattleRoyalEventTalkElement> list;

		public List<BattleRoyalEventTalkElement> List => null;
	}
}
