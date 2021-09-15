/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HumanMarkWinUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text labelText;
		[SerializeField]
		private GameObject gobjLabel;
		private CharacterBase owner;
		private RectTransform rootRt;
		private VisibleUIObject labelVisible;
		private VisibleUIObject rootVisible;
	
		// Constructors
		public HumanMarkWinUI();
	
		// Methods
		public void Initialize(CharacterBase player);
		private void LateUpdate();
		public override void UpdatePosition(bool interpolation = true);
		private void InvisibleAll();
		private Vector2 GetScreenPos(CharacterBase chara);
	}
}
