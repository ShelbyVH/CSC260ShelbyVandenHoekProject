﻿using Postgrest.Attributes;
using Postgrest.Models;

namespace NftHigherOrLowerGame.Model.DataBaseModels
{
    [Table("Nft")]
    public class NFT : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("imageURL")]
        public string ImageUrl { get; set; }

        [Column("blurHash")]
        public string BlurHash { get; set; }

        [Column("priceEthereum")]
        public double PriceETH { get; set; }

        [Column("priceUSD")]
        public double PriceUSD { get; set; }

        public override bool Equals(object obj)
        {
            return obj is NFT nft && Id == nft.Id;
        }

        public override int GetHashCode() { return HashCode.Combine(Id); }
    }
}
