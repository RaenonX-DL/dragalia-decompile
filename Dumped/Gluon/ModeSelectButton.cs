using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Gluon
{
	public class ModeSelectButton : FastUpdateMonoBehaviour
	{
		public delegate void ButtonDelegate(ModeSelectButton sender);

		public enum FrameType
		{
			Top,
			Center,
			Bottom
		}

		[SerializeField]
		[Header("component")]
		private Button _button;

		[SerializeField]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _offsetRt;

		[SerializeField]
		private RectTransform _buttonOnRt;

		[SerializeField]
		private RectTransform _buttonOffRt;

		[SerializeField]
		private RectTransform _buttonIconRt;

		[SerializeField]
		private RectTransform _iconRt;

		[SerializeField]
		private RectTransform _invalidRt;

		[SerializeField]
		private RectTransform _frameRt;

		[SerializeField]
		private SpriteRenderer _onButtonImage;

		[SerializeField]
		private SpriteRenderer _onAddButtonImage;

		[SerializeField]
		private SpriteRenderer _offButtonImage;

		[SerializeField]
		private SpriteRenderer _onNoUseImage;

		[SerializeField]
		private SpriteRenderer _offNoUseImage;

		[SerializeField]
		private SpriteRenderer _onFrameImage;

		[SerializeField]
		private SpriteRenderer _offFrameImage;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private Material _colorAdjustMaterial;

		[SerializeField]
		private SortingGroup _sortingGropup;

		[SerializeField]
		[Header("resource")]
		[Tooltip("ONã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ç\u0094»å\u0083\u008f")]
		private Sprite[] _onFrameSprites;

		[SerializeField]
		[Tooltip("OFFã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ç\u0094»å\u0083\u008f")]
		private Sprite[] _offFrameSprites;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹åº§æ\u00a8\u0099")]
		private Vector3 _buttonBasePos;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®Yè»\u00b8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088å\u0080¤")]
		private float _buttonOffsetY;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0081®ã\u0082½ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083³ã\u0082°ã\u0082ªã\u0083¼ã\u0083\u0080ã\u0083¼")]
		private int _activeModeSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0081®ã\u0082½ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083³ã\u0082°ã\u0082ªã\u0083¼ã\u0083\u0080ã\u0083¼")]
		private int _deactiveModeSortingOrder;

		private VisibleUIObject _rootVisible;

		private VisibleUIObject _offsetVisible;

		private VisibleUIObject _invalidVisible;

		private Sequence _seqSelected;

		private Material _material;

		private Sprite _sprite;

		private bool _buttonOn;

		private bool _validate;

		private bool _inactive;

		private FrameType _frameType;

		public HumanCharacter human
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int index
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int modeId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 ButtonBasePos => default(Vector3);

		public float ButtonOffsetY => default(float);

		public static ModeSelectButton Create(GameObject parent, HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLext, int siblingIndex = -1)
		{
			return null;
		}

		public void Initialize(HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLeft)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void SetIconImage(int modeId)
		{
		}

		private void CheckInactive()
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Validate(bool validate, bool on, bool playSe, bool force = false)
		{
		}

		public void SetFrameType(FrameType type, bool force = false)
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		public Vector2 GetButtonSize()
		{
			return default(Vector2);
		}

		public void SetEnabled(bool b)
		{
		}

		private void SetSortingGroup(int sortingOrder)
		{
		}

		private void PlaySelectedAnim()
		{
		}
	}
}
