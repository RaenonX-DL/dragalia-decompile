/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharangeBonusPlate : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image[] treasureBoxClosedImages;
		[SerializeField]
		private Image[] treasureBoxOpenedImages;
		[SerializeField]
		protected Image completeImage;
		[SerializeField]
		protected UnityEngine.UI.Text resetText;
	
		// Constructors
		public CharangeBonusPlate();
	
		// Methods
		public void SetBonusInformation(QuestEventMenuElement eventMenuElement);
		private void SetBonusBoxes(int openedCount, int maxCount);
	}
}
