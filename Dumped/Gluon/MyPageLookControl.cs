using UnityEngine;

namespace Gluon
{
	public class MyPageLookControl : MonoBehaviour
	{
		public MyPageBgFadeSettings bgFadeSettings;

		public MyPagePostEffectSettings postEffectSettings;

		public MyPagePostEffectParams postEffectParams;

		public MyPageCharacterShaderSettings charaShaderSettings;

		private MyPageScene scene;

		private MyPageTransitionController transition;

		public void Init(MyPageScene scene, MyPageTransitionController transition)
		{
		}

		public void LoadPostEffectParam(bool isMoveMap)
		{
		}

		public void LoadCharaShaderParam(bool isMoveMap)
		{
		}

		public void ApplyCharaShader()
		{
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}

		public void LoadBgFade(bool apply = false)
		{
		}

		public void ApplyBgFade(bool isMoveMap)
		{
		}

		public void ApplyPostEffectParam(bool isMoveMap)
		{
		}

		public void UpdatePostEffectParam(bool isMoveMap)
		{
		}
	}
}
