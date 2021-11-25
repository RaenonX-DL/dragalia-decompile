using UnityEngine;

namespace Gluon
{
	public class PostEffectExternalMode : MonoBehaviour
	{
		private CacheCamera _cacheCamera;

		private Camera _postEffectCamera;

		private PostEffect _postEffect;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public virtual DepthTextureMode GetNeedDepthTextureMode()
		{
			return default(DepthTextureMode);
		}
	}
}
