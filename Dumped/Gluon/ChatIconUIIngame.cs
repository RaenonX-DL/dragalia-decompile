using DG.Tweening;
using Gluon.Dungeon;
using UnityEngine;

namespace Gluon
{
	public class ChatIconUIIngame : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private MoveChatIcon moveChatIcon;

		[SerializeField]
		private RectTransform offsetRt;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private SpriteRenderer numberImage;

		[SerializeField]
		private SpriteRenderer frameImage;

		[SerializeField]
		private SpriteRenderer arrowImage;

		[SerializeField]
		[Header("resource")]
		private Sprite[] numberSprite;

		private VisibleUIObject _rootVisible;

		private CharacterBase _currentTargetChara;

		private Sequence _seqEffect;

		private int _playerIndex;

		private int _stampId;

		private float _stayTime;

		private float _fadeTime;

		private bool _isDisplaying;

		private static readonly Color[] PlayerColorList;

		public void Initialize(RectTransform[] rects, StampCollisionArea[] collAreas, float stayTime, float fadeTime, int idx)
		{
		}

		private void OnDestroy()
		{
		}

		public void Display()
		{
		}

		public void Hidden()
		{
		}

		private void PlayShowAnim()
		{
		}

		public void PlayHideAnim()
		{
		}

		public void CancelDisplay()
		{
		}

		public void SetStampId(int stampId)
		{
		}

		private void MainSequenceEndCallback()
		{
		}

		private void Update()
		{
		}

		private void SetDisplayStamp(bool isDisplay)
		{
		}

		public void OnLoadedMaterial(Material mtrl)
		{
		}

		private CharacterBase GetTargetChara()
		{
			return null;
		}

		private int GetActorId()
		{
			return default(int);
		}
	}
}
