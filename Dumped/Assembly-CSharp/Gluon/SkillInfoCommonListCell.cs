/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillInfoCommonListCell : CommonIconListCell
	{
		// Fields
		[SerializeField]
		private Transform iconParentTransform;
		[SerializeField]
		private UnityEngine.UI.Text skillName;
		[SerializeField]
		private UnityEngine.UI.Text skillDetail;
		[SerializeField]
		private GameObject blackMaskObject;
		[SerializeField]
		private GameObject effectBaseObject;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public FlRoot flRoot;
			public GameObject releaseEffectObject;
			public Action endCallBack;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _PlayUnlockSkillEffect_b__0();
			internal void _PlayUnlockSkillEffect_b__1();
		}
	
		// Constructors
		public SkillInfoCommonListCell();
	
		// Methods
		protected override void Start();
		public override void UpdateContent(CommonIconListCellData data);
		public void OmitTextWithEllipsis(UnityEngine.UI.Text text);
		public override void LoadUnitIcon();
		public void PlayUnlockSkillEffect(Action endCallBack = null);
	}
}
