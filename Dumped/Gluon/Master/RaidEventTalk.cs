using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<RaidEventTalkElement> list;

		public List<RaidEventTalkElement> List => null;
	}
}
