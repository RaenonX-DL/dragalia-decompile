using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PlaceNameRichUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088å\u0090\u008d")]
		private Text placeName;

		[SerializeField]
		private Image bg;

		[SerializeField]
		private Text floorText;

		[SerializeField]
		private Text floorPlace;

		[SerializeField]
		private Image lineImage;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exConditionText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶2ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition2Text;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶3ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition3Text;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform exConditionRt;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶2ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform exCondition2Rt;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aæ\u009d¡ä»¶3ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform exCondition3Rt;

		[SerializeField]
		[Header("parameter")]
		private float fadeInTime;

		[SerializeField]
		private float fadeOutTime;

		[SerializeField]
		private float bgAlpha;

		private RectTransform rootRt;

		private Tweener tweenerFade;

		private Coroutine coroutine;

		private PlayFTU ftu;

		private PlayFTU.Type ftuType;

		private string ftuCloseLabel;

		private bool isActive;

		private bool isRaedy;

		private bool isFloor;

		private readonly Color REBORN_CONDITION_COLOR;

		public static PlaceNameRichUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType, string ftuCloseLabel)
		{
		}

		public void Ready(string placeName, int floor)
		{
		}

		private void OnReady(PlayFTU sender)
		{
		}

		private void SetupLayout()
		{
		}

		public void Open()
		{
		}

		private IEnumerator PlayFlash()
		{
			return null;
		}

		public void Close()
		{
		}

		private IEnumerator PlayCloseFlash()
		{
			return null;
		}

		private void OnUpdateFadeIn(float value)
		{
		}

		private void OnUpdateFadeOut(float value)
		{
		}

		private void OnCompleteFadeIn()
		{
		}

		private void OnCompleteFadeOut()
		{
		}

		public void Release()
		{
		}

		private void SetActive(bool active)
		{
		}
	}
}
