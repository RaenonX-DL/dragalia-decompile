/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AmuletInfoCommonListCell : CommonIconListCell
	{
		// Fields
		public const float amuletCellWideWidth = 284f;
		public const float amuletCellWideHieght = 186f;
		[SerializeField]
		private Transform iconParentTransform;
		[SerializeField]
		private Transform cellBaseTransform;
		[SerializeField]
		private UnityEngine.UI.Text crestName;
		[SerializeField]
		private UnityEngine.UI.Text hpParamText;
		[SerializeField]
		private UnityEngine.UI.Text atkParamText;
		[SerializeField]
		private UnityEngine.UI.Text plusParamText;
		[SerializeField]
		private UnityEngine.UI.Text buildupText;
		[SerializeField]
		private UnityEngine.UI.Text abilityLabelText;
		[SerializeField]
		private UnityEngine.UI.Text equipLabelText;
		[SerializeField]
		private GameObject equipLabelObject;
		[SerializeField]
		private GameObject abilityLabelObject;
		[SerializeField]
		private Badge growBadge;
		private List<int> abilityIdList;
	
		// Constructors
		public AmuletInfoCommonListCell();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public override void UpdateContent(CommonIconListCellData data);
		public override void LoadUnitIcon();
	}
}
