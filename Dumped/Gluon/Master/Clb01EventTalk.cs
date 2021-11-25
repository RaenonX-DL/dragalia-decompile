using System;
using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class Clb01EventTalk : IMasterGroupElement
	{
		[SerializeField]
		private List<Clb01EventTalkElement> list;

		public List<Clb01EventTalkElement> List => null;
	}
}
