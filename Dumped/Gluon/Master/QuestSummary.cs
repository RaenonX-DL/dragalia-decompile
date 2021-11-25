using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestSummary : IMaster<QuestSummary>
	{
		[SerializeField]
		private List<QuestSummaryElement> list;

		public List<QuestSummaryElement> List => null;
	}
}
