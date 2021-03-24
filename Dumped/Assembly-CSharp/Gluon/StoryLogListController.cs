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
	[RequireComponent]
	public class StoryLogListController : TableViewController<Gluon.StoryLogListCellData>
	{
		// Fields
		public const float fontHeight = 32f;
		[SerializeField]
		private RectTransform scrollContentRect;
	
		// Constructors
		public StoryLogListController();
	
		// Methods
		protected override void Start();
		private void LoadData();
		protected override float GetCellHeightAtIndex(int index);
	}
}
