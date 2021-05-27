/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowResultStatusDialog : CommonPopup
	{
		// Fields
		public Image baseIcon;
		public GrowResultDiffParam growResultDiffParam;
		public GrowResultGetSkill growResultGetSkill;
		public GameObject growResultLimitLevel;
		public GrowResultDialogType goOtherSceneResultType;
		public NeedLimitMaterialType needLimitMaterialType;
		[SerializeField]
		private UnityEngine.UI.Text lvText;
		[SerializeField]
		private UnityEngine.UI.Text hpText;
		[SerializeField]
		private UnityEngine.UI.Text atkText;
		[SerializeField]
		private UnityEngine.UI.Text powerText;
		[SerializeField]
		private RectTransform needLimitMaterialParent;
		[SerializeField]
		private UnityEngine.UI.Text limitLevelInfo;
		[SerializeField]
		private GameObject needLimitMaterialTypeParent;
		private List<GrowResultDialogType> resultStateList;
		private GrowResultBaseData oldBaseData;
		private GrowResultBaseData newBaseData;
		private bool isOkButtonManaCircle;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _uiRebuildCorutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowResultStatusDialog __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _uiRebuildCorutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowResultStatusDialog();
	
		// Methods
		public static GrowResultStatusDialog Create(bool showBlackLayer = false, GrowthBaseType growthBaseType = GrowthBaseType.Weapon);
		public void SetupResultDialog(GrowResultBaseData oldData, GrowResultBaseData updateData, bool isLimitBreak);
		public void LimitBreakPressed();
		public void CancelButtonPressed();
		private void ShowDialog();
		private void ShowDiffParam();
		private void ShowMaxLevel(GrowResultDialogType type);
		[IteratorStateMachine]
		private IEnumerator uiRebuildCorutine();
		private void ShowMaxPlus();
		private void ClosePop();
		public void OnAlbumButton();
		public void OnManaCircleButton();
		[CompilerGenerated]
		private void _SetupResultDialog_b__18_0();
	}
}
