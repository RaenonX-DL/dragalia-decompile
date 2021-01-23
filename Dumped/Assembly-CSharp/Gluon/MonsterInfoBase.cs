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
	public class MonsterInfoBase : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text killCount;
		public UnityEngine.UI.Text monsterType;
		public UnityEngine.UI.Text basicFlavor;
		public UnityEngine.UI.Text addFlavor;
		public UnityEngine.UI.Text pieceCount;
		public Button previewButton;
		private const int maxKillCount = 99999999;
	
		// Constructors
		public MonsterInfoBase();
	
		// Methods
		public void SetKillCount(int count);
		public void SetMonsterType(string typeName);
		public void SetBasicFlavor(string text);
		public void SetAddFlavor(string text);
		public void SetPieceCount(int nowCount, int maxCount, MonsterDetailStep step);
		public void SetPreviewButton(MonsterDetailStep step, UnityAction action);
	}
}
