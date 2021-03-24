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
	public class QuestResultBattleRoyalCenterPart : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text killCountText;
		public UnityEngine.UI.Text assistCountText;
		public Transform flashPos;
		private const string prefabPath = "Prefabs/OutGame/QuestResult/QuestResultBattleRoyalCenterPart";
	
		// Constructors
		public QuestResultBattleRoyalCenterPart();
	
		// Methods
		public static QuestResultBattleRoyalCenterPart Create(Transform parent);
		private void Start();
	}
}
