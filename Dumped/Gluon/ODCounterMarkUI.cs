using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class ODCounterMarkUI : CharacterMarkUI
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _animRt;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private SpriteRenderer _arrowImage;

		private VisibleUIObject _rootVisible;

		private RectTransform _iconRt;

		private RectTransform _arrowRt;

		private Vector3 _targetPos;

		private Vector2 _adjustPos2D;

		private Sequence _animSeq;

		private Sequence _iconLoopAnimSeq;

		private Sequence _arrowLoopAnimSeq;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Show(Vector3 pos, Vector2 adjustPos2D)
		{
		}

		public void Hide()
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		private void LateUpdate()
		{
		}

		public void SetPosition(Vector3 pos, Vector2 adjustPos2D)
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		private void PlayShowAnim()
		{
		}

		private void PlayLoopAnim()
		{
		}
	}
}
