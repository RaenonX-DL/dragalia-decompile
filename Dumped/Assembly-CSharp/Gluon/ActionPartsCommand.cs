/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsCommand : ActionParts
	{
		// Fields
		private readonly CommandData _partsData;
		private ChangeTexture[] _chgTex;
		private SkinnedMeshRenderer[] _skinMeshRenderers;
		private bool _isPreventRecursion;
		private int _attachKey;
	
		// Properties
		public CommandData.CharacterCommand command { get; }
		public bool onoff { get; }
	
		// Constructors
		public ActionPartsCommand(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		protected override bool CanGuarantee(bool flag);
		private void ProcCommand(CharacterBase character, CommandData.CharacterCommand cmd);
		private void ProcChangeMeshTexture();
		private void ProcRegisterPosition();
		private void ProcRegisterMultiPosition();
		private void AttachObject(CharacterBase chara);
		private void SetVisibleAttachObject();
		private void SwitchWeaponSkin();
		public void ProcAllUnitInvincible(bool onoff);
		private void ProcDisplayMyHpToPartsUI();
		public void ProcDropDp(int dp);
	}
}
