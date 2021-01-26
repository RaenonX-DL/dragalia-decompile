/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkillButton : QuestSkillButtonBase
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform invalidRt;
		[SerializeField]
		[Tooltip]
		private RectTransform noUseRt;
		[SerializeField]
		[Tooltip]
		private RectTransform offsetRt;
		[SerializeField]
		[Tooltip]
		private RectTransform effectRt;
		[SerializeField]
		[Tooltip]
		private RectTransform shadowRt;
		[SerializeField]
		[Tooltip]
		private RectTransform[] countRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _readyAnimFrameRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _changeAnimRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _changeAnimMaxLevelRt;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimGlowUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimFlareUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI[] _changeAnimGlitterUI;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI _changeAnimIconUI;
		[SerializeField]
		[Tooltip]
		private Button button;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer iconImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer changeAnimIconImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer effectImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _readyAnimFrameImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private float expansionTime;
		[SerializeField]
		[Tooltip]
		private int flashCount;
		[SerializeField]
		[Tooltip]
		private float flashTime;
		[Range]
		[SerializeField]
		[Tooltip]
		private float maxFlashPower;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _readyAnimMaxFlashPower;
		private VisibleUIObject rootVisible;
		private VisibleUIObject invalidVisible;
		private VisibleUIObject noUseVisible;
		private VisibleUIObject _readyAnimFrameVisible;
		private VisibleUIObject _changeAnimVisible;
		private VisibleUIObject _changeAnimMaxLevelVisible;
		private IconData[] _iconDataList;
		private IconData _iconData;
		private Tweener tweenerExpansion;
		private Tweener tweenerEffectFlash;
		private bool isLeftFlag;
		private Param _param;
		private const int numCounter = 3;
		private const float tweenerExpansionEndValue = 1f;
	
		// Nested types
		private class IconData
		{
			// Fields
			public string name;
			public Material material;
			public Sprite sprite;
			public Material changeAnimMaterial;
			public Sprite changeAnimSprite;
			public bool isTimer;
			public bool isValue;
	
			// Constructors
			public IconData();
		}
	
		public delegate void ButtonDelegate(QuestSkillButton sender);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public ButtonDelegate func;
			public QuestSkillButton __4__this;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public QuestSkillButton();
	
		// Methods
		public static QuestSkillButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft);
		public void Initialize(ButtonDelegate func, bool isLeft);
		public void OnDestroy();
		public override void FastUpdate();
		public override bool ApplyIcon();
		private void LoadIcon(List<string> iconName);
		public override bool ChangeIcon(int index, bool isForce, bool isFlashAnim = true);
		private void DestroyIcon();
		private void SetIconRate(float rate, bool isForce = false, bool isAnim = true);
		public override void SetIconRateManual(float rate, bool isForce = false);
		public override void Visible(bool b);
		public override bool IsVisible();
		public override void Validate(bool b, bool force = false);
		private void CheckInvalidObj();
		public override int GetCount();
		public override void SetCount(int n);
		public override void SetUnlimited();
		public override void SetReadyAnim();
		public override bool IsReadyAnim();
		public override void SetupReadyAnim(Texture gradationTex, Material frameMat);
		public override void SetVisibleReadyAnim(bool b);
		public override bool IsActiveReadyAnim();
		public override void OnUpdateReadyAnimFlash(float value);
		public override void OnUpdateReadyAnimFrame(float value);
		public override void SetChangeAnim();
		public override bool IsChangeAnim();
		private void PlayChangeAnim();
		private void StopChangeAnim();
		private void OnCompleteChangeAnim();
		private void PlayExpansionAnim();
		private void OnUpdateExpansion(float value);
		private void OnCompleteExpansion();
		private void OnUpdateButtonEffectFlash(float value);
		public override void CopyParam(Param param);
		public override void ApplyParam(Param param);
	}
}
