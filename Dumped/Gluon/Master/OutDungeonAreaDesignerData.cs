using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class OutDungeonAreaDesignerData : IMaster<OutDungeonAreaDesignerData>
	{
		[SerializeField]
		private List<OutDungeonAreaDesignerDataElement> list;

		public List<OutDungeonAreaDesignerDataElement> List => null;
	}
}
