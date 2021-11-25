using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DropItemBright : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Image baseImage;

		[SerializeField]
		private Image brightImage0;

		[SerializeField]
		private Image brightImage1;

		private Tweener baseTweener;

		private Tweener brightTweener;

		public static DropItemBright Create(GameObject parent, GameObject prefab)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Play()
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public void Stop()
		{
		}

		public void SetAlpha(float alpha)
		{
		}
	}
}
