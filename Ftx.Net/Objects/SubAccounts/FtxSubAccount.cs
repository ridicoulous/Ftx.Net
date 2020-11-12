using Newtonsoft.Json;


namespace Ftx.Net.Objects.SubAccounts
{
    public class FtxSubAccount
    {
        /// <summary>
        /// subaccount name
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        /// <summary>
        /// whether the subaccount can be deleted
        /// </summary>
        [JsonProperty("deletable")]
        public bool IsDeletable { get; set; }
        /// <summary>
        /// whether the nickname of the subaccount can be changed
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        /// <summary>
        /// whether the subaccount was created for a competition
        /// </summary>
        [JsonProperty("competition")]
        public bool? Competition { get; set; }
    }
}
