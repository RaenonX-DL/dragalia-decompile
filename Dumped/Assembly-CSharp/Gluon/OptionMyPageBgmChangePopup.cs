/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionMyPageBgmChangePopup : PopupBase
	{
		// Fields
		[SerializeField]
		private GameObject[] togglesObject;
		[SerializeField]
		private GameObject limitedTitleObject;
		[SerializeField]
		private int regularBgmCount;
		private int selectedBgmId;
		private int changedBgmId;
		private Action<int> onChangeBgmAction;
		private bool isLimitedBgmExist;
	
		// Constructors
		public OptionMyPageBgmChangePopup();
	
		// Methods
		public static OptionMyPageBgmChangePopup Create(Action<int> onChangeBgmAction);
		private void Awake();
		private void SetEnentBgmToggle();
		private void SetUpToggle(GameObject obj);
		private bool IsBgmEnabled(int bgmId);
		private string GetBgmTitle(int bgmId);
		public void OnSelectToggle(OptionBgmSelectToggle toggle);
		public void OnOKButtonPressed();
	}
}
