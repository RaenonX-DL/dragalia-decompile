using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PlaceNameUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088å\u0090\u008dã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text placeName;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083ªã\u0082¢æ\u009d¡ä»¶ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text summary;

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
		private Image bg;

		[SerializeField]
		private Image border;

		[SerializeField]
		private GameObject timeObject;

		[SerializeField]
		private Image timeIcon;

		[SerializeField]
		private Text timeText;

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
		[Tooltip("å\u0088¶é\u0099\u0090æ\u0099\u0082é\u0096\u0093ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform timeRt;

		[SerializeField]
		[Header("parameter")]
		private float fadeTime;

		[SerializeField]
		private float bgAlpha;

		private VisibleUIObject rootVisible;

		private Vector3 timeOriginPos;

		private Tweener tweenerFade;

		private const float CONTINUE_IMPOSSIBLE_MERGIN = 45f;

		private readonly Color REBORN_CONDITION_COLOR;

		public static PlaceNameUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Open(string placeName, string summary, Color summaryColor, float time)
		{
		}

		public void Close()
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		private void SetupLayout()
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
