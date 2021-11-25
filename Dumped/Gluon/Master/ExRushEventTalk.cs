using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ExRushEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<ExRushEventTalkElement> list;

		public List<ExRushEventTalkElement> List => null;
	}
}
