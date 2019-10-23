﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace -Countries.Prism.Models
{
    class pais
{
    ][JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "topLevelDomain")]
    public List<string> TopLevelDomain { get; set; }

    [JsonProperty(PropertyName = "alpha2Code")]
    public string Alpha2Code { get; set; }

    [JsonProperty(PropertyName = "alpha3Code")]
    public string Alpha3Code { get; set; }

    [JsonProperty(PropertyName = "callingCodes")]
    public List<string> CallingCodes { get; set; }

    [JsonProperty(PropertyName = "capital")]
    public string Capital { get; set; }

    [JsonProperty(PropertyName = "altSpellings")]
    public List<string> AltSpellings { get; set; }

    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    [JsonProperty(PropertyName = "subregion")]
    public string Subregion { get; set; }

    [JsonProperty(PropertyName = "currencies")]
    public List<Moneda> Currencies { get; set; }

    [JsonProperty(PropertyName = "languages")]
    public List<idioma> Languages { get; set; }
}
}
