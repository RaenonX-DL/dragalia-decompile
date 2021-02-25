/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AutoPlayUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform rootRt;
		[SerializeField]
		private RectTransform autoButtonRt;
		[SerializeField]
		private RectTransform autoOffRt;
		[SerializeField]
		private RectTransform autoOnRt;
		[SerializeField]
		private RectTransform autoStopRt;
		[SerializeField]
		private RectTransform dragonButtonRt;
		[SerializeField]
		private RectTransform dragonOffRt;
		[SerializeField]
		private RectTransform dragonOnRt;
		[SerializeField]
		private RectTransform speedButtonRt;
		[SerializeField]
		private RectTransform speedNormalRt;
		[SerializeField]
		private RectTransform speedFastRt;
		[SerializeField]
		private RectTransform repeatButtonRt;
		[SerializeField]
		private RectTransform repeatOffRt;
		[SerializeField]
		private RectTransform repeatOnRt;
		[SerializeField]
		private RectTransform impossibleAutoRt;
		[SerializeField]
		private RectTransform impossibleDragonRt;
		[SerializeField]
		private RectTransform impossibleRepeatRt;
		[SerializeField]
		private SpriteRenderer imageOn;
		[SerializeField]
		private SpriteRenderer imageOnRing;
		[SerializeField]
		private SpriteRenderer imageOnAdd;
		[SerializeField]
		private SpriteRenderer imageStop;
		[SerializeField]
		private SpriteRenderer imageStopAdd;
		[SerializeField]
		private SpriteRenderer imageDragonOn;
		[SerializeField]
		private SpriteRenderer imageDragonOnRing;
		[SerializeField]
		private SpriteRenderer imageDragonOnAdd;
		[SerializeField]
		private SpriteRenderer imageSpeedFast;
		[SerializeField]
		private SpriteRenderer imageSpeedFastRing;
		[SerializeField]
		private SpriteRenderer imageRepeatOn;
		[SerializeField]
		private SpriteRenderer imageRepeatOnRing;
		[SerializeField]
		private SpriteRenderer imageLockAuto;
		[SerializeField]
		private SpriteRenderer imageLockSpeed;
		[SerializeField]
		private SpriteRenderer imageLockRepeat;
		[SerializeField]
		private UnityEngine.UI.Text textRepeatOff;
		[SerializeField]
		private UnityEngine.UI.Text textRepeatOn;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] speedIcon;
		[Header]
		[SerializeField]
		[Tooltip]
		private float ringRotateSpeed;
		[SerializeField]
		[Tooltip]
		private int defaultRaycastSortingOrder;
		[SerializeField]
		[Tooltip]
		private int textSortingOrderOffset;
		private VisibleUIObject _autoOffVisible;
		private VisibleUIObject _autoOnVisible;
		private VisibleUIObject _autoStopVisible;
		private VisibleUIObject _dragonOffVisible;
		private VisibleUIObject _dragonOnVisible;
		private VisibleUIObject _speedNormalVisible;
		private VisibleUIObject _speedFastVisible;
		private VisibleUIObject _repeatOffVisible;
		private VisibleUIObject _repeatOnVisible;
		private Sequence sequenceToStop;
		private Sequence sequenceIdleAlpha;
		private SortingGroup spriteSortingGroup;
		private Canvas repeatOffTextCanvas;
		private Canvas repeatOnTextCanvas;
		private Canvas _raycastCanvas;
		private Vector3 basePos;
		private float tweenStopImageAlpha;
		private float tweenIdleAlpha;
		private bool isStopAutoPlay;
		private bool isAutoEnable;
		private bool isRepeatEnable;
		private bool isQuestStartShowing;
		private const float toStopFadeDuration = 0.1f;
		private const float idleAlphaDuration = 0.75f;
		private const float idleAlphaScale = 0.5f;
		private const float idleAlphaScaleStop = 0.15f;
		private const float lockStatusAdjustPos = 20f;
		private const float systemMessageDisplayTime = 2f;
		private readonly float[] raidQuestPosYList;
	
		// Constructors
		public AutoPlayUI();
	
		// Methods
		public static AutoPlayUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		private void ResetParameter();
		private void UpdateStopAlphaValue(float alpha);
		private void UpdateIdleAlphaValue(float alpha);
		private void OnDestroy();
		private void Update();
		private void UpdateImageFade(ref SpriteRenderer image, float a);
		public void OnClickAutoPlay();
		private void ExecOnClickAutoPlay(bool val, bool withSE);
		public void OnClickDragon();
		public void OnClickSpeed();
		public void OnClickRepeat();
		private void SetAutoMode(bool val, bool withSE);
		private void SetDragonImage(bool val, bool withSE, bool applyMode);
		private void SetSpeedRateImage(InGameTime.GameSpeed rate, bool withSE);
		private void SetRepeatImage(bool val, bool effect);
		public void SetLock(bool isLock);
		public void SetEnable(bool isEnable);
		public void SetRepeatCounter(int currNum, int loopNum);
		public void SetRaidQuestPosition(int otherPlayerNum);
		private void SetActive(ref RectTransform rt, bool active);
		private void SetActive(ref SpriteRenderer sr, bool active);
		private bool IsSingleQuest();
		private bool IsEnableRepeat();
	}
}
