using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EarnEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<EarnEventTalkElement> list;

		public List<EarnEventTalkElement> List => null;
	}
}
