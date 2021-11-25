using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CollectEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<CollectEventTalkElement> list;

		public List<CollectEventTalkElement> List => null;
	}
}
