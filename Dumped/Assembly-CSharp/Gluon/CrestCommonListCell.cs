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
	public class CrestCommonListCell : CommonIconListCell
	{
		// Fields
		public const float cellHieght = 168f;
		public const float cellWidth = 284f;
		[SerializeField]
		private Transform cellBaseTransform;
		[SerializeField]
		private Transform outButtonTransform;
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private GameObject noneUnionGameObject;
		[SerializeField]
		private UnityEngine.UI.Text releaseCount;
		[SerializeField]
		private UnityEngine.UI.Text ability;
		[SerializeField]
		private Transform iconParentTransform;
		[SerializeField]
		private GameObject eventBonusIcon;
		[SerializeField]
		private GameObject equipCountGO;
		[SerializeField]
		private UnityEngine.UI.Text equipCountText;
		private Button button;
	
		// Constructors
		public CrestCommonListCell();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public override void UpdateContent(CommonIconListCellData data);
		public void SetEquipRemainingCount(bool selected, int equippedCount, int equippableCount, bool isSupportFriend);
		public override void LoadUnitIcon();
	}
}
