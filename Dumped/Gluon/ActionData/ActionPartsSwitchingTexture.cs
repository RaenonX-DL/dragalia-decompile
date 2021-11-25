using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsSwitchingTexture : ActionParts
	{
		[SerializeField]
		private SwitchingTextureData _data;

		public override PartsData data => null;
	}
}
