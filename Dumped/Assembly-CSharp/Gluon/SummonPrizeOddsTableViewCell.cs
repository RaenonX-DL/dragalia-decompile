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
	public class SummonPrizeOddsTableViewCell : TableViewCell<Gluon.SummonPrizeOddsTableViewData>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text prizeName;
		[SerializeField]
		private UnityEngine.UI.Text num;
		[SerializeField]
		private UnityEngine.UI.Text percentage;
		[SerializeField]
		private UnityEngine.UI.Text captionText;
		[SerializeField]
		private UnityEngine.UI.Text captionPercentage;
		[SerializeField]
		private GameObject normalNode;
		[SerializeField]
		private GameObject captionNode;
		[SerializeField]
		private GameObject titleNode;
		public const float captionHeight = 60f;
		public const float titleHeight = 250f;
		public const float normalHeight = 32f;
	
		// Constructors
		public SummonPrizeOddsTableViewCell();
	
		// Methods
		public override void UpdateContent(SummonPrizeOddsTableViewData data);
	}
}
