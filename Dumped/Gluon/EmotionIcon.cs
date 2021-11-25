using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EmotionIcon : MonoBehaviour
	{
		public enum Balloon
		{
			Standard,
			Intense
		}

		public enum Icon
		{
			Exclamation,
			Anger,
			Exclamation2
		}

		private enum Stat
		{
			None,
			In,
			Stay,
			Out
		}

		[SerializeField]
		[Header("component")]
		private Image balloonImage;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private GameObject scaleObject;

		[SerializeField]
		[Header("resource")]
		private Sprite[] balloonSprite;

		[SerializeField]
		private Sprite[] iconSprite;

		[SerializeField]
		[Header("parameter")]
		private float fadeTime;

		[SerializeField]
		private float stayTime;

		[SerializeField]
		private Vector2[] ofsIcon;

		[SerializeField]
		private float iconScaleH;

		[SerializeField]
		private float iconScaleW;

		[SerializeField]
		private float scaleInTime;

		[SerializeField]
		private float scaleOutTime;

		private const int numBalloon = 2;

		private const int numIcon = 3;

		private Vector2[] sizeBalloon;

		private Vector2[] sizeIcon;

		private Tweener tweener;

		private Tweener tweenerScale;

		private CanvasGroup canvasGroup;

		private CharacterBase chara;

		private float correctPosY;

		private Stat stat;

		private RectTransform rootRt;

		private RectTransform balloonRt;

		private RectTransform iconRt;

		private bool isActive;

		private InGameUICtrl inGameUI;

		public static EmotionIcon Create(InGameUICtrl inGameUI, GameObject prefab, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(InGameUICtrl inGameUI)
		{
		}

		private void LateUpdate()
		{
		}

		public void Display(CharacterBase chara, Icon icon, Balloon balloon, float scale, float posY = 0f)
		{
		}

		public void Stop()
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		private void UpdatePosision()
		{
		}

		private Vector2 GetScreenPos(CharacterBase chara)
		{
			return default(Vector2);
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFadeIn()
		{
		}

		private void OnCompleteFadeStay()
		{
		}

		private void OnCompleteFadeOut()
		{
		}

		private void OnUpdateScaleIn(float value)
		{
		}

		private void OnUpdateScaleOut(float value)
		{
		}

		private void OnCompleteScaleIn()
		{
		}

		private void OnCompleteScaleOut()
		{
		}
	}
}
