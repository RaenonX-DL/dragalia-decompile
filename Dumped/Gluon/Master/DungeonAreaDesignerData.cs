using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class DungeonAreaDesignerData : IMaster<DungeonAreaDesignerData>
	{
		[SerializeField]
		private List<DungeonAreaDesignerDataElement> list;

		public List<DungeonAreaDesignerDataElement> List => null;
	}
}
