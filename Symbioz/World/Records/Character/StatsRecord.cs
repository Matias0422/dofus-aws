
// AutoGenerated Class
using Symbioz.Core;
using Symbioz.DofusProtocol.Types;
using Symbioz.Enums;
using Symbioz.Network.Servers;
using Symbioz.ORM;
using Symbioz.Providers.SpellEffectsProvider.Buffs;
using Symbioz.World.Models;
using Symbioz.World.Models.Fights.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Symbioz.World.Records
{
    [Table("Stats", true)]
    public class StatsRecord : ITable
    {
        public static List<StatsRecord> Stats = new List<StatsRecord>();


        [Primary]
        public int CharacterId;
        [UpdateAttribute]
        public short LifePoints;
        [UpdateAttribute]
        public short MaxEnergyPoints;
        [UpdateAttribute]
        public short Initiative;
        [UpdateAttribute]
        public short Prospecting;
        [UpdateAttribute]
        public short ActionPoints;
        [UpdateAttribute]
        public short MovementPoints;
        [UpdateAttribute]
        public short ContextStrength;
        [UpdateAttribute]
        public short ContextVitality;
        [UpdateAttribute]
        public short ContextWisdom;
        [UpdateAttribute]
        public short ContextChance;
        [UpdateAttribute]
        public short ContextAgility;
        [UpdateAttribute]
        public short ContextIntelligence;
        [UpdateAttribute]
        public short _Range;
        [UpdateAttribute]
        public short SummonableCreaturesBoost;
        [UpdateAttribute]
        public short Reflect;
        [UpdateAttribute]
        public short CriticalHit;
        [UpdateAttribute]
        public short CriticalHitWeapon;
        [UpdateAttribute]
        public short HealBonus;
        [UpdateAttribute]
        public short AllDamagesBonus;
        [UpdateAttribute]
        public short AllDamagesBonusPercent;
        [UpdateAttribute]
        public short WeaponDamagesBonusPercent;
        [UpdateAttribute]
        public short TrapBonus;
        [UpdateAttribute]
        public short TrapBonusPercent;
        [UpdateAttribute]
        public short GlyphBonusPercent;
        [UpdateAttribute]
        public short PushDamageBonus;
        [UpdateAttribute]
        public short CriticalDamageBonus;
        [UpdateAttribute]
        public short NeutralDamageBonus;
        [UpdateAttribute]
        public short EarthDamageBonus;
        [UpdateAttribute]
        public short WaterDamageBonus;
        [UpdateAttribute]
        public short AirDamageBonus;
        [UpdateAttribute]
        public short FireDamageBonus;
        [UpdateAttribute]
        public short DodgePA;
        [UpdateAttribute]
        public short DodgePM;
        [UpdateAttribute]
        public short NeutralResistPercent;
        [UpdateAttribute]
        public short EarthResistPercent;
        [UpdateAttribute]
        public short WaterResistPercent;
        [UpdateAttribute]
        public short AirResistPercent;
        [UpdateAttribute]
        public short FireResistPercent;
        [UpdateAttribute]
        public short NeutralReduction;
        [UpdateAttribute]
        public short EarthReduction;
        [UpdateAttribute]
        public short WaterReduction;
        [UpdateAttribute]
        public short AirReduction;
        [UpdateAttribute]
        public short FireReduction;
        [UpdateAttribute]
        public short PushDamageReduction;
        [UpdateAttribute]
        public short CriticalDamageReduction;
        [UpdateAttribute]
        public short PvPNeutralResistPercent;
        [UpdateAttribute]
        public short PvPEarthResistPercent;
        [UpdateAttribute]
        public short PvPWaterResistPercent;
        [UpdateAttribute]
        public short PvPAirResistPercent;
        [UpdateAttribute]
        public short PvPFireResistPercent;
        [UpdateAttribute]
        public short PvPNeutralReduction;
        [UpdateAttribute]
        public short PvPEarthReduction;
        [UpdateAttribute]
        public short PvPWaterReduction;
        [UpdateAttribute]
        public short PvPAirReduction;
        [UpdateAttribute]
        public short PvPFireReduction;
        [UpdateAttribute]
        public short GlobalDamageReduction;
        [UpdateAttribute]
        public short BaseStrength;
        [UpdateAttribute]
        public short BaseAgility;
        [UpdateAttribute]
        public short BaseChance;
        [UpdateAttribute]
        public short BaseVitality;
        [UpdateAttribute]
        public short BaseWisdom;
        [UpdateAttribute]
        public short BaseIntelligence;
        [UpdateAttribute]
        public short PermanentStrenght;
        [UpdateAttribute]
        public short PermanentAgility;
        [UpdateAttribute]
        public short PermanentChance;
        [UpdateAttribute]
        public short PermanentVitality;
        [UpdateAttribute]
        public short PermanentWisdom;
        [UpdateAttribute]
        public short PermanentIntelligence;
        [UpdateAttribute]
        public short ContextAPReduction;



        public short Strength { get { return (short)(ContextStrength + BaseStrength + PermanentStrenght); } set { ContextStrength = value; } }
        public short Agility { get { return (short)(ContextAgility + BaseAgility + PermanentAgility); } set { ContextAgility = value; } }
        public short Chance { get { return (short)(ContextChance + BaseChance + PermanentChance); } set { ContextChance = value; } }
        public short Vitality { get { return (short)(ContextVitality + BaseVitality + PermanentVitality); } set { ContextVitality = value; } }
        public short Intelligence { get { return (short)(ContextIntelligence + BaseIntelligence + PermanentIntelligence); } set { ContextIntelligence = value; } }
        public short Wisdom { get { return (short)(ContextWisdom + BaseWisdom + PermanentWisdom); } set { BaseWisdom = value; } }
        [Ignore]
        public short APReduction { get { return (short)(Wisdom / 10); } }
        [Ignore]
        public short APAttack { get { return (short)(Wisdom / 10); } }
        [Ignore]
        public short MPAttack { get { return (short)(Agility / 10); } }
        public StatsRecord Clone()
        {
            return new StatsRecord(CharacterId, LifePoints, MaxEnergyPoints, Initiative, Prospecting,
                ActionPoints, MovementPoints, ContextStrength, ContextVitality, ContextWisdom, ContextChance,
                ContextAgility, ContextIntelligence, _Range, SummonableCreaturesBoost, Reflect, CriticalHit, CriticalHitWeapon,
                HealBonus, AllDamagesBonus, AllDamagesBonusPercent, WeaponDamagesBonusPercent, TrapBonus,
                TrapBonusPercent, GlyphBonusPercent, PushDamageBonus, CriticalDamageBonus, NeutralDamageBonus,
                EarthDamageBonus, WaterDamageBonus, AirDamageBonus, FireDamageBonus, DodgePA,
                DodgePM, NeutralResistPercent, EarthResistPercent, WaterResistPercent, AirResistPercent,
                FireResistPercent, NeutralReduction, EarthReduction, WaterReduction, AirReduction, FireReduction,
                PushDamageReduction, CriticalDamageReduction, PvPNeutralResistPercent, PvPEarthResistPercent,
                PvPWaterResistPercent, PvPAirResistPercent, PvPFireResistPercent, PvPNeutralReduction,
                PvPEarthReduction, PvPWaterReduction, PvPAirReduction, PvPFireReduction, GlobalDamageReduction,BaseStrength,BaseAgility,
                BaseChance,BaseVitality,BaseIntelligence,BaseWisdom,PermanentStrenght,PermanentAgility,PermanentChance,PermanentVitality,PermanentWisdom,PermanentIntelligence,ContextAPReduction);
        }
        public StatsRecord(int characterid, short lifePoints, short maxenegryPoints, short initiative, short prospecting, short ap, short mp, short strenght, short vitality,
            short wisdom, short chance, short agility, short shortelligence, short range, short summonablecboos, short reflect, short criticalhit, short criticalhitweapon, short healbonus,
            short alldamagebonus, short alldamagebonuspercent, short weapondamagesbonuspercent, short trapbonus, short trapbonuspercent, short glyphbonuspercent, short pushdamagebonus, short criticaldamagebonus, short neutraldamagebonus,
            short earthdamagebonus, short waterdamagebonus, short airdamagebonus, short firedamagebonus, short dodgepa,
            short dodgepm, short neutralresistpercent, short earthresistpercent, short waterresistpercent, short airresistpercent, short fireresistpercent,
            short neutralreduc, short earthreduc, short waterreduc, short airreduc, short firereduc, short pushdamagereduc, short criticaldamagereduc, short pvpneutralresistpercent,
            short pvpearthresistpercent, short pvpwaterresistpercent, short pvpairresistpercent, short pvpfireresistpercent, short pvpneutralreduc, short pvpearthreduc, short pvpwaterreduc,
            short pvpairreduc, short pvpfirereduc, short globaldamagereduction,short basestrenght,short baseagility,short basechance,short basevitality,short basewisdom,short baseintelligence, short permanentStrenght, short permanentAgility, short permanentChance, short permanentVitality, short permanentWisdom, short permanentIntelligence,short contextAPReduction)
        {
            this.CharacterId = characterid;
            this.LifePoints = lifePoints;
            this.MaxEnergyPoints = maxenegryPoints;
            this.Initiative = initiative;
            this.Prospecting = prospecting;
            this.ActionPoints = ap;
            this.MovementPoints = mp;
            this.ContextStrength = strenght;
            this.ContextVitality = vitality;
            this.ContextWisdom = wisdom;
            this.ContextChance = chance;
            this.ContextAgility = agility;
            this.ContextIntelligence = shortelligence;
            this._Range = range;
            this.SummonableCreaturesBoost = summonablecboos;
            this.Reflect = reflect;
            this.CriticalHit = criticalhit;
            this.CriticalHitWeapon = criticalhitweapon;
            this.HealBonus = healbonus;
            this.AllDamagesBonus = alldamagebonus;
            this.AllDamagesBonusPercent = alldamagebonuspercent;
            this.WeaponDamagesBonusPercent = weapondamagesbonuspercent;
            this.TrapBonus = trapbonus;
            this.TrapBonusPercent = trapbonuspercent;
            this.GlyphBonusPercent = glyphbonuspercent;
            this.PushDamageBonus = pushdamagebonus;
            this.CriticalDamageBonus = criticaldamagebonus;
            this.NeutralDamageBonus = neutraldamagebonus;
            this.EarthDamageBonus = earthdamagebonus;
            this.WaterDamageBonus = waterdamagebonus;
            this.AirDamageBonus = airdamagebonus;
            this.FireDamageBonus = firedamagebonus;
            this.DodgePA = dodgepa;
            this.DodgePM = dodgepm;
            this.NeutralResistPercent = neutralresistpercent;
            this.EarthResistPercent = earthresistpercent;
            this.WaterResistPercent = waterresistpercent;
            this.AirResistPercent = airresistpercent;
            this.FireResistPercent = fireresistpercent;
            this.NeutralReduction = neutralreduc;
            this.WaterReduction = waterreduc;
            this.EarthReduction = earthreduc;
            this.AirReduction = airreduc;
            this.FireReduction = firereduc;
            this.PushDamageReduction = pushdamagereduc;
            this.CriticalDamageReduction = criticaldamagereduc;
            this.PvPNeutralResistPercent = pvpneutralresistpercent;
            this.PvPEarthResistPercent = pvpearthresistpercent;
            this.PvPWaterResistPercent = pvpwaterresistpercent;
            this.PvPAirResistPercent = pvpairresistpercent;
            this.PvPFireResistPercent = pvpfireresistpercent;
            this.PvPNeutralReduction = pvpneutralreduc;
            this.PvPEarthReduction = pvpearthreduc;
            this.PvPWaterReduction = pvpwaterreduc;
            this.PvPAirReduction = pvpairreduc;
            this.PvPFireReduction = pvpfirereduc;
            this.GlobalDamageReduction = globaldamagereduction;
            this.BaseStrength = basestrenght;
            this.BaseAgility = baseagility;
            this.BaseChance = basechance;
            this.BaseVitality = basevitality;
            this.BaseIntelligence = baseintelligence;
            this.BaseWisdom = basewisdom;
            this.PermanentStrenght = permanentStrenght;
            this.PermanentAgility = permanentAgility;
            this.PermanentChance = permanentChance;
            this.PermanentVitality = permanentVitality;
            this.PermanentWisdom = permanentWisdom;
            this.PermanentIntelligence = permanentIntelligence;
            this.ContextAPReduction = contextAPReduction;
    }
        public static CharacterCharacteristicsInformations GetCharacterCharacteristics(StatsRecord stats, Character character) // voir les GetBase(0)
        {
            var align = character.GetActorExtendedAlignement();
            var expFloor = ExperienceRecord.GetExperienceForLevel(character.Record.Level);

            var mpMax = character.StatsRecord.MovementPoints;
            var apMax = character.StatsRecord.ActionPoints;
          

            if (character.FighterInstance != null)
            {
                mpMax = character.FighterInstance.FighterStats.RealStats.MovementPoints;
                apMax = character.FighterInstance.FighterStats.RealStats.ActionPoints;
           
            }
            var expNextFloor = ExperienceRecord.GetExperienceForLevel((uint)(character.Record.Level + 1));
            var detailedstats = new CharacterCharacteristicsInformations(character.Record.Exp, expFloor, expNextFloor, character.Record.Kamas, character.Record.StatsPoints, 0, character.Record.SpellPoints, align,
                (uint)(character.CurrentStats.LifePoints), (uint)stats.LifePoints, character.CurrentStats.Energy, (ushort)stats.MaxEnergyPoints, stats.ActionPoints, stats.MovementPoints, GetBase((short)character.Initiative), GetBase(stats.Prospecting),
                GetBase((short)apMax), GetBase((short)mpMax), GetBase(stats.BaseStrength,stats.ContextStrength,stats.PermanentStrenght), GetBase(stats.BaseVitality,stats.ContextVitality,stats.PermanentVitality), GetBase(stats.BaseWisdom,stats.ContextWisdom,stats.PermanentWisdom), GetBase(stats.BaseChance,stats.ContextChance,stats.PermanentChance), GetBase(stats.BaseAgility,stats.ContextAgility,stats.PermanentAgility), GetBase(stats.BaseIntelligence,stats.ContextIntelligence,stats.PermanentIntelligence),
                GetBase(stats._Range), GetBase(stats.SummonableCreaturesBoost), GetBase(stats.Reflect), GetBase(stats.CriticalHit), (ushort)stats.CriticalHitWeapon, GetBase(0), GetBase(stats.HealBonus), GetBase(stats.AllDamagesBonus),
                GetBase(stats.WeaponDamagesBonusPercent), GetBase(stats.AllDamagesBonusPercent), GetBase(stats.TrapBonus), GetBase(stats.TrapBonusPercent), GetBase(stats.GlyphBonusPercent), GetBase(0),
                GetBase(0), GetBase(0), GetBase(stats.APReduction,stats.ContextAPReduction), GetBase(0), GetBase(stats.PushDamageBonus), GetBase(stats.CriticalDamageBonus), GetBase(stats.NeutralDamageBonus), GetBase(stats.EarthDamageBonus),
                GetBase(stats.WaterDamageBonus), GetBase(stats.AirDamageBonus), GetBase(stats.FireDamageBonus), GetBase(stats.DodgePA), GetBase(stats.DodgePM), GetBase(stats.NeutralResistPercent),
                GetBase(stats.EarthResistPercent), GetBase(stats.WaterResistPercent), GetBase(stats.AirResistPercent), GetBase(stats.FireResistPercent), GetBase(stats.NeutralReduction),
                GetBase(stats.EarthReduction), GetBase(stats.WaterReduction), GetBase(stats.AirReduction), GetBase(stats.FireReduction), GetBase(stats.PushDamageReduction),
                GetBase(stats.CriticalDamageReduction), GetBase(stats.PvPNeutralResistPercent), GetBase(stats.PvPEarthResistPercent), GetBase(stats.PvPWaterResistPercent), GetBase(stats.PvPAirResistPercent),
                GetBase(stats.PvPFireResistPercent), GetBase(stats.PvPNeutralReduction), GetBase(stats.PvPEarthReduction), GetBase(stats.PvPWaterReduction), GetBase(stats.PvPAirReduction), GetBase(stats.PvPFireReduction),
                new CharacterSpellModification[0], 0);
            return detailedstats;

        }
        static CharacterBaseCharacteristic GetBase(short @base,short context, short permanent = 0)
        {
            return new CharacterBaseCharacteristic(@base, permanent, context, 0, 0);
        }
        static CharacterBaseCharacteristic GetBase(short value)
        {
            return new CharacterBaseCharacteristic(value, 0, 0, 0, 0);
        }
        /// <summary>
        /// Total Initiative = ( Bonus Caractéristiques + Bonus initiative) x ( Points de vie actuels / Points de vie max )
        /// </summary>
        /// <param name="character"></param>
        public static void Create(Character character)
        {
            var breed = BreedRecord.GetBreed(character.Record.Breed);
            character.Record.SpellPoints = (ushort)ConfigurationManager.Instance.StartLevel;
            character.Record.StatsPoints = 0;
            var stats = new StatsRecord(character.Id, breed.StartLifePoints, (short)(ConfigurationManager.Instance.StartLevel * 10), breed.StartLifePoints, breed.StartProspecting, 6, 3, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            character.CurrentStats = new BasicStats((ushort)stats.MaxEnergyPoints, (uint)stats.LifePoints);
            SaveTask.AddElement(stats);
        }
        public static void InitializeCharacter(Character character)
        {
            var stats = StatsRecord.Stats.Find(x => x.CharacterId == character.Id);
            character.CurrentStats = new BasicStats((ushort)stats.MaxEnergyPoints, (uint)stats.LifePoints);
        }
        public static StatsRecord GetStatsRecord(int characterid)
        {
            return Stats.Find(x => x.CharacterId == characterid);
        }
        public static FieldInfo GetFieldInfo(string name)
        {
            var field= typeof(StatsRecord).GetField(name);
            if (field == null)
                throw new Exception("Field " + name + " dosent exist in StatRecord");
            return field;
        }
    }
}
