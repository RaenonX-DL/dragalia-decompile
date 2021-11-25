using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class HitCountUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _countAdjustRt;

		[SerializeField]
		private SpriteRenderer _captionImage;

		[SerializeField]
		private SpriteRenderer[] _countImage;

		[SerializeField]
		[Header("resource")]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ã\u0081®ç\u0094»å\u0083\u008fã\u0083ªã\u0082½ã\u0083¼ã\u0082¹")]
		private Sprite[] _countSprite;

		[SerializeField]
		[Tooltip("é\u0080\u009aå\u00b8\u00b8æ\u0099\u0082ã\u0081®è\u0089²")]
		private Color _defaultColor;

		[SerializeField]
		[Tooltip("ç\u0080\u0095æ­»æ\u0099\u0082ã\u0081®è\u0089²")]
		private Color _dyingColor;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("æ¡\u0081ã\u0081\u0094ã\u0081\u00a8ã\u0081®é\u0096\u0093é\u009a\u0094")]
		private float _digitMergin;

		[SerializeField]
		[Tooltip("ç\u0080\u0095æ­»HPã\u0081®å\u0089²å\u0090\u0088")]
		private float _dyingRate;

		private VisibleUIObject _rootVisible;

		private RectTransform[] _countRt;

		private CharacterMarkUI _mark;

		private RectTransform _markRt;

		private int _maxCount;

		private int _lastCount;

		private int _lastMaxCount;

		public static HitCountUI Create(GameObject parent, CharacterMarkUI mark, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(CharacterMarkUI mark)
		{
		}

		public override void FastUpdate()
		{
		}

		protected void UpdatePosition()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void ResetCount()
		{
		}

		public void SetCount(int count, int maxCount)
		{
		}

		private void SetCountSprite(ref SpriteRenderer image, int index, bool isEnabled, Color color)
		{
		}
	}
}
