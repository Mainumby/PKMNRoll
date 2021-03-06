﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PokemonRoll
{
    [DataContract]
    class JsonPoke : JsonForward
    {
        [DataMember(Name = "abilities")]
        public IList<JsonForward> abilities { get; set; }       //Ability array[] JsonForward
        [DataMember(Name = "catch_rate")]
        public int catch_rate { get; set; }                     //catch_rate int
        [DataMember(Name = "created")]
        public string created { get; set; }                     //Created string
        [DataMember(Name = "descriptions")]
        public IList<JsonForward> descriptions { get; set; }    //descriptions array[] JsonForward
        [DataMember(Name = "egg_cycles")]
        public int egg_cycles { get; set; }                     //egg_cycles int
        [DataMember(Name = "egg_groups")]
        public IList<JsonForward> egg_groups { get; set; }      //egg_groups array[] JsonForward
        [DataMember(Name = "ev_yield")]
        public string ev_yield { get; set; }                    //evYeild string
        [DataMember(Name = "evolutions")]
        public IList<JsonEvelution> evolutions { get; set; }    //evelutions array[] JsonEvelution
        [DataMember(Name = "growth_rate")]
        public string growth_rate { get; set; }                 //groathrate string
        [DataMember(Name = "male_female_ratio")]
        public string male_female_ratio { get; set; }           //male_female_ratio string
        [DataMember(Name = "moves")]
        IList<JsonMoves> moves { get; set; }                    //moves array[] JsonMoves
        [DataMember(Name = "species")]
        public string species { get; set; }                     //species string
        [DataMember(Name = "sprites")]
        IList<JsonForward> sprites { get; set; }                //sprites array[] JsonForward
        [DataMember(Name = "total")]
        public int total { get; set; }                          //total int
        
        

        //Dex Info
        [DataMember(Name = "weight")]
        public int weight { get; set; }                         //weight int
        [DataMember(Name = "height")]
        public int height { get; set; }                         //height int
        [DataMember(Name = "types")]
        IList<JsonForward> types { get; set; }                  //types array[] JsonForward
        [DataMember(Name = "national_id")]
        public int national_id { get; set; }                    //natonal_id int
        [DataMember(Name = "pkdx_id")]
        public int pkdx_id { get; set; }                        //pkdx_id int

        //Base Stats;
        [DataMember(Name = "attack")]
        public int attack { get; set; }                         //Atack int
        [DataMember(Name = "defense")]
        public int defense { get; set; }                        //Defence int
        [DataMember(Name = "hp")]
        public int hp { get; set; }                             //hp int
        [DataMember(Name = "sp_atk")]
        public int sp_atk { get; set; }                         //sp_atk int
        [DataMember(Name = "sp_def")]
        public int sp_def { get; set; }                         //sp_def int
        [DataMember(Name = "speed")]
        public int speed { get; set; }                          //speed int
        [DataMember(Name = "exp")]
        public int exp { get; set; }                            //exp int
        [DataMember(Name = "happiness")]
        public int happiness { get; set; }                      //happiness int
    }

    [DataContract]
    class JsonForward
    {
        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "resource_uri")]
        public string resource_uri { get; set; }
    }

    [DataContract]
    class JsonEvelution : JsonForward
    {
        [DataMember(Name = "level")]
        public int level { get; set; }             //Level int
        [DataMember(Name = "method")]
        public string method { get; set; }         //Method string
        [DataMember(Name = "to")]
        public string to { get; set; }             //to string
    }

    [DataContract]
    class JsonMoves : JsonForward
    {
        [DataMember(Name = "learn_type")]
        public string learn_type { get; set; }         //learn_type string
    }
}
