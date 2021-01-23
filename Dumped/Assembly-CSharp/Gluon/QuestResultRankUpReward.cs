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
	public class QuestResultRankUpReward : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text beforeNumText;
		[SerializeField]
		private UnityEngine.UI.Text afterNumText;
	
		// Nested types
		public enum plantUp
		{
			plantNumUp = 0,
			plantLevlUp = 1
		}
	
		// Constructors
		public QuestResultRankUpReward();
	
		// Methods
		public void SetUp(plantUp en, int beforeNum, int afterNum);
	}
}
