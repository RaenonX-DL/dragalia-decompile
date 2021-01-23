/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LimitConfirmDialog : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text popMassage;
		public Transform iconListTransform;
		public Image matIcon;
		public Toggle confirmToggle;
		public UnityEngine.UI.Text confirmMessage;
		public LimitStarBase beforeLimitStar;
		public LimitStarBase afterLimitStar;
		public UnityEngine.UI.Text beforeLevel;
		public UnityEngine.UI.Text afterLevel;
		public GameObject[] smallPopSpace;
		public GameObject[] bigPopSpace;
		[SerializeField]
		private UnityEngine.UI.Text starText;
		[SerializeField]
		private UnityEngine.UI.Text lvText;
		[SerializeField]
		private UnityEngine.UI.Text limitBreakText;
		private List<GameObject> sphereItemIconList;
	
		// Constructors
		public LimitConfirmDialog();
	
		// Methods
		public static LimitConfirmDialog Create(bool showBlackLayer = false);
		public void SetupLimitConfirm(Dictionary<ulong, int> materialDatas);
	}
}
