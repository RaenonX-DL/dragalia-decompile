using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class CrossFadeBGM : IMaster<CrossFadeBGM>
	{
		[SerializeField]
		private List<CrossFadeBGMElement> list;

		public List<CrossFadeBGMElement> List => null;
	}
}
