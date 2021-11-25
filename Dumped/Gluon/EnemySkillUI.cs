using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EnemySkillUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Text label;

		[SerializeField]
		[Header("parameter")]
		private float fadeTime;

		[SerializeField]
		private float stayTime;

		private Tweener tweener;

		private CanvasGroup canvasGroup;

		private VisibleUIObject _rootVisible;

		private bool _isPlaying;

		public static EnemySkillUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Display(string label)
		{
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFadeIn()
		{
		}

		private void OnCompleteFadeOut()
		{
		}
	}
}
