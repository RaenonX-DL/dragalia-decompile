using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum CuttTimelineKeyDataType
	{
		CameraPos,
		CameraLookAt,
		CameraFov,
		CameraRoll,
		HandShake,
		Event,
		CharaMotionSequecne,
		CameraSwitcher,
		CameraLayer,
		FloorColor,
		CuttEvent,
		Fade,
		PostBlur,
		SunShafts,
		Bloom,
		DofCtrl,
		ColorAdjustment,
		PostFilm,
		ImageEffect,
		Fog,
		RichShader,
		SceneObject,
		Material,
		Effect,
		SoundFilter,
		Sound,
		Flash,
		CharacterTransform,
		CharacterMotion,
		CharacterEye,
		CharacterMouth,
		CharacterGameObject,
		CharacterRich,
		Max
	}
}
