using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class MyPageLightProbeParamCategory : MonoBehaviour
	{
		public enum Category
		{
			None = -1,
			Chara,
			BgObject,
			ActionObject,
			DecorationObject
		}

		public Category category;

		public LightProbeParamCategory GetLightProbeParamCategory()
		{
			return default(LightProbeParamCategory);
		}
	}
}
