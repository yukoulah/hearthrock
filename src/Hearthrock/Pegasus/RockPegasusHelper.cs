﻿// <copyright file="RockPegasusHelper.cs" company="https://github.com/yangyuan">
//     Copyright (c) The Hearthrock Project. All rights reserved.
// </copyright>

namespace Hearthrock.Pegasus
{
    using Hearthrock.Contracts;

    using PegasusShared;
    using System;

    public static class RockPegasusHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameMode"></param>
        /// <returns></returns>
        public static GameType GetGameType(RockGameMode gameMode)
        {
            switch(gameMode)
            {
                case RockGameMode.NormalPractice:
                case RockGameMode.ExpertPractice:
                    return GameType.GT_VS_AI;
                case RockGameMode.Casual:
                case RockGameMode.WildCasual:
                    return GameType.GT_CASUAL;
                case RockGameMode.Ranked:
                case RockGameMode.WildRanked:
                    return GameType.GT_RANKED;
                default:
                    return GameType.GT_UNKNOWN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameMode"></param>
        /// <returns></returns>
        public static FormatType GetFormatType(RockGameMode gameMode)
        {
            switch (gameMode)
            {
                case RockGameMode.Casual:
                case RockGameMode.Ranked:
                    return FormatType.FT_STANDARD;
                case RockGameMode.NormalPractice:
                case RockGameMode.ExpertPractice:
                case RockGameMode.WildCasual:
                case RockGameMode.WildRanked:
                    return FormatType.FT_WILD;
                default:
                    return FormatType.FT_UNKNOWN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameMode"></param>
        /// <returns></returns>
        public static int GetPracticeMissionId(int index)
        {
            ScenarioDbId[] AI_EXPERT = {
                ScenarioDbId.PRACTICE_EXPERT_MAGE,
                ScenarioDbId.PRACTICE_EXPERT_WARLOCK,
                ScenarioDbId.PRACTICE_EXPERT_HUNTER,
                ScenarioDbId.PRACTICE_EXPERT_ROGUE,
                ScenarioDbId.PRACTICE_EXPERT_PRIEST,
                ScenarioDbId.PRACTICE_EXPERT_WARRIOR,
                ScenarioDbId.PRACTICE_EXPERT_DRUID,
                ScenarioDbId.PRACTICE_EXPERT_PALADIN,
                ScenarioDbId.PRACTICE_EXPERT_SHAMAN
            };

            ScenarioDbId ret;

            if (index <= 0 || index > AI_EXPERT.Length)
            {
                Random random = new Random();
                ret = AI_EXPERT[random.Next(AI_EXPERT.Length)];
            }
            else
            {
                ret = AI_EXPERT[index - 1];
            }

            return (int)ret;
        }
    }
}
