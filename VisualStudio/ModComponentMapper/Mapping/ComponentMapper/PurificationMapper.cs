﻿using ModComponentAPI;

namespace ModComponentMapper.ComponentMapper
{
	internal static class PurificationMapper
	{
		internal static void Configure(ModComponent modComponent)
		{
			ModPurificationComponent modPurification = modComponent.TryCast<ModPurificationComponent>();
			if (modPurification == null) return;

			PurifyWater purificationItem = ModComponentUtils.ComponentUtils.GetOrCreateComponent<PurifyWater>(modPurification);
			purificationItem.m_LocalizedProgressBarMessage = new LocalizedString() { m_LocalizationID = modPurification.ProgressBarLocalizationID };
			purificationItem.m_ProgressBarDurationSeconds = modPurification.ProgressBarDurationSeconds;
			purificationItem.m_PurifyAudio = modPurification.PurifyAudio;
			purificationItem.m_LitersPurify = modPurification.LitersPurify;
		}
	}
}
