﻿using OpenSage.Data.Ini;
using OpenSage.Data.Ini.Parser;

namespace OpenSage.Logic.Object
{
    public sealed class DumbProjectileBehavior : ObjectBehavior
    {
        internal static DumbProjectileBehavior Parse(IniParser parser) => parser.ParseBlock(FieldParseTable);

        private static readonly IniParseTable<DumbProjectileBehavior> FieldParseTable = new IniParseTable<DumbProjectileBehavior>
        {
            { "DetonateCallsKill", (parser, x) => x.DetonateCallsKill = parser.ParseBoolean() },
            { "FirstHeight", (parser, x) => x.FirstHeight = parser.ParseInteger() },
            { "SecondHeight", (parser, x) => x.SecondHeight = parser.ParseInteger() },
            { "FirstPercentIndent", (parser, x) => x.FirstPercentIndent = parser.ParsePercentage() },
            { "SecondPercentIndent", (parser, x) => x.SecondPercentIndent = parser.ParsePercentage() },
            { "GarrisonHitKillRequiredKindOf", (parser, x) => x.GarrisonHitKillRequiredKindOf = parser.ParseEnum<ObjectKinds>() },
            { "GarrisonHitKillForbiddenKindOf", (parser, x) => x.GarrisonHitKillForbiddenKindOf = parser.ParseEnum<ObjectKinds>() },
            { "GarrisonHitKillCount", (parser, x) => x.GarrisonHitKillCount = parser.ParseInteger() },
            { "GarrisonHitKillFX", (parser, x) => x.GarrisonHitKillFX = parser.ParseAssetReference() },
            { "FlightPathAdjustDistPerSecond", (parser, x) => x.FlightPathAdjustDistPerSecond = parser.ParseInteger() },
        };

        public bool DetonateCallsKill { get; private set; }

        /// <summary>
        /// Height of first Bezier control point above highest intervening terrain.
        /// </summary>
        public int FirstHeight { get; private set; }

        /// <summary>
        /// Height of second Bezier control point above highest intervening terrain.
        /// </summary>
        public int SecondHeight { get; private set; }

        /// <summary>
        /// Percentage of shot distance along which first control point are placed.
        /// </summary>
        public float FirstPercentIndent { get; private set; }

        /// <summary>
        /// Percentage of shot distance along which second control point are placed.
        /// </summary>
        public float SecondPercentIndent { get; private set; }

        public ObjectKinds GarrisonHitKillRequiredKindOf { get; private set; }
        public ObjectKinds GarrisonHitKillForbiddenKindOf { get; private set; }
        public int GarrisonHitKillCount { get; private set; }
        public string GarrisonHitKillFX { get; private set; }
        public int FlightPathAdjustDistPerSecond { get; private set; }
    }
}