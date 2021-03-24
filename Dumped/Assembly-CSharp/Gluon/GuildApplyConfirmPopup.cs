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
	public class GuildApplyConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject[] applyContents;
		public GameObject[] entryContents;
		public Transform dataNode;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildApplyConfirmPopup";
		private GuildInfoCellData data;
		private Action onApply;
	
		// Constructors
		public GuildApplyConfirmPopup();
	
		// Methods
		public static GuildApplyConfirmPopup Create(GuildInfoCellData data, Action onApply);
		protected override void Start();
		public void OnApply();
	}
}
