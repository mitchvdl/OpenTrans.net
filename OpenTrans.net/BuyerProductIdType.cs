﻿
namespace OpenTrans.net
{
    public enum BuyerProductIdType
    {
        /// <summary> Artikelnummer des einkaufenden Unternehmens </summary>
        BuyerSpecific,

        /// <summary> Europäische Artikelnummer (14 Zeichen), s. http://www.ean-int.org </summary>
        EAN,

        /// <summary> Global Trade Item Number, s. http://www.uc-council.org/2005sunrise/global_trade_item_number.html </summary>
        GTIN,

        /// <summary> Universal Product Code, s. http://www.ean.de/ean/Inhalt/e2/e8/e335 </summary>
        UPC,

        Unknown
    }
    public static class BuyerProductIdTypeExtensions
    {
        public static BuyerProductIdType FromString(this BuyerProductIdType _c, string s)
        {
            s = s.ToLower().Trim();
            switch (s)
            {
                case "buyer_specific": return BuyerProductIdType.BuyerSpecific;
                case "ean": return BuyerProductIdType.EAN;
                case "gtin": return BuyerProductIdType.GTIN;
                case "upc": return BuyerProductIdType.UPC;

                default: return BuyerProductIdType.Unknown;
            }
        } // !FromString()


        public static string EnumToString(this BuyerProductIdType c)
        {
            switch (c)
            {
                case BuyerProductIdType.BuyerSpecific: return "buyer_specific";
                case BuyerProductIdType.EAN: return "ean";
                case BuyerProductIdType.GTIN: return "gtin";
                case BuyerProductIdType.UPC: return "upc";

                default: return "";
            }
        } // !ToString()
    }
}

