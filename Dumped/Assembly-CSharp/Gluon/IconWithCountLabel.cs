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
	public class IconWithCountLabel : MonoBehaviour
	{
		// Fields
		public RawImage iconMaterial;
		[SerializeField]
		private Image needsNode;
		[SerializeField]
		private Image owneNode;
		[SerializeField]
		public UnityEngine.UI.Text needCounttext;
		[SerializeField]
		public UnityEngine.UI.Text currentCoundtext;
		[SerializeField]
		private Image tradeIcon;
		private bool canTrade;
		private int materialId;
		private readonly Color insufficientTextColor;
		private readonly Color insufficientRequiredColor;
		private readonly Color insufficientHavingColor;
		private readonly Color sufficientRequiredColor;
		private readonly Color sufficientHavingColor;
		private UnityEngine.UI.Text[] displayTextList;
	
		// Constructors
		public IconWithCountLabel();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetContent(int materialData, int needCount);
		private void SetLabelColor(bool isSufficient);
		public void CreateItemDetailPopup();
	}
}
