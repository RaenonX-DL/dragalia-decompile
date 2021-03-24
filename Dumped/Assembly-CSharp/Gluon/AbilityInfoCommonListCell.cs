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
	public class AbilityInfoCommonListCell : CommonIconListCell
	{
		// Fields
		[SerializeField]
		private Transform iconParentTransform;
		[SerializeField]
		private UnityEngine.UI.Text abilityName;
		[SerializeField]
		private UnityEngine.UI.Text abilityDetail;
		[SerializeField]
		private GameObject blackMaskObject;
	
		// Constructors
		public AbilityInfoCommonListCell();
	
		// Methods
		protected override void Start();
		public override void UpdateContent(CommonIconListCellData data);
		public override void LoadUnitIcon();
	}
}
