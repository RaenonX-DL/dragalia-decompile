using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public interface SimpleCharacterFacialControlInterface
	{
		void Setup(List<Material> materialList);

		void SetEnable(bool f);

		bool GetEnable();

		void LateUpdate();

		void SetTrigger(string triggerName);

		void SetFaceEye(CharaFaceEye faceEye);

		void SetFaceMouth(CharaFaceMouth faceMouth);
	}
}
