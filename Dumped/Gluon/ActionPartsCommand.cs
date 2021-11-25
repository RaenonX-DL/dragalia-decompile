using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsCommand : ActionParts
	{
		private readonly CommandData _partsData;

		private ChangeTexture[] _chgTex;

		private SkinnedMeshRenderer[] _skinMeshRenderers;

		private bool _isPreventRecursion;

		private int _attachKey;

		public CommandData.CharacterCommand command => default(CommandData.CharacterCommand);

		public bool onoff => default(bool);

		public ActionPartsCommand(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		protected override bool CanGuarantee(bool flag)
		{
			return default(bool);
		}

		private void ProcCommand(CharacterBase character, CommandData.CharacterCommand cmd)
		{
		}

		private void ProcChangeMeshTexture()
		{
		}

		private void ProcRegisterPosition()
		{
		}

		private void ProcRegisterMultiPosition()
		{
		}

		private void AttachObject(CharacterBase chara)
		{
		}

		private void SetVisibleAttachObject()
		{
		}

		private void SwitchWeaponSkin()
		{
		}

		public void ProcAllUnitInvincible(bool onoff)
		{
		}

		private void ProcDisplayMyHpToPartsUI()
		{
		}

		public void ProcDropDp(int dp)
		{
		}

		public int GetActionConditionId()
		{
			return default(int);
		}
	}
}
