using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaTalk : IMaster<CharaTalk>
	{
		[SerializeField]
		private List<CharaTalkElement> list;

		public List<CharaTalkElement> List => null;
	}
}
