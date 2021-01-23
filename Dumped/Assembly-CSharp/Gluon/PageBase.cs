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
	public class PageBase : AnimationUIObject
	{
		// Fields
		[CompilerGenerated]
		private SceneBase _parentScene_k__BackingField;
		[CompilerGenerated]
		private SceneNameDefine.PageName _pageName_k__BackingField;
		[SerializeField]
		private Button backButton;
		public bool removeTouchGuardOnActive;
	
		// Properties
		public SceneBase parentScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SceneNameDefine.PageName pageName { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PageBase();
	
		// Methods
		protected override void OnDestroy();
		public virtual void OnPageBecomeActive(object data);
		public virtual bool IsLoading();
		public virtual void OnPageEnterAnimationEnded();
		public virtual void OnPageBecomeInActive();
		public virtual void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform = null, AnimationPattern exitPattern = AnimationPattern.Pattern_1, AnimationPattern enterPattern = AnimationPattern.Pattern_1, Action<PageBase> onLoaded = null, object data = null, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		public virtual void ShowPage(bool toShow);
		public void RegisterBackKey(Canvas canvas, Button backButton);
		public void RemoveBackKey(Canvas canvas, Button backButton);
	}
}
