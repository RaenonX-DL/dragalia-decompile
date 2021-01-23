/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class IconStatus : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image charaIcon;
		[SerializeField]
		private Button button;
		public UnityAction<int, int, int> onClickCallback;
		private int index;
		private int iconId;
		private int iconType;
		private PointerEventHandler peh;
	
		// Constructors
		public IconStatus();
	
		// Methods
		public void Awake();
		public void Initialize(int index, int id, EnumIconType type = EnumIconType.Chara);
		public void BlankIcon(EnumIconType type = EnumIconType.Chara);
		private void OnIconButtonPressed();
	}
}
