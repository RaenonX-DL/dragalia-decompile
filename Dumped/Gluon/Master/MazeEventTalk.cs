using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<MazeEventTalkElement> list;

		public List<MazeEventTalkElement> List => null;
	}
}
