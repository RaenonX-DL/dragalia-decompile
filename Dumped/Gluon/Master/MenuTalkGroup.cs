using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class MenuTalkGroup : IMaster<MenuTalkGroup>
	{
		[SerializeField]
		private List<MenuTalkGroupElement> list;

		public List<MenuTalkGroupElement> List => null;
	}
}
