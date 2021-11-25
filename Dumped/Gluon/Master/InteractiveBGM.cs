using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class InteractiveBGM : IMaster<InteractiveBGM>
	{
		[SerializeField]
		private List<InteractiveBGMElement> list;

		public List<InteractiveBGMElement> List => null;
	}
}
