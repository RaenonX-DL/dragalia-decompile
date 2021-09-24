/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemSentPresentBoxCtrl : TableViewController<Gluon.ItemSentPresentBoxCellData>
	{
		// Fields
		public float cellHeight;
		[SerializeField]
		private AnimationListOneCol listAnimation;
		[SerializeField]
		private float delayFrame;
	
		// Constructors
		public ItemSentPresentBoxCtrl();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<ItemSentPresentBoxCellData> cellList);
		protected override TableViewCell<ItemSentPresentBoxCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void UpdateReceiveButtonInformation();
		public void StartEnterAnimation();
		public void StartExitAnimation();
	}
}
