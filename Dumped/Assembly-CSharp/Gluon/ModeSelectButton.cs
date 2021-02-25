/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ModeSelectButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _onFrameSprites;
		[SerializeField]
		[Tooltip]
		private Sprite[] _offFrameSprites;
		[Header]
		[SerializeField]
		[Tooltip]
		private Vector3 _buttonBasePos;
		[SerializeField]
		[Tooltip]
		private float _buttonOffsetY;
		[SerializeField]
		[Tooltip]
		private int _activeModeSortingOrder;
		[SerializeField]
		[Tooltip]
		private int _deactiveModeSortingOrder;
		[CompilerGenerated]
		private HumanCharacter _human_k__BackingField;
		[CompilerGenerated]
		private int _index_k__BackingField;
		[CompilerGenerated]
		private int _modeId_k__BackingField;
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
	
		// Properties
		public HumanCharacter human { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int index { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int modeId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 ButtonBasePos { get; }
		public float ButtonOffsetY { get; }
	
		// Nested types
		public delegate void ButtonDelegate(ModeSelectButton sender);
	
		public enum FrameType
		{
			Top = 0,
			Center = 1,
			Bottom = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public ButtonDelegate func;
			public ModeSelectButton __4__this;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public ModeSelectButton();
	
		// Methods
		public static ModeSelectButton Create(GameObject parent, HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLext, int siblingIndex = -1);
		public void Initialize(HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLeft);
		private void OnDestroy();
		public override void FastUpdate();
		private void SetIconImage(int modeId);
		private void CheckInactive();
		public void Visible(bool b);
		public bool IsVisible();
		public void Validate(bool validate, bool on, bool playSe, bool force = false);
		public void SetFrameType(FrameType type, bool force = false);
		public Vector2 GetButtonPosition();
		public Vector2 GetButtonSize();
		public void SetEnabled(bool b);
		private void SetSortingGroup(int sortingOrder);
		private void PlaySelectedAnim();
		[CompilerGenerated]
		private void _PlaySelectedAnim_b__67_0();
	}
}
