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
	public class MonsterHeaderBase : MonoBehaviour
	{
		// Fields
		public Image elementIcon;
		public Image rarityIcon;
		public UnityEngine.UI.Text monsterName;
	
		// Constructors
		public MonsterHeaderBase();
	
		// Methods
		public void SetElementIcon(ElementalType type);
		public void SetMonsterName(string name);
		public void SetEnableRareIcon(bool enable);
	}
}
