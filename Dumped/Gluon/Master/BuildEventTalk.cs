using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<BuildEventTalkElement> list;

		public List<BuildEventTalkElement> List => null;
	}
}
