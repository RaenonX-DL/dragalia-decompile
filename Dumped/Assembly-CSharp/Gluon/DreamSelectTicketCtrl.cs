﻿/*
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
	public class DreamSelectTicketCtrl : TableViewController<Gluon.DreamSelectTicketCtrl.DreamSelectItemCellData>
	{
		// Fields
		private const float cellHeight = 148f;
		[SerializeField]
		private AnimationListOneCol listAnimation;
		[SerializeField]
		private float delayFrame;
		public GiftType giftType;
		private Action<GiftType, int> onSummonButtonClick;
	
		// Nested types
		public class DreamSelectItemCellData
		{
			// Fields
			public int entity_id;
			public int entity_type;
	
			// Constructors
			public DreamSelectItemCellData();
		}
	
		// Constructors
		public DreamSelectTicketCtrl();
	
		// Methods
		protected override void Awake();
		public void Init(List<ulong> cellData, Action<GiftType, int> onClick);
		public void ReloadContents(List<ulong> cellData);
		protected override TableViewCell<DreamSelectItemCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void StartEnterAnimation();
		public void StartExitAnimation();
	}
}
