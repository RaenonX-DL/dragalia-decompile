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
	public class BattleRoyalJobCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject invalidMask;
		public RawImage weaponIcon;
		public UnityEngine.UI.Text weaponText;
		public Graphic icon;
		public GameObject randomGO;
		private WeaponType weaponType;
		private int charaId;
		private bool isValid;
		private BattleRoyalSelectJobPopup.Mode mode;
		private Action<WeaponType, bool> onDecided;
	
		// Constructors
		public BattleRoyalJobCell();
	
		// Methods
		public void Setup(BattleRoyalSelectJobPopup.Mode mode, bool isValid, WeaponType weaponType, int charaId, bool isRandom, Action<WeaponType, bool> onDecided);
		public void OnPressed();
	}
}
