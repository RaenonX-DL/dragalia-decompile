/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickRequiredBuffGaugeIconUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform rootRt;
		[SerializeField]
		private SpriteRenderer iconImage;
		[SerializeField]
		private SpriteRenderer overlayImage;
		[SerializeField]
		private SpriteRenderer overlayCircleImage;
		[SerializeField]
		private SpriteRenderer overlayLoopImage;
		[SerializeField]
		private SpriteRenderer ringImage;
		[Header]
		[SerializeField]
		private Color enableColor;
		[SerializeField]
		private Color disableColor;
		private Sequence seqAnim;
		private Sequence seqLoopAnim;
		private Action onCompleteActiveAnim;
		private Action onInactive;
		[CompilerGenerated]
		private bool _isActive_k__BackingField;
		[CompilerGenerated]
		private bool _isEnable_k__BackingField;
	
		// Properties
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharaGimmickRequiredBuffGaugeIconUI();
	
		// Methods
		public void Initialize(string iconName, Action onCompleteActiveAnim, Action onInactive);
		public void SetupIcon(string iconName);
		private void OnDestroy();
		public void SetEnable(bool b, bool isForce = false);
		public void SetActive(bool b);
		public void PlayActiveAnim();
		public void PlayAllSlotActiveAnim();
		public void StopAllSlotActiveAnimForLoop();
		public bool IsPlayingAnim();
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_1(float t);
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_2(float t);
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_3(float t);
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_4(float t);
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_5(float t);
		[CompilerGenerated]
		private void _PlayActiveAnim_b__25_0();
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_0(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_1(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_3(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_4(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_5(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_6(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_7(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_8(float t);
		[CompilerGenerated]
		private void _PlayAllSlotActiveAnim_b__26_2();
	}
}
