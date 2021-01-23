/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonDetailPage : EventQuestPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		public SummonResultStatusPlate statusPlate;
		[SerializeField]
		private Transform returnButtonTransform;
		private SceneNameDefine.PageName previousPageName;
		[CompilerGenerated]
		private Action _onBeforLeaving_k__BackingField;
	
		// Properties
		public Action onBeforLeaving { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public DragonDetailPage();
	
		// Methods
		public void OnButtonBackTouched();
		public void SetContent(SummonResultItemData itemData, SceneNameDefine.PageName lastPage);
	}
}
