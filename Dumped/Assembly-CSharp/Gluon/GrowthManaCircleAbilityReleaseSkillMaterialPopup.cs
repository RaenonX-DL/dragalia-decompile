/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseSkillMaterialPopup : CommonPopup, ICustomMessage
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
		public CommonIcon[] icons;
		public Image[] requiredLabels;
		public UnityEngine.UI.Text[] requiredNumText;
		public Image[] havingLabels;
		public UnityEngine.UI.Text[] havingNumText;
		public UnityEngine.UI.Text[] havingText;
		public Image[] tradeIcons;
		public GameObject bottomHalf;
		public GameObject[] items;
		public Image[] itemIconImages;
		public CommonIconListSortDeco[] itemIconDeco;
		public UnityEngine.UI.Text[] itemDetailText;
		public GameObject burstAttackBaseObj;
		public GameObject statusUpBaseObj;
		public UnityEngine.UI.Text statusText;
		public UnityEngine.UI.Text statusLabel;
		public UnityEngine.UI.Text beforeText;
		public UnityEngine.UI.Text afterText;
		public GameObject manaOrdewRequiredObj;
		public GameObject materialObj;
		[CompilerGenerated]
		private bool _isUpdateMaterial_k__BackingField;
		private readonly Color insufficientTextColor;
		private readonly Color insufficientRequiredColor;
		private readonly Color insufficientHavingColor;
		private readonly Color sufficientRequiredColor;
		private readonly Color sufficientHavingColor;
		private GrowthManaCircleModel model;
		private GrowthManaCircleManaPieceData pieceData;
		private int currentMP;
		private WeaponType weaponType;
		private bool isCircleReleased;
		private bool isReleasePrevPiece;
	
		// Properties
		public bool isUpdateMaterial { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum PopupType
		{
			None = 0,
			Skill = 1,
			Ability = 2,
			ExAbility = 3,
			BurstAttack = 4
		}
	
		[CompilerGenerated]
		private sealed class _SetScrollRectMovementType_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleAbilityReleaseSkillMaterialPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetScrollRectMovementType_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleAbilityReleaseSkillMaterialPopup();
	
		// Methods
		public static GrowthManaCircleAbilityReleaseSkillMaterialPopup Create(ManaPieceType type);
		private void OnEnable();
		private void OnDisable();
		public void SetParameters(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, int currentMP, WeaponType weaponType, bool isCircleReleased = true, bool isReleasePrevPiece = true);
		private void UpdateMaterials();
		public static MaterialDataElement GetRequiredLimitReleaseMaterial(GrowthManaCircleManaPieceData pieceData, int index);
		public static MaterialDataElement GetRequiredLimitReleaseGrowMaterial(GrowthManaCircleManaPieceData pieceData, int index);
		public static MaterialDataElement GetRequiredLimitReleaseUniqueMaterial(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetHavingLimitReleaseMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetHavingLimitReleaseGrowMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetHavingLimitReleaseUniqueMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetRequiredLimitReleaseMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetRequiredLimitReleaseGrowMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		public static int GetRequiredLimitReleaseUniqueMaterialNum(GrowthManaCircleManaPieceData pieceData, int index);
		private void SetSkill(GrowthManaCircleManaPieceData pieceData);
		private void SetAbility(GrowthManaCircleManaPieceData pieceData);
		private void SetExAbility(GrowthManaCircleManaPieceData pieceData);
		private void SetBurstAttack(GrowthManaCircleManaPieceData pieceData, WeaponType weaponType);
		private void SetComboLevelUp(GrowthManaCircleManaPieceData pieceData);
		private void SetMaxLevelUp(GrowthManaCircleManaPieceData pieceData);
		public void SetItem(GrowthManaCircleManaPieceData pieceData);
		public void SetIconImage(PopupType type, int masterId, int level);
		public void SetNameText(string name, ElementalType type = ElementalType.NONE);
		public void SetDetailText(string detail, ElementalType type = ElementalType.NONE);
		[IteratorStateMachine]
		private IEnumerator SetScrollRectMovementType();
		public void SetLevelText(int level, bool isMax = false);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
