using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameBattleLogUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _iconRt;

		[SerializeField]
		private RectTransform _textRt;

		[SerializeField]
		private SpriteRenderer _bgImage;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private Text _simpleText;

		[SerializeField]
		[Tooltip("ã\u0082¦ã\u0082¤ã\u0083³ã\u0083\u0089ã\u0082¦ã\u0081®é«\u0098ã\u0081\u0095")]
		private float _windowHeight;

		[SerializeField]
		[Tooltip("è¡\u00a8ç¤ºã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _showDuration;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _moveDuration;

		[SerializeField]
		[Tooltip("é\u009d\u009eè¡\u00a8ç¤ºã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
		private float _hideDuration;

		[SerializeField]
		[Tooltip("å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		private float _waitDuration;

		[SerializeField]
		[Tooltip("é«\u0098é\u0080\u009fè¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		private float _fastAnimTimeScale;

		[SerializeField]
		[Tooltip("é«\u0098é\u0080\u009fè¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		private float _fastWaitTimeScale;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088ã\u0081®Yåº§æ\u00a8\u0099èª¿æ\u0095\u00b4ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private float[] _textAdjustPosY;

		private VisibleUIObject _rootVisible;

		private InGameBattleLogCtrl _logCtrl;

		private InGameBattleLogCtrl.LogData _logData;

		private Sequence _seqShow;

		private Sequence _seqMove;

		private Sequence _seqHide;

		private int _displayIndex;

		private bool _isLeft;

		private float _waitTime;

		public static InGameBattleLogUI Create(InGameBattleLogCtrl logCtrl, GameObject prefab, GameObject parent, int index, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(InGameBattleLogCtrl logCtrl, int index)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public bool Show([In] ref InGameBattleLogCtrl.LogData data)
		{
			return default(bool);
		}

		public void Hide(bool isImmediate = false)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public bool IsShowAnim()
		{
			return default(bool);
		}

		public bool IsHideAnim()
		{
			return default(bool);
		}

		public void Move(int index)
		{
		}

		public void SetLayout(bool isLeft)
		{
		}

		private float GetTextAdjustPosY(InGameBattleLogCtrl.LogType type)
		{
			return default(float);
		}

		private void ApplyTextPos(InGameBattleLogCtrl.LogType type)
		{
		}

		private void SetFade(float fade)
		{
		}

		private void SetFade(ref SpriteRenderer sprite, float fade)
		{
		}

		private void SetFade(ref Text text, float fade)
		{
		}

		private void CreateActionShow()
		{
		}

		private void CreateActionMove(int index)
		{
		}

		private void CreateActionHide()
		{
		}
	}
}
