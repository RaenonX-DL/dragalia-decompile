/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUnitEnhanceStatusController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public CommonUnitIcon unitIcon;
		public GrowthUnitEnhanceStatusObject[] statusObjects;
		public GameObject[] pagerOn;
		public GameObject[] pagerOff;
		public Button leftArrow;
		public Button rightArrow;
		public UnityEngine.UI.Text unitName;
		public UnityEngine.UI.Text unitReleaseCount;
		public UnityEngine.UI.Text unitHp;
		public UnityEngine.UI.Text unitAtk;
		public UnityEngine.UI.Text unitPower;
		public Image skillIcon;
		public Image abilityIcon1;
		public Image abilityIcon2;
		public Image[] slotIconsTypeA;
		public Image[] slotIconsTypeB;
		public Image[] slotIconsTypeC;
		public Image[] equipableIcons;
		private GrowthUnitEnhanceModel model;
		private GrowthUnitEnhanceMainCanvas mainCanvas;
		private int currentIndex;
		private Vector2 beginDragPosition;
		private bool isAnimating;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public GrowthUnitEnhanceStatusController __4__this;
			public bool isWeaponData;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _ReleadUnitIcon_b__0();
			internal void _ReleadUnitIcon_b__1();
		}
	
		// Constructors
		public GrowthUnitEnhanceStatusController();
	
		// Methods
		public void InitStatusController(GrowthUnitEnhanceModel model, GrowthUnitEnhanceMainCanvas mainCanvas);
		public void UpdateUnitStatus();
		public void SetArrowEnable(bool enable);
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		public void ShowNextStatusObject();
		public void ShowPrevStatusObject();
		public void OnAnimationCompleted();
		public void OnSkillIconPressed();
		public void OnAbility1IconPressed();
		public void OnAbility2IconPressed();
		private void SetPageOn(int index);
		private void ReleadUnitIcon();
	}
}
