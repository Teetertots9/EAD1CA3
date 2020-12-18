using System;
using System.Collections.Generic;


namespace CA3.Shared
{
    public class Volume
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class BoilVolume
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Temp
    {
        public Nullable<int> value { get; set; }
        public string unit { get; set; }
    }

    public class MashTemp
    {
        public Temp temp { get; set; }
        public Nullable<int> duration { get; set; }
    }

    public class Temp2
    {
        public Nullable<int> value { get; set; }
        public string unit { get; set; }
    }

    public class Fermentation
    {
        public Temp2 temp { get; set; }
    }

    public class Method
    {
        public List<MashTemp> mash_temp { get; set; }
        public Fermentation fermentation { get; set; }
        public object twist { get; set; }
    }

    public class Amount
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class Malt
    {
        public string name { get; set; }
        public Amount amount { get; set; }
    }

    public class Amount2
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class Hop
    {
        public string name { get; set; }
        public Amount2 amount { get; set; }
        public string add { get; set; }
        public string attribute { get; set; }
    }

    public class Ingredients
    {
        public List<Malt> malt { get; set; }
        public List<Hop> hops { get; set; }
        public string yeast { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string first_brewed { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public double abv { get; set; }
        public Nullable<double> ibu { get; set; }
        public double target_fg { get; set; }
        public double target_og { get; set; }
        public Nullable<double> ebc { get; set; }
        public Nullable<double> srm { get; set; }
        public Nullable<double> ph { get; set; }
        public double attenuation_level { get; set; }
        public Volume volume { get; set; }
        public BoilVolume boil_volume { get; set; }
        public Method method { get; set; }
        public Ingredients ingredients { get; set; }
        public List<string> food_pairing { get; set; }
        public string brewers_tips { get; set; }
        public string contributed_by { get; set; }
    }
}
