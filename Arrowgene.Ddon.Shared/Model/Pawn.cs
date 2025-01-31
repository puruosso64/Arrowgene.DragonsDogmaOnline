#nullable enable
using System.Collections.Generic;
using Arrowgene.Ddon.Shared.Entity.Structure;

namespace Arrowgene.Ddon.Shared.Model
{
    public class Pawn : CharacterCommon
    {
        public Pawn()
        {
            Name = string.Empty;
            OnlineStatus = OnlineStatus.None;
            PawnReactionList = new List<CDataPawnReaction>();
            SpSkills = new Dictionary<JobId, List<CDataSpSkill>>();
            CraftData = new CDataPawnCraftData() {
                CraftExp = 0,
                CraftRank = 1,
                CraftRankLimit = 71,
                CraftPoint = 0,
                PawnCraftSkillList = new List<CDataPawnCraftSkill>() {
                    new() {Type = CraftSkillType.ProductionSpeed, Level = 0},
                    new() {Type = CraftSkillType.EquipmentEnhancement, Level = 0},
                    new() {Type = CraftSkillType.EquipmentQuality, Level = 0},
                    new() {Type = CraftSkillType.ConsumableQuantity, Level = 0},
                    new() {Type = CraftSkillType.CostPerformance, Level = 0},
                    new() {Type = CraftSkillType.Placeholder6, Level = 0},
                    new() {Type = CraftSkillType.Placeholder7, Level = 0},
                    new() {Type = CraftSkillType.Placeholder8, Level = 0},
                    new() {Type = CraftSkillType.Placeholder9, Level = 0},
                    new() {Type = CraftSkillType.Placeholder10, Level = 0}
                }
            };
            TrainingStatus = new Dictionary<JobId, byte[]>();
        }
        
        public Pawn(uint ownerCharacterId):this()
        {
            CharacterId = ownerCharacterId;
        }

        /// <summary>
        /// Id of Pawn
        /// </summary>
        public uint PawnId  { get; set; }
        
        /// <summary>
        /// Id of character who this pawn belongs to
        /// </summary>
        public uint CharacterId { get; set; }

        public string Name { get; set; }
        
        public byte HmType { get; set; }
        public byte PawnType { get; set; }

        public List<CDataPawnReaction> PawnReactionList { get; set; }
        public CDataPawnCraftData CraftData { get; set; }

        public Dictionary<JobId, byte[]> TrainingStatus { get; set; }
        public Dictionary<JobId, List<CDataSpSkill>> SpSkills { get; set; }
        public uint TrainingPoints { get; set; } // Training xp?
        public uint AvailableTraining { get; set; } // Training lv?
    }
}
