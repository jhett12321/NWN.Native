//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public enum VMCommand {
  Random,
  PrintString,
  PrintFloat,
  FloatToString,
  PrintInteger,
  PrintObject,
  AssignCommand,
  DelayCommand,
  ExecuteScript,
  ClearAllActions,
  SetFacing,
  SetCalendar,
  SetTime,
  GetCalendarYear,
  GetCalendarMonth,
  GetCalendarDay,
  GetTimeHour,
  GetTimeMinute,
  GetTimeSecond,
  GetTimeMillisecond,
  ActionRandomWalk,
  ActionMoveToLocation,
  ActionMoveToObject,
  ActionMoveAwayFromObject,
  GetArea,
  GetEnteringObject,
  GetExitingObject,
  GetPosition,
  GetFacing,
  GetItemPossessor,
  GetItemPossessedBy,
  CreateItemOnObject,
  ActionEquipItem,
  ActionUnequipItem,
  ActionPickUpItem,
  ActionPutDownItem,
  GetLastAttacker,
  ActionAttack,
  GetNearestCreature,
  ActionSpeakString,
  ActionPlayAnimation,
  GetDistanceToObject,
  GetIsObjectValid,
  ActionOpenDoor,
  ActionCloseDoor,
  SetCameraFacing,
  PlaySound,
  GetSpellTargetObject,
  ActionCastSpellAtObject,
  GetCurrentHitPoints,
  GetMaxHitPoints,
  GetLocalInt,
  GetLocalFloat,
  GetLocalString,
  GetLocalObject,
  SetLocalInt,
  SetLocalFloat,
  SetLocalString,
  SetLocalObject,
  GetStringLength,
  GetStringUpperCase,
  GetStringLowerCase,
  GetStringRight,
  GetStringLeft,
  InsertString,
  GetSubString,
  FindSubString,
  fabs,
  cos,
  sin,
  tan,
  acos,
  asin,
  atan,
  log,
  pow,
  sqrt,
  abs,
  EffectHeal,
  EffectDamage,
  EffectAbilityIncrease,
  EffectDamageResistance,
  EffectResurrection,
  EffectSummonCreature,
  GetCasterLevel,
  GetFirstEffect,
  GetNextEffect,
  RemoveEffect,
  GetIsEffectValid,
  GetEffectDurationType,
  GetEffectSubType,
  GetEffectCreator,
  IntToString,
  GetFirstObjectInArea,
  GetNextObjectInArea,
  d2,
  d3,
  d4,
  d6,
  d8,
  d10,
  d12,
  d20,
  d100,
  VectorMagnitude,
  GetMetaMagicFeat,
  GetObjectType,
  GetRacialType,
  FortitudeSave,
  ReflexSave,
  WillSave,
  GetSpellSaveDC,
  MagicalEffect,
  SupernaturalEffect,
  ExtraordinaryEffect,
  EffectACIncrease,
  GetAC,
  EffectSavingThrowIncrease,
  EffectAttackIncrease,
  EffectDamageReduction,
  EffectDamageIncrease,
  RoundsToSeconds,
  HoursToSeconds,
  TurnsToSeconds,
  GetLawChaosValue,
  GetGoodEvilValue,
  GetAlignmentLawChaos,
  GetAlignmentGoodEvil,
  GetFirstObjectInShape,
  GetNextObjectInShape,
  EffectEntangle,
  SignalEvent,
  EventUserDefined,
  EffectDeath,
  EffectKnockdown,
  ActionGiveItem,
  ActionTakeItem,
  VectorNormalize,
  EffectCurse,
  GetAbilityScore,
  GetIsDead,
  PrintVector,
  Vector,
  SetFacingPoint,
  AngleToVector,
  VectorToAngle,
  TouchAttackMelee,
  TouchAttackRanged,
  EffectParalyze,
  EffectSpellImmunity,
  EffectDeaf,
  GetDistanceBetween,
  SetLocalLocation,
  GetLocalLocation,
  EffectSleep,
  GetItemInSlot,
  EffectCharmed,
  EffectConfused,
  EffectFrightened,
  EffectDominated,
  EffectDazed,
  EffectStunned,
  SetCommandable,
  GetCommandable,
  EffectRegenerate,
  EffectMovementSpeedIncrease,
  GetHitDice,
  ActionForceFollowObject,
  GetTag,
  ResistSpell,
  GetEffectType,
  EffectAreaOfEffect,
  GetFactionEqual,
  ChangeFaction,
  GetIsListening,
  SetListening,
  SetListenPattern,
  TestStringAgainstPattern,
  GetMatchedSubstring,
  GetMatchedSubstringsCount,
  EffectVisualEffect,
  GetFactionWeakestMember,
  GetFactionStrongestMember,
  GetFactionMostDamagedMember,
  GetFactionLeastDamagedMember,
  GetFactionGold,
  GetFactionAverageReputation,
  GetFactionAverageGoodEvilAlignment,
  GetFactionAverageLawChaosAlignment,
  GetFactionAverageLevel,
  GetFactionAverageXP,
  GetFactionMostFrequentClass,
  GetFactionWorstAC,
  GetFactionBestAC,
  ActionSit,
  GetListenPatternNumber,
  ActionJumpToObject,
  GetWaypointByTag,
  GetTransitionTarget,
  EffectLinkEffects,
  GetObjectByTag,
  AdjustAlignment,
  ActionWait,
  SetAreaTransitionBMP,
  ActionStartConversation,
  ActionPauseConversation,
  ActionResumeConversation,
  EffectBeam,
  GetReputation,
  AdjustReputation,
  GetSittingCreature,
  GetGoingToBeAttackedBy,
  EffectSpellResistanceIncrease,
  GetLocation,
  ActionJumpToLocation,
  Location,
  ApplyEffectAtLocation,
  GetIsPC,
  FeetToMeters,
  YardsToMeters,
  ApplyEffectToObject,
  SpeakString,
  GetSpellTargetLocation,
  GetPositionFromLocation,
  GetAreaFromLocation,
  GetFacingFromLocation,
  GetNearestCreatureToLocation,
  GetNearestObject,
  GetNearestObjectToLocation,
  GetNearestObjectByTag,
  IntToFloat,
  FloatToInt,
  StringToInt,
  StringToFloat,
  ActionCastSpellAtLocation,
  GetIsEnemy,
  GetIsFriend,
  GetIsNeutral,
  GetPCSpeaker,
  GetStringByStrRef,
  ActionSpeakStringByStrRef,
  DestroyObject,
  GetModule,
  CreateObject,
  EventSpellCastAt,
  GetLastSpellCaster,
  GetLastSpell,
  GetUserDefinedEventNumber,
  GetSpellId,
  RandomName,
  EffectPoison,
  EffectDisease,
  EffectSilence,
  GetName,
  GetLastSpeaker,
  BeginConversation,
  GetLastPerceived,
  GetLastPerceptionHeard,
  GetLastPerceptionInaudible,
  GetLastPerceptionSeen,
  GetLastClosedBy,
  GetLastPerceptionVanished,
  GetFirstInPersistentObject,
  GetNextInPersistentObject,
  GetAreaOfEffectCreator,
  DeleteLocalInt,
  DeleteLocalFloat,
  DeleteLocalString,
  DeleteLocalObject,
  DeleteLocalLocation,
  EffectHaste,
  EffectSlow,
  ObjectToString,
  EffectImmunity,
  GetIsImmune,
  EffectDamageImmunityIncrease,
  GetEncounterActive,
  SetEncounterActive,
  GetEncounterSpawnsMax,
  SetEncounterSpawnsMax,
  GetEncounterSpawnsCurrent,
  SetEncounterSpawnsCurrent,
  GetModuleItemAcquired,
  GetModuleItemAcquiredFrom,
  SetCustomToken,
  GetHasFeat,
  GetHasSkill,
  ActionUseFeat,
  ActionUseSkill,
  GetObjectSeen,
  GetObjectHeard,
  GetLastPlayerDied,
  GetModuleItemLost,
  GetModuleItemLostBy,
  ActionDoCommand,
  EventConversation,
  SetEncounterDifficulty,
  GetEncounterDifficulty,
  GetDistanceBetweenLocations,
  GetReflexAdjustedDamage,
  PlayAnimation,
  TalentSpell,
  TalentFeat,
  TalentSkill,
  GetHasSpellEffect,
  GetEffectSpellId,
  GetCreatureHasTalent,
  GetCreatureTalentRandom,
  GetCreatureTalentBest,
  ActionUseTalentOnObject,
  ActionUseTalentAtLocation,
  GetGoldPieceValue,
  GetIsPlayableRacialType,
  JumpToLocation,
  EffectTemporaryHitpoints,
  GetSkillRank,
  GetAttackTarget,
  GetLastAttackType,
  GetLastAttackMode,
  GetMaster,
  GetIsInCombat,
  GetLastAssociateCommand,
  GiveGoldToCreature,
  SetIsDestroyable,
  SetLocked,
  GetLocked,
  GetClickingObject,
  SetAssociateListenPatterns,
  GetLastWeaponUsed,
  ActionInteractObject,
  GetLastUsedBy,
  GetAbilityModifier,
  GetIdentified,
  SetIdentified,
  SummonAnimalCompanion,
  SummonFamiliar,
  GetBlockingDoor,
  GetIsDoorActionPossible,
  DoDoorAction,
  GetFirstItemInInventory,
  GetNextItemInInventory,
  GetClassByPosition,
  GetLevelByPosition,
  GetLevelByClass,
  GetDamageDealtByType,
  GetTotalDamageDealt,
  GetLastDamager,
  GetLastDisarmed,
  GetLastDisturbed,
  GetLastLocked,
  GetLastUnlocked,
  EffectSkillIncrease,
  GetInventoryDisturbType,
  GetInventoryDisturbItem,
  GetHenchman,
  VersusAlignmentEffect,
  VersusRacialTypeEffect,
  VersusTrapEffect,
  GetGender,
  GetIsTalentValid,
  ActionMoveAwayFromLocation,
  GetAttemptedAttackTarget,
  GetTypeFromTalent,
  GetIdFromTalent,
  GetAssociate,
  AddHenchman,
  RemoveHenchman,
  AddJournalQuestEntry,
  RemoveJournalQuestEntry,
  GetPCPublicCDKey,
  GetPCIPAddress,
  GetPCPlayerName,
  SetPCLike,
  SetPCDislike,
  SendMessageToPC,
  GetAttemptedSpellTarget,
  GetLastOpenedBy,
  GetHasSpell,
  OpenStore,
  EffectTurned,
  GetFirstFactionMember,
  GetNextFactionMember,
  ActionForceMoveToLocation,
  ActionForceMoveToObject,
  GetJournalQuestExperience,
  JumpToObject,
  SetMapPinEnabled,
  EffectHitPointChangeWhenDying,
  PopUpGUIPanel,
  ClearPersonalReputation,
  SetIsTemporaryFriend,
  SetIsTemporaryEnemy,
  SetIsTemporaryNeutral,
  GiveXPToCreature,
  SetXP,
  GetXP,
  IntToHexString,
  GetBaseItemType,
  GetItemHasItemProperty,
  ActionEquipMostDamagingMelee,
  ActionEquipMostDamagingRanged,
  GetItemACValue,
  ActionRest,
  ExploreAreaForPlayer,
  ActionEquipMostEffectiveArmor,
  GetIsDay,
  GetIsNight,
  GetIsDawn,
  GetIsDusk,
  GetIsEncounterCreature,
  GetLastPlayerDying,
  GetStartingLocation,
  ChangeToStandardFaction,
  SoundObjectPlay,
  SoundObjectStop,
  SoundObjectSetVolume,
  SoundObjectSetPosition,
  SpeakOneLinerConversation,
  GetGold,
  GetLastRespawnButtonPresser,
  GetIsDM,
  PlayVoiceChat,
  GetIsWeaponEffective,
  GetLastSpellHarmful,
  EventActivateItem,
  MusicBackgroundPlay,
  MusicBackgroundStop,
  MusicBackgroundSetDelay,
  MusicBackgroundChangeDay,
  MusicBackgroundChangeNight,
  MusicBattlePlay,
  MusicBattleStop,
  MusicBattleChange,
  AmbientSoundPlay,
  AmbientSoundStop,
  AmbientSoundChangeDay,
  AmbientSoundChangeNight,
  GetLastKiller,
  GetSpellCastItem,
  GetItemActivated,
  GetItemActivator,
  GetItemActivatedTargetLocation,
  GetItemActivatedTarget,
  GetIsOpen,
  TakeGoldFromCreature,
  IsInConversation,
  EffectAbilityDecrease,
  EffectAttackDecrease,
  EffectDamageDecrease,
  EffectDamageImmunityDecrease,
  EffectACDecrease,
  EffectMovementSpeedDecrease,
  EffectSavingThrowDecrease,
  EffectSkillDecrease,
  EffectSpellResistanceDecrease,
  GetPlotFlag,
  SetPlotFlag,
  EffectInvisibility,
  EffectConcealment,
  EffectDarkness,
  EffectDispelMagicAll,
  EffectUltravision,
  EffectNegativeLevel,
  EffectPolymorph,
  EffectSanctuary,
  EffectTrueSeeing,
  EffectSeeInvisible,
  EffectTimeStop,
  EffectBlindness,
  GetIsReactionTypeFriendly,
  GetIsReactionTypeNeutral,
  GetIsReactionTypeHostile,
  EffectSpellLevelAbsorption,
  EffectDispelMagicBest,
  ActivatePortal,
  GetNumStackedItems,
  SurrenderToEnemies,
  EffectMissChance,
  GetTurnResistanceHD,
  GetCreatureSize,
  EffectDisappearAppear,
  EffectDisappear,
  EffectAppear,
  ActionUnlockObject,
  ActionLockObject,
  EffectModifyAttacks,
  GetLastTrapDetected,
  EffectDamageShield,
  GetNearestTrapToObject,
  GetDeity,
  GetSubRace,
  GetFortitudeSavingThrow,
  GetWillSavingThrow,
  GetReflexSavingThrow,
  GetChallengeRating,
  GetAge,
  GetMovementRate,
  GetFamiliarCreatureType,
  GetAnimalCompanionCreatureType,
  GetFamiliarName,
  GetAnimalCompanionName,
  ActionCastFakeSpellAtObject,
  ActionCastFakeSpellAtLocation,
  RemoveSummonedAssociate,
  SetCameraMode,
  GetIsResting,
  GetLastPCRested,
  SetWeather,
  GetLastRestEventType,
  StartNewModule,
  EffectSwarm,
  GetWeaponRanged,
  DoSinglePlayerAutoSave,
  GetGameDifficulty,
  SetTileMainLightColor,
  SetTileSourceLightColor,
  RecomputeStaticLighting,
  GetTileMainLight1Color,
  GetTileMainLight2Color,
  GetTileSourceLight1Color,
  GetTileSourceLight2Color,
  SetPanelButtonFlash,
  GetCurrentAction,
  SetStandardFactionReputation,
  GetStandardFactionReputation,
  FloatingTextStrRefOnCreature,
  FloatingTextStringOnCreature,
  GetTrapDisarmable,
  GetTrapDetectable,
  GetTrapDetectedBy,
  GetTrapFlagged,
  GetTrapBaseType,
  GetTrapOneShot,
  GetTrapCreator,
  GetTrapKeyTag,
  GetTrapDisarmDC,
  GetTrapDetectDC,
  GetLockKeyRequired,
  GetLockKeyTag,
  GetLockLockable,
  GetLockUnlockDC,
  GetLockLockDC,
  GetPCLevellingUp,
  GetHasFeatEffect,
  SetPlaceableIllumination,
  GetPlaceableIllumination,
  GetIsPlaceableObjectActionPossible,
  DoPlaceableObjectAction,
  GetFirstPC,
  GetNextPC,
  SetTrapDetectedBy,
  GetIsTrapped,
  EffectTurnResistanceDecrease,
  EffectTurnResistanceIncrease,
  PopUpDeathGUIPanel,
  SetTrapDisabled,
  GetLastHostileActor,
  ExportAllCharacters,
  MusicBackgroundGetDayTrack,
  MusicBackgroundGetNightTrack,
  WriteTimestampedLogEntry,
  GetModuleName,
  GetFactionLeader,
  SendMessageToAllDMs,
  EndGame,
  BootPC,
  ActionCounterSpell,
  AmbientSoundSetDayVolume,
  AmbientSoundSetNightVolume,
  MusicBackgroundGetBattleTrack,
  GetHasInventory,
  GetStrRefSoundDuration,
  AddToParty,
  RemoveFromParty,
  GetStealthMode,
  GetDetectMode,
  GetDefensiveCastingMode,
  GetAppearanceType,
  SpawnScriptDebugger,
  GetModuleItemAcquiredStackSize,
  DecrementRemainingFeatUses,
  DecrementRemainingSpellUses,
  GetResRef,
  EffectPetrify,
  CopyItem,
  EffectCutsceneParalyze,
  GetDroppableFlag,
  GetUseableFlag,
  GetStolenFlag,
  SetCampaignFloat,
  SetCampaignInt,
  SetCampaignVector,
  SetCampaignLocation,
  SetCampaignString,
  DestroyCampaignDatabase,
  GetCampaignFloat,
  GetCampaignInt,
  GetCampaignVector,
  GetCampaignLocation,
  GetCampaignString,
  CopyObject,
  DeleteCampaignVariable,
  StoreCampaignObject,
  RetrieveCampaignObject,
  EffectCutsceneDominated,
  GetItemStackSize,
  SetItemStackSize,
  GetItemCharges,
  SetItemCharges,
  AddItemProperty,
  RemoveItemProperty,
  GetIsItemPropertyValid,
  GetFirstItemProperty,
  GetNextItemProperty,
  GetItemPropertyType,
  GetItemPropertyDurationType,
  ItemPropertyAbilityBonus,
  ItemPropertyACBonus,
  ItemPropertyACBonusVsAlign,
  ItemPropertyACBonusVsDmgType,
  ItemPropertyACBonusVsRace,
  ItemPropertyACBonusVsSAlign,
  ItemPropertyEnhancementBonus,
  ItemPropertyEnhancementBonusVsAlign,
  ItemPropertyEnhancementBonusVsRace,
  ItemPropertyEnhancementBonusVsSAlign,
  ItemPropertyEnhancementPenalty,
  ItemPropertyWeightReduction,
  ItemPropertyBonusFeat,
  ItemPropertyBonusLevelSpell,
  ItemPropertyCastSpell,
  ItemPropertyDamageBonus,
  ItemPropertyDamageBonusVsAlign,
  ItemPropertyDamageBonusVsRace,
  ItemPropertyDamageBonusVsSAlign,
  ItemPropertyDamageImmunity,
  ItemPropertyDamagePenalty,
  ItemPropertyDamageReduction,
  ItemPropertyDamageResistance,
  ItemPropertyDamageVulnerability,
  ItemPropertyDarkvision,
  ItemPropertyDecreaseAbility,
  ItemPropertyDecreaseAC,
  ItemPropertyDecreaseSkill,
  ItemPropertyContainerReducedWeight,
  ItemPropertyExtraMeleeDamageType,
  ItemPropertyExtraRangeDamageType,
  ItemPropertyHaste,
  ItemPropertyHolyAvenger,
  ItemPropertyImmunityMisc,
  ItemPropertyImprovedEvasion,
  ItemPropertyBonusSpellResistance,
  ItemPropertyBonusSavingThrowVsX,
  ItemPropertyBonusSavingThrow,
  ItemPropertyKeen,
  ItemPropertyLight,
  ItemPropertyMaxRangeStrengthMod,
  ItemPropertyNoDamage,
  ItemPropertyOnHitProps,
  ItemPropertyReducedSavingThrowVsX,
  ItemPropertyReducedSavingThrow,
  ItemPropertyRegeneration,
  ItemPropertySkillBonus,
  ItemPropertySpellImmunitySpecific,
  ItemPropertySpellImmunitySchool,
  ItemPropertyThievesTools,
  ItemPropertyAttackBonus,
  ItemPropertyAttackBonusVsAlign,
  ItemPropertyAttackBonusVsRace,
  ItemPropertyAttackBonusVsSAlign,
  ItemPropertyAttackPenalty,
  ItemPropertyUnlimitedAmmo,
  ItemPropertyLimitUseByAlign,
  ItemPropertyLimitUseByClass,
  ItemPropertyLimitUseByRace,
  ItemPropertyLimitUseBySAlign,
  BadBadReplaceMeThisDoesNothing,
  ItemPropertyVampiricRegeneration,
  ItemPropertyTrap,
  ItemPropertyTrueSeeing,
  ItemPropertyOnMonsterHitProperties,
  ItemPropertyTurnResistance,
  ItemPropertyMassiveCritical,
  ItemPropertyFreeAction,
  ItemPropertyMonsterDamage,
  ItemPropertyImmunityToSpellLevel,
  ItemPropertySpecialWalk,
  ItemPropertyHealersKit,
  ItemPropertyWeightIncrease,
  GetIsSkillSuccessful,
  EffectSpellFailure,
  SpeakStringByStrRef,
  SetCutsceneMode,
  GetLastPCToCancelCutscene,
  GetDialogSoundLength,
  FadeFromBlack,
  FadeToBlack,
  StopFade,
  BlackScreen,
  GetBaseAttackBonus,
  SetImmortal,
  OpenInventory,
  StoreCameraFacing,
  RestoreCameraFacing,
  LevelUpHenchman,
  SetDroppableFlag,
  GetWeight,
  GetModuleItemAcquiredBy,
  GetImmortal,
  DoWhirlwindAttack,
  Get2DAString,
  EffectEthereal,
  GetAILevel,
  SetAILevel,
  GetIsPossessedFamiliar,
  UnpossessFamiliar,
  GetIsAreaInterior,
  SendMessageToPCByStrRef,
  IncrementRemainingFeatUses,
  ExportSingleCharacter,
  PlaySoundByStrRef,
  SetSubRace,
  SetDeity,
  GetIsDMPossessed,
  GetWeather,
  GetIsAreaNatural,
  GetIsAreaAboveGround,
  GetPCItemLastEquipped,
  GetPCItemLastEquippedBy,
  GetPCItemLastUnequipped,
  GetPCItemLastUnequippedBy,
  CopyItemAndModify,
  GetItemAppearance,
  ItemPropertyOnHitCastSpell,
  GetItemPropertySubType,
  GetActionMode,
  SetActionMode,
  GetArcaneSpellFailure,
  ActionExamine,
  ItemPropertyVisualEffect,
  SetLootable,
  GetLootable,
  GetCutsceneCameraMoveRate,
  SetCutsceneCameraMoveRate,
  GetItemCursedFlag,
  SetItemCursedFlag,
  SetMaxHenchmen,
  GetMaxHenchmen,
  GetAssociateType,
  GetSpellResistance,
  DayToNight,
  NightToDay,
  LineOfSightObject,
  LineOfSightVector,
  GetLastSpellCastClass,
  SetBaseAttackBonus,
  RestoreBaseAttackBonus,
  EffectCutsceneGhost,
  ItemPropertyArcaneSpellFailure,
  GetStoreGold,
  SetStoreGold,
  GetStoreMaxBuyPrice,
  SetStoreMaxBuyPrice,
  GetStoreIdentifyCost,
  SetStoreIdentifyCost,
  SetCreatureAppearanceType,
  GetCreatureStartingPackage,
  EffectCutsceneImmobilize,
  GetIsInSubArea,
  GetItemPropertyCostTable,
  GetItemPropertyCostTableValue,
  GetItemPropertyParam1,
  GetItemPropertyParam1Value,
  GetIsCreatureDisarmable,
  SetStolenFlag,
  ForceRest,
  SetCameraHeight,
  SetSkyBox,
  GetPhenoType,
  SetPhenoType,
  SetFogColor,
  GetCutsceneMode,
  GetSkyBox,
  GetFogColor,
  SetFogAmount,
  GetFogAmount,
  GetPickpocketableFlag,
  SetPickpocketableFlag,
  GetFootstepType,
  SetFootstepType,
  GetCreatureWingType,
  SetCreatureWingType,
  GetCreatureBodyPart,
  SetCreatureBodyPart,
  GetCreatureTailType,
  SetCreatureTailType,
  GetHardness,
  SetHardness,
  SetLockKeyRequired,
  SetLockKeyTag,
  SetLockLockable,
  SetLockUnlockDC,
  SetLockLockDC,
  SetTrapDisarmable,
  SetTrapDetectable,
  SetTrapOneShot,
  SetTrapKeyTag,
  SetTrapDisarmDC,
  SetTrapDetectDC,
  CreateTrapAtLocation,
  CreateTrapOnObject,
  SetWillSavingThrow,
  SetReflexSavingThrow,
  SetFortitudeSavingThrow,
  GetTilesetResRef,
  GetTrapRecoverable,
  SetTrapRecoverable,
  GetModuleXPScale,
  SetModuleXPScale,
  GetKeyRequiredFeedback,
  SetKeyRequiredFeedback,
  GetTrapActive,
  SetTrapActive,
  LockCameraPitch,
  LockCameraDistance,
  LockCameraDirection,
  GetPlaceableLastClickedBy,
  GetInfiniteFlag,
  SetInfiniteFlag,
  GetAreaSize,
  SetName,
  GetPortraitId,
  SetPortraitId,
  GetPortraitResRef,
  SetPortraitResRef,
  SetUseableFlag,
  GetDescription,
  SetDescription,
  GetPCChatSpeaker,
  GetPCChatMessage,
  GetPCChatVolume,
  SetPCChatMessage,
  SetPCChatVolume,
  GetColor,
  SetColor,
  ItemPropertyMaterial,
  ItemPropertyQuality,
  ItemPropertyAdditional,
  SetTag,
  GetEffectTag,
  TagEffect,
  GetEffectCasterLevel,
  GetEffectDuration,
  GetEffectDurationRemaining,
  GetItemPropertyTag,
  TagItemProperty,
  GetItemPropertyDuration,
  GetItemPropertyDurationRemaining,
  CreateArea,
  DestroyArea,
  CopyArea,
  GetFirstArea,
  GetNextArea,
  SetTransitionTarget,
  SetHiddenWhenEquipped,
  GetHiddenWhenEquipped,
  SetTileExplored,
  GetTileExplored,
  SetCreatureExploresMinimap,
  GetCreatureExploresMinimap,
  GetSurfaceMaterial,
  GetGroundHeight,
  GetAttackBonusLimit,
  GetDamageBonusLimit,
  GetSavingThrowBonusLimit,
  GetAbilityBonusLimit,
  GetAbilityPenaltyLimit,
  GetSkillBonusLimit,
  SetAttackBonusLimit,
  SetDamageBonusLimit,
  SetSavingThrowBonusLimit,
  SetAbilityBonusLimit,
  SetAbilityPenaltyLimit,
  SetSkillBonusLimit,
  GetIsPlayerConnectionRelayed,
  GetEventScript,
  SetEventScript,
  GetObjectVisualTransform,
  SetObjectVisualTransform,
  SetMaterialShaderUniformI,
  SetMaterialShaderUniformVec4,
  ResetMaterialShaderUniforms,
  Vibrate,
  UnlockAchievement,
  ExecuteScriptChunk,
  GetRandomUUID,
  GetObjectUUID,
  ForceRefreshObjectUUID,
  GetObjectByUUID,
  OpenTutorialWindow,
  SetTextureOverride,
  PostString,
  GetSpecialization,
  GetDomain,
  GetPlayerBuildVersion,
  GetPlayerPatchRevision,
  GetScriptParam,
  SetScriptParam,
  GetItempropertyUsesPerDayRemaining,
  SetItempropertyUsesPerDayRemaining,
  ActionUseItemOnObject,
  ActionUseItemAtLocation,
  EnterTargetingMode,
  GetTargetingModeSelectedObject,
  GetTargetingModeSelectedPosition,
  GetLastPlayerToSelectTarget,
  SetObjectHiliteColor,
  SetObjectMouseCursor,
  GetIsPlayerDM,
  SetAreaWind,
  ReplaceObjectTexture,
  SqlResetDatabase,
  SqlGetError,
  SqlPrepareQueryStr,
  SqlPrepareQueryObj,
  SqlBindInt,
  SqlBindFloat,
  SqlBindString,
  SqlBindVector,
  SqlBindObject,
  SqlStep,
  SqlGetInt,
  SqlGetFloat,
  SqlGetString,
  SqlGetVector,
  SqlGetObject,
  StringToObject,
  SetCurrentHitPoints,
  GetCurrentlyRunningEvent,
  GetEffectInteger,
  GetEffectFloat,
  GetEffectString,
  GetEffectObject,
  GetEffectVector,
  GetBaseitemFitsInInventory,
  GetLocalCswy,
  SetLocalCswy,
  DeleteLocalCswy,
  CswyReset,
  CswyConstrain,
  CswySuggest,
  CswyGetValue,
  CswyDebug,
  SetTLKOverride,
  ItemEffectCustom,
  EffectRunScript,
  GetLastRunScriptEffect,
  GetLastRunScriptEffectScriptType,
  HideEffectIcon,
  EffectIcon,
  GetLastGuiEventPlayer,
  GetLastGuiEventType,
  GetLastGuiEventInteger,
  GetLastGuiEventObject,
  SetGuiPanelDisabled,
  GetLastTileActionId,
  GetLastTileActionPosition,
  GetLastPlayerToDoTileAction,
  JsonParse,
  JsonDump,
  JsonGetType,
  JsonGetLength,
  JsonGetError,
  JsonNull,
  JsonObject,
  JsonArray,
  JsonString,
  JsonInt,
  JsonFloat,
  JsonBool,
  JsonAsString,
  JsonAsInt,
  JsonAsFloat,
  JsonObjectKeys,
  JsonObjectGet,
  JsonObjectSet,
  JsonObjectDel,
  JsonArrayGet,
  JsonArraySet,
  JsonArrayInsert,
  JsonArrayDel,
  ObjectToJson,
  JsonToObject,
  JsonPointer,
  JsonPatch,
  JsonDiff,
  JsonMerge,
  GetLocalJson,
  SetLocalJson,
  DeleteLocalJson,
  SqlBindJson,
  SqlGetJson,
  SetCamppaignJson,
  GetCampaignJson,
  GetPlayerDeviceProperty,
  GetPlayerLanguage,
  GetPlayerPlatform,
  TemplateToJson,
  ResmanGetAliasFor,
  ResmanFindPrefix,
  NuiCreateResRef,
  NuiCreate,
  NuiFind,
  NuiDestroy,
  NuiGetEventPlayer,
  NuiGetEventWindow,
  NuiGetEventType,
  NuiGetEventElement,
  NuiGetEventArrayIndex,
  NuiGetWindowById,
  NuiGetBind,
  NuiSetBind,
  NuiSetLayout,
  NuiSetBindWatch,
  NuiGetNthWindow,
  NuiGetNthBind,
  NuiGetEventpayload,
  NuiGetUserData,
  NuiSetUserData,
  GetScriptInstructionsRemaining,
  JsonArrayTransform,
  JsonFind,
  JsonArrayRange,
  JsonSetOp,
  Get2DAColumn,
  Get2DARowCount
}

}
