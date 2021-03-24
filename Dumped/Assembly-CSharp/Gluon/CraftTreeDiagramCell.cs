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
	public class CraftTreeDiagramCell : MonoBehaviour
	{
		// Fields
		public Image weaponIcon;
		public Transform selectBase;
		public Transform targetBase;
		public UnityEngine.UI.Text selectText;
		public UnityEngine.UI.Text baseText;
		public UnityAction<int> cellPressCallBack;
		public int cellId;
		public GameObject sortDecoAttachNode;
		public Image skillIcon;
		public Image[] abilityIcons;
		public Transform spUpgradeBase;
		private bool isEmpty;
		private bool isBaseData;
		private bool isChildData;
		private int weaponId;
	
		// Constructors
		public CraftTreeDiagramCell();
	
		// Methods
		public void SetTreeIcon(CraftTreeDiagramData data);
		public void SetEmptyIcon();
		public void SetSelectBadge(bool isSelect);
		public void OnCellPressed();
		public void OnCellLongPressed();
	}
}
