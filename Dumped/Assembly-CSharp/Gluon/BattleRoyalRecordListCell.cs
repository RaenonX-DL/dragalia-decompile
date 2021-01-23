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
	public class BattleRoyalRecordListCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Graphic icon;
		public Graphic jobIcon;
		public UnityEngine.UI.Text rankText;
		public UnityEngine.UI.Text killCountText;
		public UnityEngine.UI.Text dateText;
	
		// Constructors
		public BattleRoyalRecordListCell();
	
		// Methods
		public void Setup(BattleRoyalModel.BattleRecord record);
	}
}
