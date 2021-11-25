using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsBuffFieldAttachment : ActionParts
	{
		private readonly BuffFieldAttachmentData _partsData;

		private ActionPartsBulletHitAttribute hitAttr;

		private string hitAttrLabel;

		private CollisionHitAttribute[] _hitAttributes;

		public ActionPartsBuffFieldAttachment(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected string GetHitAttributeLabel()
		{
			return null;
		}

		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label)
		{
			return null;
		}

		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override void OnStart()
		{
		}

		protected void CopyHitAttrGeometry(CollisionHitAttribute other, int i)
		{
		}
	}
}
