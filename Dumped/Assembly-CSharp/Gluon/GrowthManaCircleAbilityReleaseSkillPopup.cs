/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseSkillPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text subTitle1;
		public UnityEngine.UI.Text subTitle2;
		public UnityEngine.UI.Text label2;
		public UnityEngine.UI.Text requiredMpNum;
		public UnityEngine.UI.Text currentMPNum;
		public UnityEngine.UI.Text afterMPNum;
		public UnityEngine.UI.Text warningText;
		public Image manaIcon;
		public Image dewIcon;
		public Image iconImage;
		public GameObject burstAttackIcon;
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text detailText;
		public CommonIconListSortDeco iconDeco;
		public ScrollRect detailScrollRect;
		public GameObject bottomHalf;
		public GameObject[] items;
		public Image[] itemIconImages;
		public CommonIconListSortDeco[] itemIconDeco;
		public UnityEngine.UI.Text[] itemDetailText;
		public UnityEngine.UI.Text[] requiredDewNums;
		public UnityEngine.UI.Text[] dewLabelText;
		public GameObject manaOrdewRequiredObj;
		public GameObject materialObj;
		public GrowthManaCircleReleaseMaterialIcon icon;
		public CommonExAbilityCell[] exAbilityCells;
	
		// Nested types
		public enum PopupType
		{
			None = 0,
			Skill = 1,
			Ability = 2,
			ExAbility = 3,
			BurstAttack = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__28_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetParameters_b__28_0();
		}
	
		[CompilerGenerated]
		private sealed class _SetScrollRectMovementType_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleAbilityReleaseSkillPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetScrollRectMovementType_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleAbilityReleaseSkillPopup();
	
		// Methods
		public static GrowthManaCircleAbilityReleaseSkillPopup Create(ManaPieceType type, bool isGrowMaterial = false);
		public void SetParameters(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, int currentMP, WeaponType weaponType, bool isCircleReleased = true);
		private void SetSkill(GrowthManaCircleManaPieceData pieceData);
		private void SetAbility(GrowthManaCircleManaPieceData pieceData);
		private void SetExAbility(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleManaPieceData[] exAbilityPieceData, int exAbilityLevel);
		private void SetExAbilityGrowthMaterial(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleManaPieceData[] exAbilityPieceData, int exAbilityLevel);
		private void SetBurstAttack(GrowthManaCircleManaPieceData pieceData, WeaponType weaponType);
		public void SetItem(GrowthManaCircleManaPieceData pieceData);
		public void SetIconImage(PopupType type, int masterId, int level, int index = 0);
		public void SetNameText(string name, ElementalType type = ElementalType.NONE);
		public void SetDetailText(string detail, ElementalType type = ElementalType.NONE);
		[IteratorStateMachine]
		private IEnumerator SetScrollRectMovementType();
		public void SetLevelText(int level, bool isMax = false);
	}
}
