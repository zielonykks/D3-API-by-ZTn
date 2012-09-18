﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ZTn.BNet.D3.Items
{
    [DataContract]
    public class Item : ItemSummary
    {
        #region >> Properties

        [DataMember]
        public int requiredLevel;
        [DataMember]
        public int itemLevel;
        [DataMember]
        public int bonusAffixes;
        [DataMember]
        public String typeName;
        [DataMember]
        public ItemType type;
        [DataMember]
        public ItemValueRange dps;
        [DataMember]
        public ItemValueRange attacksPerSecond;
        [DataMember]
        public ItemValueRange minDamage;
        [DataMember]
        public ItemValueRange maxDamage;
        [DataMember]
        public ItemValueRange armor;
        [DataMember]
        public String[] attributes;
        [DataMember]
        public ItemAttributes attributesRaw;
        // [DataMember]
        // public SocketEffect[] socketEffects;
        [DataMember]
        public ItemSalvageComponent[] salvage;
        [DataMember]
        public Item[] gems;

        #endregion

        public static Item getItemFromTooltipParams(String tooltipParams)
        {
            return D3Api.getItemFromTooltipParams(tooltipParams);
        }

        public static Item getItemFromJSonStream(Stream stream)
        {
            DataContractJsonSerializer jsSerializer = new DataContractJsonSerializer(typeof(Item));
            Item item = (Item)jsSerializer.ReadObject(stream);
            return item;
        }

        public static Item getItemFromJSonString(String json)
        {
            Item item;
            using (MemoryStream stream = new MemoryStream(System.Text.Encoding.Default.GetBytes(json)))
            {
                item = getItemFromJSonStream(stream);
            }
            return item;
        }
    }
}
