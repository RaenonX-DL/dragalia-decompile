/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerBuffUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private SpriteRenderer[] buffImage;
		[SerializeField]
		private SpriteRenderer[] buffCountImage10;
		[SerializeField]
		private SpriteRenderer[] buffCountImage01;
		[SerializeField]
		private SpriteRenderer[] debuffImage;
		[SerializeField]
		private SpriteRenderer[] debuffCountImage10;
		[SerializeField]
		private SpriteRenderer[] debuffCountImage01;
		private CharacterBase character;
	
		// Constructors
		public PlayerBuffUI();
	
		// Methods
		private void Start();
		public void SetCharacter(CharacterBase chara);
		public override void FastUpdate();
	}
}
