/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailAlbumMemoryButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Button button;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private UnitDetailAlbumMemoryPopup.MemoryType memoryType;
		private UnityAction<UnitDetailAlbumMemoryPopup.MemoryType> onButtonPressed;
		private CharaDataElement charaData;
	
		// Constructors
		public UnitDetailAlbumMemoryButton();
	
		// Methods
		public void InitContents(CharaDataElement master, UnitDetailAlbumMemoryPopup.MemoryType type, string str, UnityAction<UnitDetailAlbumMemoryPopup.MemoryType> onCallback);
		public bool IsAwakingCondition();
		public bool IsAwakingSecondCondition();
		public void OnButtonPressed();
		public void IsInteractable(bool interactable);
	}
}
