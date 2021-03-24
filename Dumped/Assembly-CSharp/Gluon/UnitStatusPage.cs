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
	public class UnitStatusPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text statusPageTitle;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text hpParam;
		[SerializeField]
		private UnityEngine.UI.Text hpPlusParam;
		[SerializeField]
		private UnityEngine.UI.Text hpAndPlusParam;
		public UnityEngine.UI.Text atkParam;
		[SerializeField]
		private UnityEngine.UI.Text atkPlusParam;
		[SerializeField]
		private UnityEngine.UI.Text atkAndPlusParam;
		public UnityEngine.UI.Text defParam;
		public UnityEngine.UI.Text powerParam;
		[SerializeField]
		private GameObject[] separateValueObj;
		[SerializeField]
		private GameObject[] sumValueObj;
		[SerializeField]
		private Button paramSwitchButton;
		[Header]
		[SerializeField]
		private GameObject possessionNode;
		[SerializeField]
		private UnityEngine.UI.Text possessionText;
		[Header]
		[SerializeField]
		private GameObject unionNode;
		[SerializeField]
		private Image[] unionImage;
		[SerializeField]
		private UnityEngine.UI.Text unionNothing;
		[Header]
		[SerializeField]
		private GameObject slotNode;
		[SerializeField]
		private Image[] slotImage;
		[Header]
		[SerializeField]
		private GameObject gaugeNode;
		[Header]
		[SerializeField]
		private GameObject levelNode;
		[Header]
		[SerializeField]
		public CharaTypeUI charaType;
		[Header]
		[SerializeField]
		public GameObject detailButtonBase;
		public UnityAction statusDetailCallBack;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text levelText;
		public UnityEngine.UI.Text expText;
		public Slider expGauge;
		public GameObject fullGageFill;
		public Button expChangeButton;
		[Header]
		[SerializeField]
		public GameObject limitBase;
		public GameObject[] limitOnImages;
		public GameObject[] limitMaxImages;
		[Header]
		[SerializeField]
		public Image manaStar;
		public UnityEngine.UI.Text manaCountText;
		[Header]
		[SerializeField]
		public GameObject shareSkillCostObj;
		public UnityEngine.UI.Text shareSkillCostText;
		[SerializeField]
		public Image weaponSkinIcon;
		[HideInInspector]
		public UnitDetailCanvas parentCanvas;
		private UnitDetailModel.UnitDetailType unitType;
		private bool isShowNextLv;
		private bool isParamSwitch;
		[SerializeField]
		private GameObject modeIconParent;
		[SerializeField]
		private Image[] modeIconImage;
		private Color grayout;
	
		// Constructors
		public UnitStatusPage();
	
		// Methods
		public void SetupStatusPage(UnitDetailModel.UnitDetailType type);
		private void SetupCommonInfo();
		public void ExpInfoChangeButtonPressed();
		private void SetNextLevelGauge();
		public void StatusDetailButtonPressed();
		private void SetStatusInfo();
		private void SetGunModeIcon(Image image, int modeId);
		public void OnParamSwitchButton();
	}
}
