using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsShaderParam : ActionParts
	{
		[SerializeField]
		private ShaderParamData _data;

		public override PartsData data => null;
	}
}
