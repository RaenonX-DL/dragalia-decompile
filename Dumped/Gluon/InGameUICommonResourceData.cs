using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class InGameUICommonResourceData
	{
		public Dictionary<int, InGameUIMatarialData> skillMaterialDataDict;

		public Dictionary<int, InGameUIMatarialData> dynamicSkillMaterialDataDict;

		~InGameUICommonResourceData()
		{
		}

		public virtual void Destroy()
		{
		}

		public void Destroy(Material material)
		{
		}

		public void Destroy(Sprite sprite)
		{
		}
	}
}
