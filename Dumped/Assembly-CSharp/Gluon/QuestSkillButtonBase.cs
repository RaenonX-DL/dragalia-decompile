/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkillButtonBase : FastUpdateMonoBehaviour
	{
		// Nested types
		[Serializable]
		public class CreateIconParam
		{
			// Fields
			[SerializeField]
			[Tooltip]
			public InGameUIConst.QuestSkillType type;
			[SerializeField]
			[Tooltip]
			public string[] iconNames;
			[SerializeField]
			[Tooltip]
			public bool unlimited;
			[SerializeField]
			[Tooltip]
			public int count;
			[SerializeField]
			[Tooltip]
			public ReadyAnimType readyAnimType;
			[SerializeField]
			[Tooltip]
			public bool changeAnim;
	
			// Constructors
			public CreateIconParam();
		}
	
		[Serializable]
		public class CreateButtonParam
		{
			// Fields
			[SerializeField]
			[Tooltip]
			public InGameUIConst.QuestSkillType type;
			[SerializeField]
			[Tooltip]
			public CreateIconParam[] iconParams;
	
			// Constructors
			public CreateButtonParam();
		}
	
		public class ManagementIconData
		{
			// Fields
			[CompilerGenerated]
			private string _Name_k__BackingField;
			[CompilerGenerated]
			private Material _Material_k__BackingField;
			[CompilerGenerated]
			private Sprite _Sprite_k__BackingField;
			[CompilerGenerated]
			private Material _ChangeAnimMaterial_k__BackingField;
			[CompilerGenerated]
			private Sprite _ChangeAnimSprite_k__BackingField;
			[CompilerGenerated]
			private bool _IsTimer_k__BackingField;
			[CompilerGenerated]
			private bool _IsValue_k__BackingField;
	
			// Properties
			public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Material Material { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Sprite Sprite { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Material ChangeAnimMaterial { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Sprite ChangeAnimSprite { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsTimer { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public ManagementIconData();
	
			// Methods
			~ManagementIconData();
			public void Setup(Material mtrl, string name, bool isLeft);
			public void Destroy();
			public void SetIconLayout(bool isLeft);
		}
	
		public class ManagementMultipleIconData
		{
			// Fields
			public int enableCount;
			public bool isUnlimited;
			public bool isDisplay;
			public bool isValidate;
			public int lastIconIndex;
			public float lastIconRate;
			public float targetIconRateManual;
			public bool isIconRateManual;
			public ReadyAnimType readyAnimType;
			public bool isChangeAnim;
			public ManagementIconData[] iconDatas;
			public Action onClick;
	
			// Constructors
			public ManagementMultipleIconData();
	
			// Methods
			~ManagementMultipleIconData();
			public void Reset();
			public void CopyTo(ManagementMultipleIconData data);
			public void DestroyIcon();
			public void SetIconLayout(bool isLeft);
		}
	
		public class ManagementMultipleButtonData
		{
			// Fields
			public int buttonType;
			public bool isDisplay;
			public ManagementMultipleIconData[] buttonDatas;
	
			// Constructors
			public ManagementMultipleButtonData();
		}
	
		public enum ReadyAnimType
		{
			None = 0,
			Normal = 1,
			FrameOnly = 2,
			BlinkOnly = 3
		}
	
		// Constructors
		public QuestSkillButtonBase();
	
		// Methods
		public virtual void Show(bool isForce = false, bool isImmediate = false);
		public virtual void Hide(bool isForce = false, bool isImmediate = false);
		public virtual bool ApplyIcon(InGameUIConst.QuestSkillType type);
		public virtual bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager);
		public virtual bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true);
		public virtual bool ChangeIcon(int buttonIndex, int iconIndex, bool isForce, bool isFlashAnim = true);
		public virtual int GetIconNum();
		public virtual int GetIconNum(int buttonIndex);
		public virtual int GetIconIndex();
		public virtual int GetIconIndex(int buttonIndex);
		public virtual void SetIconRateManual(float rate, bool isForce = false);
		public virtual void SetIconRateManual(int buttonIndex, float rate, bool isForce = false);
		public virtual float GetIconRate();
		public virtual float GetIconRate(int buttonIndex);
		public virtual void Visible(bool b);
		public virtual bool IsVisible();
		public virtual void Validate(bool b, bool force = false);
		public virtual int GetCount();
		public virtual int GetMaxCount();
		public virtual void SetCount(int n);
		public virtual void SetCount(int buttonType, int n);
		public virtual void SetUnlimited();
		public virtual bool IsUnlimited();
		public virtual void ChangeButton(int buttonType, bool isImmediate = false);
		public virtual int GetButtonType();
		public virtual void SetReadyAnim(ReadyAnimType type);
		public virtual bool IsReadyAnim();
		public virtual void SetupReadyAnim(Material frameMat);
		public virtual void SetVisibleReadyAnim(bool b);
		public virtual bool IsActiveReadyAnim();
		public virtual void OnUpdateReadyAnimFlash(float value);
		public virtual void SetChangeAnim();
		public virtual bool IsChangeAnim();
		public virtual void SetOnClick(Action onClick);
		public virtual void SetOnClick(int buttonType, Action onClick);
		public virtual void CopyData(ManagementMultipleIconData data);
		public virtual void CopyDara(ManagementMultipleButtonData data);
		public virtual void ApplyData(ManagementMultipleIconData data);
		public virtual void ApplyData(ManagementMultipleButtonData data);
	}
}
