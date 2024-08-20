using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("ip")]
    public string ip { get; set; }

    [JsonProperty("baseDomain")]
    public string baseDomain { get; set; }

    [JsonProperty("fqdn")]
    public string fqdn { get; set; }

    [JsonProperty("detected")]
    public bool detected { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
