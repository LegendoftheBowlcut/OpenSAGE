﻿using OpenSage.Data.Ini.Parser;

namespace OpenSage.Logic.Object
{
    [AddedIn(SageGame.Bfme)]
    public sealed class CastleUpgradeModuleData : UpgradeModuleData
    {
        internal static CastleUpgradeModuleData Parse(IniParser parser) => parser.ParseBlock(FieldParseTable);

        private static new readonly IniParseTable<CastleUpgradeModuleData> FieldParseTable = UpgradeModuleData.FieldParseTable
            .Concat(new IniParseTable<CastleUpgradeModuleData>
            {
                { "Upgrade", (parser, x) => x.Upgrade = parser.ParseAssetReference() }
            });

        public string Upgrade { get; private set; }
    }
}
