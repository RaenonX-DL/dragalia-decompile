/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NameInfoPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image selectNameRarity;
		[SerializeField]
		private UnityEngine.UI.Text selectName;
		[SerializeField]
		private UnityEngine.UI.Text selectNameRuby;
		[SerializeField]
		private UnityEngine.UI.Text conditionTitle;
		[SerializeField]
		private UnityEngine.UI.Text notObtainedText;
		[SerializeField]
		private GameObject nameBaseObj;
		[SerializeField]
		private UnityEngine.UI.Text ConditionText;
		private static readonly string popupPath;
	
		// Constructors
		public NameInfoPopup();
		static NameInfoPopup();
	
		// Methods
		public static NameInfoPopup Create(AnotherNameCellData data, bool showBlackLayer);
		private void SetPopup(AnotherNameCellData data);
	}
}
