﻿using Newtonsoft.Json;

namespace AtomicMarketApiClient.Sales
{
    public class SalesDto
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public DataDto[] Data { get; set; }

        public class DataDto
        {
            [JsonProperty("market_contract")]
            public string MarketContract { get; set; }

            [JsonProperty("assets_contract")]
            public string AssetsContract { get; set; }

            [JsonProperty("sale_id")]
            public string SaleId { get; set; }

            [JsonProperty("seller")]
            public string Seller { get; set; }

            [JsonProperty("buyer")]
            public string Buyer{ get; set; }

            [JsonProperty("offer_id")]
            public string OfferId { get; set; }

            [JsonProperty("price")]
            public PriceDto Price { get; set; }

            [JsonProperty("listing_price")]
            public int LostingPrice{ get; set; }

            [JsonProperty("listing_symbol")]
            public string ListingSymbol { get; set; }

            [JsonProperty("assets")]
            public AssetDto[] Assets { get; set; }

            [JsonProperty("maker_marketplace")]
            public string MakerMarketplace { get; set; }

            [JsonProperty("taker_marketplace")]
            public string TakerMarketplace { get; set; }

            [JsonProperty("collection")]
            public CollectionDto Collection { get; set; }

            [JsonProperty("state")]
            public int State { get; set; }

            [JsonProperty("updated_at_block")]
            public string UpdatedAtBlock { get; set; }

            [JsonProperty("updated_at_time")]
            public string UpdatedAtTime { get; set; }

            [JsonProperty("created_at_block")]
            public string CreatedAtBlock { get; set; }

            [JsonProperty("created_at_time")]
            public string CreatedAtTime { get; set; }

            public class PriceDto
            {
                [JsonProperty("amount")]
                public string Amount { get; set; }

                [JsonProperty("token_precision")]
                public int TokenPrecision { get; set; }

                [JsonProperty("token_contract")]
                public string TokenContract { get; set; }

                [JsonProperty("token_symbol")]
                public string TokenSymbol { get; set; }
            }

            public class AssetDto
            {
                [JsonProperty("contract")]
                public string Contract { get; set; }

                [JsonProperty("asset_id")]
                public string AssetId { get; set; }

                [JsonProperty("owner")]
                public string Owner { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("is_transferable")]
                public bool Transferable { get; set; }

                [JsonProperty("is_burnable")]
                public bool Burnable { get; set; }

                [JsonProperty("template_mint")]
                public string TemplateMint { get; set; }

                [JsonProperty("collection")]
                public CollectionDto Collection { get; set; }

                [JsonProperty("schema")]
                public SchemaDto Schema { get; set; }

                [JsonProperty("template")]
                public TemplateDto Template{ get; set; }

                [JsonProperty("mutable_data")]
                public object MutableData { get; set; }

                [JsonProperty("data")]
                public object Data { get; set; }

                [JsonProperty("immutable_data")]
                public object ImmutableData { get; set; }

                [JsonProperty("backed_tokens")]
                public BackedTokensDto[] BackedTokens { get; set; }

                [JsonProperty("burned_by_account")]
                public string BurnedByAccount { get; set; }

                [JsonProperty("burned_at_block")]
                public string BurnedAtBlock { get; set; }

                [JsonProperty("burned_at_time")]
                public string BurnedAtTime { get; set; }

                [JsonProperty("updated_at_block")]
                public string UpdatedAtBlock { get; set; }

                [JsonProperty("updated_at_time")]
                public string UpdatedAtTime { get; set; }

                [JsonProperty("transferred_at_block")]
                public string TransferredAtBlock { get; set; }

                [JsonProperty("transferred_at_time")]
                public string TransferredAtTime { get; set; }

                [JsonProperty("minted_at_block")]
                public string MintedAtBlock { get; set; }

                [JsonProperty("minted_at_time")]
                public string MintedAtTime { get; set; }

                public class BackedTokensDto
                {
                    [JsonProperty("token_contract")]
                    public string TokenContract { get; set; }

                    [JsonProperty("token_symbol")]
                    public string TokenSymbol { get; set; }

                    [JsonProperty("token_precision")]
                    public int TokenPrecision { get; set; }

                    [JsonProperty("amount")]
                    public string Amount { get; set; }
                }

                public class TemplateDto
                {
                    [JsonProperty("template_id")]
                    public string TemplateId { get;set; }

                    [JsonProperty("max_supply")]
                    public string MaxSupply { get;set; }

                    [JsonProperty("is_transferable")]
                    public bool Transferable { get; set; }

                    [JsonProperty("is_burnable")]
                    public bool Burnable { get; set; }

                    [JsonProperty("issued_supply")]
                    public string IssuedSupply { get; set; }

                    [JsonProperty("created_at_block")]
                    public float CreatedAtBlock { get; set; }

                    [JsonProperty("created_at_time")]
                    public float CreatedAtTime { get; set; }

                    [JsonProperty("immutable_data")]
                    public ImmutableDataDto ImmutableData { get; set; }

                    public class ImmutableDataDto
                    {
                        [JsonProperty("img")]
                        public string Image { get; set; }

                        [JsonProperty("name")]
                        public string Name { get; set; }
                    }
                }

                public class SchemaDto
                {
                    [JsonProperty("schema_name")]
                    public string SchemaName { get; set; }

                    [JsonProperty("format")]
                    public FormatDto[] Format { get; set; }

                    [JsonProperty("created_at_block")]
                    public float CreatedAtBlock { get; set; }

                    [JsonProperty("created_at_time")]
                    public float CreatedAtTime { get; set; }

                    public class FormatDto
                    {
                        [JsonProperty("name")]
                        public string Name { get; set; }

                        [JsonProperty("type")]
                        public string Type { get; set; }
                    }
                }
            }

            public class CollectionDto
            {
                [JsonProperty("collection_name")]
                public string CollectionName { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("author")]
                public string Author { get; set; }

                [JsonProperty("allow_notify")]
                public bool AllowNotify { get; set; }

                [JsonProperty("authorized_accounts")]
                public string[] AuthorizedAccounts { get; set; }

                [JsonProperty("notify_accounts")]
                public string[] NotifyAccounts { get; set; }

                [JsonProperty("market_fee")]
                public float MarketFee { get; set; }

                [JsonProperty("created_at_block")]
                public float CreatedAtBlock { get; set; }

                [JsonProperty("created_at_time")]
                public float CreatedAtTime { get; set; }
            }
        }
    }
}
