/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowMaterialListBase : CommonIconListBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tab;
		public Button autoSelectButton;
		public Button manaButton;
		public Button growButton;
		public Button platinumButton;
		public UnityEngine.UI.Text noItemMaterialMessage;
		public UnityEngine.UI.Text[] unitMaterialTypeText;
		public UnitMaterialListController unitMaterialListController;
		public ItemMaterialListController itemMaterialListController;
		public UnityAction growPressedCallback;
		public UnityAction selectConfigCallback;
		public UnityAction autoSelectCallback;
		public UnityAction manaPressedCallback;
		public UnityAction tabButtonCallBack;
		public UnityAction platinumCrystalPressedCallback;
		public GameObject effectBlackObj;
		public bool isReleasePlusParam;
		[SerializeField]
		private UnityEngine.UI.Text materialText;
		[SerializeField]
		private UnityEngine.UI.Text autoText;
		[SerializeField]
		private UnityEngine.UI.Text manaText;
		[SerializeField]
		private UnityEngine.UI.Text grothText;
		[SerializeField]
		private UnityEngine.UI.Text[] itemTexts;
		[SerializeField]
		private GameObject platinumCrystal;
		[SerializeField]
		private UnityEngine.UI.Text platinumCrystalCountText;
		[SerializeField]
		private Image usePlatinumCrystalButtonImage;
		[SerializeField]
		private Sprite spriteUsePlatinumCrystal1;
		[SerializeField]
		private Sprite spriteUsePlatinumCrystal2;
		[CompilerGenerated]
		private UseMaterialType _materialType_k__BackingField;
	
		// Properties
		public UseMaterialType materialType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public GrowMaterialListBase();
	
		// Methods
		public override void Awake();
		private void Start();
		public void ListTabPressedZeroToOne(int index);
		public void ListTabPressed(int tabTag);
		public override void SetupCountText(int nowCount, int maxCount);
		public void AutoButtonPressed();
		public void GrowButtonPressed();
		public void ManaButtonPressed();
		public void SetEnableGrowButton(bool isEnable);
		public void UpdatePlatinumCrystalState(GrowthBaseType growthBaseType, ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData);
		public void OnPlatinumCrystalPressed();
	}
}
