using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class MyPageCharacterShaderSettings : SceneShaderSettings
	{
		[HideInInspector]
		public MyPageScene scene;

		private MyPageCharacterShaderSettings asset;

		public void Load(MyPageCharacterShaderSettings asset)
		{
		}

		public void Save()
		{
		}
	}
}
