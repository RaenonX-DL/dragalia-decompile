using System.Collections.Generic;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeTalk : IMaster<DmodeTalk>
	{
		[SerializeField]
		private List<DmodeTalkElement> list;

		public List<DmodeTalkElement> List => null;
	}
}
