using UnityEngine;

namespace Gluon
{
	public class SandTimerUI : MonoBehaviour
	{
		public enum CountColorType
		{
			White,
			Green,
			Orange,
			Red
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform[] _countRt;

		[SerializeField]
		private SpriteRenderer[] _countSr;

		[SerializeField]
		[Header("resource")]
		private Sprite[] _timeSprite;

		private VisibleUIObject _rootVisible;

		private DeathTimerUniqueCtrl _deathTimerUniqueCtrl;

		private const int DIGIT_NUMBER = 3;

		private static readonly int MAX_COUNT;

		public static readonly Color COUNT_COLOR_GREEN;

		public static readonly Color COUNT_COLOR_ORANGE;

		public static readonly Color COUNT_COLOR_RED;

		public static SandTimerUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void SetCount(int count)
		{
		}

		public void SetCountColor(CountColorType type)
		{
		}

		public bool IsCountDown(CharacterBase owner)
		{
			return default(bool);
		}
	}
}
