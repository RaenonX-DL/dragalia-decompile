using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonTalk : IMaster<DragonTalk>
	{
		[SerializeField]
		private List<DragonTalkElement> list;

		public List<DragonTalkElement> List => null;
	}
}
