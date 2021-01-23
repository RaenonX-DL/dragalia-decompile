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
	public class BattleRoyalSkinCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject selectedMark;
		public RawImage icon;
		[CompilerGenerated]
		private int _skinId_k__BackingField;
		private Action<int> onDecided;
	
		// Properties
		public int skinId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public BattleRoyalSkinCell();
	
		// Methods
		public void Setup(int skinId, Action<int> onDecided);
		public void SetSelectedState(bool v);
		public void OnPressed();
	}
}
