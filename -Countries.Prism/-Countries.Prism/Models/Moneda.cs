using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Prism.Models
{
    public class Moneda
{
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
}
}
