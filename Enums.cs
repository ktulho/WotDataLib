﻿using System;

namespace WotDataLib
{
    /// <summary>Represents one of the WoT countries.</summary>
    public enum Country
    {
        USSR,
        Germany,
        USA,
        France,
        China,
        UK,
        Japan,
        Czech,
        Sweden,
        Poland,
        Italy,
        Intunion,
        None,
    }

    /// <summary>Represents one of the possible tank classes: light/medium/heavy, tank destroyer, and artillery.</summary>
    public enum Class
    {
        Light,
        Medium,
        Heavy,
        Destroyer,
        Artillery,
        None,
    }

    /// <summary>Represents one of the possible tank availability categories based on how (and whether) they can be bought.</summary>
    public enum Category
    {
        /// <summary>This tank can be bought for silver.</summary>
        Normal,
        /// <summary>This tank can be bought for gold only.</summary>
        Premium,
        /// <summary>This tank cannot be bought at all.</summary>
        Special,
        /// <summary>This tank is available as a collectors' vehicle.</summary>
        Collector,
    }

}
