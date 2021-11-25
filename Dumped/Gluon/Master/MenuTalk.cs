using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class MenuTalk : IMaster<MenuTalk>
	{
		[SerializeField]
		private List<MenuTalkElement> list;

		public List<MenuTalkElement> List => null;
	}
}
