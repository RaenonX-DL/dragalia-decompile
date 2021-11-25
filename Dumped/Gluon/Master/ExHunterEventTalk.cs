using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ExHunterEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<ExHunterEventTalkElement> list;

		public List<ExHunterEventTalkElement> List => null;
	}
}
