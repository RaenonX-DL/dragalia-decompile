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
	public class GrowthBaseSelectListBase : CommonIconListBase
	{
		// Fields
		public GrowthBaseSelectListController listController;
		public TabBase listTab;
		public GameObject awakeBase;
		public UnityEngine.UI.Text awakeText;
		public GameObject listSpace;
		public GameObject effectBaseObject;
		public UnityAction listChangeButtonCallBack;
		public GameObject listButtonObj;
		public UnityAction resetPlusButtonCallBack;
		public GameObject resetButtonObj;
		public UnityEngine.UI.Text resetButtonText;
		public bool isReleaseResetPlus;
		public MaintenanceButtonController resetButtonMainte;
		public GameObject searchSpaceObject;
		public Button crestInfoButton;
		public UnityEngine.UI.Text crestInfoButtonText;
	
		// Constructors
		public GrowthBaseSelectListBase();
	
		// Methods
		public void InitListBase();
		public void OnListChangeButtonPressed();
		public void OnResetPlusButtonPressed();
		public void ChangeTabText(bool isResetPlus);
		public void OnCresetInfoChangeButtonPressed();
	}
}
