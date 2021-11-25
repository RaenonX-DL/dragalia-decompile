using System.Collections.Generic;

namespace Gluon
{
	public class InGameUICommonResourceData
	{
		public Dictionary<int, InGameUIMatarialData> skillMaterialDataDic;

		~InGameUICommonResourceData()
		{
		}

		public virtual void Destroy()
		{
		}
	}
}
