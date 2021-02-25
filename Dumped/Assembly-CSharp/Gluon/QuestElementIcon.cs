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
	public class QuestElementIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image[] elementImageArray;
		[SerializeField]
		private Color iconGrayColor;
		private int activeIndex;
	
		// Constructors
		public QuestElementIcon();
	
		// Methods
		public void SetupQuestElementIcon(int questId, bool isParty2 = false, bool isGray = false);
		public void SetGradientShader(QuestListCellShaderExchanger shaderExchanger);
	}
}
