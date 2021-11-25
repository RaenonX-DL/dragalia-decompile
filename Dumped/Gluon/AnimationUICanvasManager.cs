using System.Collections.Generic;

namespace Gluon
{
	public class AnimationUICanvasManager : SingletonInBaseMonoBehaviour<AnimationUICanvasManager>
	{
		private List<AnimationUICanvas> animationUICanvases;

		public void Register(AnimationUICanvas item)
		{
		}

		public void UnRegister(AnimationUICanvas item)
		{
		}

		public void Clear()
		{
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation(bool bClear = true)
		{
		}

		public bool CheckRegisteredCanvas(AnimationUICanvas item)
		{
			return default(bool);
		}
	}
}
